using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float storedNum;
        string num1;
        bool enterNewValue = false;
        bool calcuModePress = false;

        Operations operations = new Operations();

        public Form1()
        {
            InitializeComponent();
            clearHistory.Visible = false;
            clearMemory.Visible = false;
            btnMemClear.Enabled = false;
            btnMemRecall.Enabled = false;
            historyDisp.SelectionAlignment = HorizontalAlignment.Right;
        }


        //---------------------------Start of Operations Checking using switch()---------------------------
        private void operationsChecker()
        {

            //Checks if no operation selected and current output is 0, appends "0 = 0" to history and appends "0 =" to operations display
            if (operations.operation == string.Empty && calcuOutput.Text == "0")
            {
                clearHistory.Visible = true;
                historyContLabel.Text = "";
                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                historyDisp.AppendText("0   =   0\n\n");
                showOps.Text = "0 =";
            }

            else if (operations.operation == string.Empty)
            {
                //Checks if no operation is selected, appends "num = num" to history and "num =" to operations display
                clearHistory.Visible = true;
                historyContLabel.Text = "";
                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                historyDisp.AppendText($"{calcuOutput.Text}   =   {calcuOutput.Text}\n\n");
                showOps.Text = $"{calcuOutput.Text} =";
            }

            else if (operations.operation != string.Empty)
            {
                try
                {
                    //Compares the value stored inside the operation variable to each case, then executes the code contained inside the chosen case.
                    switch (operations.operation)
                    {
                        //Case for the addition operation
                        case "+":

                            operations.calcuOutput = calcuOutput.Text;
                            operations.showOps = showOps.Text;
                            operations.caseAdd();
                            break;

                        //Case for the subtraction operation
                        case "-":
                            operations.caseMinus();
                            break;

                        //Case for the multiplication operation
                        case "x":
                            operations.caseMultiply();
                            break;

                        //Case for the division operation
                        case "÷":
                            operations.caseDivide();
                            break;

                        default:
                            break;

                    }
                    operations.result = float.Parse(calcuOutput.Text);
                    operations.operation = "";
                    operations.operation2 = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("Math Error!");
                    calcuOutput.Text = "0";
                    showOps.Text = "";
                    operations.result = 0;
                    operations.operation = "";
                    operations.operation2 = "";

                }
            }

            else if (operations.operation2 != string.Empty)
            {
                try
                {
                    //Checks the value of operation2 for operations that are complex
                    switch (operations.operation2)
                    {
                        //Case for square root
                        case "√":
                            operations.caseOperations2();
                            break;

                        //Case for x² 
                        case "sqr":
                            operations.caseOperations2();
                            break;

                        //Case for 1/x
                        case "1/":
                            operations.caseOperations2();
                            break;

                        default:
                            break;
                    }

                    operations.result = float.Parse(calcuOutput.Text);
                    operations.operation2 = "";
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        //---------------------------End of Operations Checking using swithc()---------------------------

        

        //---------------------------Start of Button-press methods---------------------------
        private void numberButtonPress(string number)
        {
            //Checks if output text is equal to 0 or if the boolean to enter a new value is true
            //If true, sets the text to the number of the button clicked, else, appends the same number to the existing text
            //Disables enter new value unless an operation is pressed that will enable the function again. (Used for adding multiple numbers in quick succession)

            if (calcuOutput.Text == "0" || enterNewValue == true)
            {
                calcuOutput.Text = number;
                enterNewValue = false;
            }

            else
            {
                calcuOutput.Text += number;
            }

            if (operations.operation == "" || divideZero.Visible == true)
            {
                //Clears operation and operation output text after entering a new number to prevent equalsBtn.PerformClick();
                operations.operation = "";
                operations.showOps = "";
                operations.result = 0;

                //If division by zero was attempted, clicking a number enables previously disabled buttons and removes the "Cannot divide by zero" message on the output
                divideZero.Visible = false;

                sqrtBtn.Enabled = true;
                sqrBtn.Enabled = true;
                percentBtn.Enabled = true;
                fractBtn.Enabled = true;
                plusBtn.Enabled = true;
                minusBtn.Enabled = true;
                multBtn.Enabled = true;
                divideBtn.Enabled = true;
                decBtn.Enabled = true;
                plusMinusBtn.Enabled = true;

                btnMemSave.Enabled = true;
                btnMemMinus.Enabled = true;
                btnMemPlus.Enabled = true;
            }
        }

        private void operationsPress(string op)
        {
            //Gets value from calculator output display, assigns operation as +, then displays to showOps label
            //Allows addition of multiple values in succession
            if (divideZero.Visible == true)
            {
                operations.operation = "";
            }

            else if (operations.result != 0)
            {
                operations.enterNewValue = true;
                equalsBtn.PerformClick();
                operations.operation = op;
                showOps.Text = $"{operations.result} {operations.operation}";
                num1 = showOps.Text;
            }

            else if (calcuOutput.Text == null || calcuOutput.Text == string.Empty)
            {
                //Prevents System.FormatException; second number is null/empty
                enterNewValue = true;
                return;
            }

            else
            {
                //Gets value from calculator output display, assigns operation as +, then displays to showOps label
                enterNewValue = true;
                operations.result = float.Parse(calcuOutput.Text);
                operations.operation = op;
                showOps.Text = $"{operations.result} {operations.operation}";
                num1 = showOps.Text;
            }
        }

        private void operations2Press(string op)
        {
            //Gets the value of the number, assigns the operation, then displays to showOps label and calculator output text
            float num = float.Parse(calcuOutput.Text);
            operations.operation2 = op;

            if (operations.operation2 == "√")
            {
                //If user clicks any of the operators (+, -, x, ÷) beforehand, will display the first number, operator used, and the second number to the showOps label
                if (operations.operation == "x")
                {
                    calcuOutput.Text = (Math.Sqrt(num)).ToString();
                    showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                    num1 = showOps.Text;
                }

                else if (operations.operation == "+")
                {
                    calcuOutput.Text = (Math.Sqrt(num)).ToString();
                    showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                    num1 = showOps.Text;
                }

                else if (operations.operation == "-")
                {
                    calcuOutput.Text = (Math.Sqrt(num)).ToString();
                    showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                    num1 = showOps.Text;
                }

                else if (operations.operation == "÷")
                {
                    calcuOutput.Text = (Math.Sqrt(num)).ToString();
                    showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                    num1 = showOps.Text;
                }

                else if (operations.operation == string.Empty)
                {
                    showOps.Text = $" {operations.operation2}{num}";                          //Displays the operation
                    calcuOutput.Text = (Math.Sqrt(num)).ToString();                 //Displays result directly to calcu output text when sqrt button is clicked
                    num1 = showOps.Text;
                }
            }

            else if (operations.operation2 == "sqr")
            {
                //If user clicks any of the operators (+, -, x, ÷) beforehand, will display the first number, operator used, and the second number to the showOps label
                //If the modulus of 1 of variable num is greater than 0, displays 2 decimal points (in short, checks if variable num is a decimal)
                if (num % 1 > 0)
                {
                    if (operations.operation == "x")
                    {
                        calcuOutput.Text = string.Format("{0:N}", (Math.Pow(num, 2)));
                        showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                        num1 = showOps.Text;
                    }

                    else if (operations.operation == "+")
                    {
                        calcuOutput.Text = string.Format("{0:N}", (Math.Pow(num, 2)));
                        showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                        num1 = showOps.Text;
                    }

                    else if (operations.operation == "-")
                    {
                        calcuOutput.Text = string.Format("{0:N}", (Math.Pow(num, 2)));
                        showOps.Text = $"{operations.result}   {operations.operation}   {operations.operation2}({num})";
                        num1 = showOps.Text;
                    }

                    else if (operations.operation == "÷")
                    {
                        calcuOutput.Text = string.Format("{0:N}", (Math.Pow(num, 2)));
                        showOps.Text = $"{operations.result}   {operations.operation}   {operations.operation2}({num})";
                        num1 = showOps.Text;
                    }

                    else if (operations.operation == string.Empty)
                    {
                        showOps.Text = $" {operations.operation2}({num})";
                        calcuOutput.Text = string.Format("{0:N}", (Math.Pow(num, 2)));
                        num1 = showOps.Text;
                    }
                }

                //Else, adds thousands separator
                else
                {
                    if (operations.operation == "x")
                    {
                        calcuOutput.Text = string.Format("{0:N0}", (Math.Pow(num, 2)));
                        showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                        num1 = showOps.Text;
                    }

                    else if (operations.operation == "+")
                    {
                        calcuOutput.Text = string.Format("{0:N0}", (Math.Pow(num, 2)));
                        showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                        num1 = showOps.Text;
                    }

                    else if (operations.operation == "-")
                    {
                        calcuOutput.Text = string.Format("{0:N0}", (Math.Pow(num, 2)));
                        showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                        num1 = showOps.Text;
                    }

                    else if (operations.operation == "÷")
                    {
                        calcuOutput.Text = string.Format("{0:N0}", (Math.Pow(num, 2)));
                        showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                        num1 = showOps.Text;
                    }

                    else if (operations.operation == string.Empty)
                    {
                        calcuOutput.Text = string.Format("{0:N0}", (Math.Pow(num, 2)));
                        showOps.Text = $" {operations.operation2}({num})";
                        num1 = showOps.Text;
                    }
                }
            }

            else if (operations.operation2 == "1/")
            {
                //If user clicks any of the operators (+, -, x, ÷) beforehand, will display the first number, operator used, and the second number to the showOps label
                if (operations.operation == string.Empty && num == 0)
                {
                    showOps.Text = $"{operations.operation2}({num})";
                    divideZero.Visible = true;

                    sqrtBtn.Enabled = false;
                    sqrBtn.Enabled = false;
                    percentBtn.Enabled = false;
                    fractBtn.Enabled = false;
                    plusBtn.Enabled = false;
                    minusBtn.Enabled = false;
                    multBtn.Enabled = false;
                    divideBtn.Enabled = false;
                    decBtn.Enabled = false;
                    plusMinusBtn.Enabled = false;

                    btnMemSave.Enabled = false;
                    btnMemMinus.Enabled = false;
                    btnMemPlus.Enabled = false;
                }

                else if (operations.operation == "x")
                {
                    calcuOutput.Text = (1 / num).ToString();
                    showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                    num1 = showOps.Text;
                }

                else if (operations.operation == "+")
                {
                    calcuOutput.Text = (1 / num).ToString();
                    showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                    num1 = showOps.Text;
                }

                else if (operations.operation == "-")
                {
                    calcuOutput.Text = (1 / num).ToString();
                    showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                    num1 = showOps.Text;
                }

                else if (operations.operation == "÷")
                {
                    calcuOutput.Text = (1 / num).ToString();
                    showOps.Text = $"{operations.result} {operations.operation} {operations.operation2}({num})";
                    num1 = showOps.Text;
                }

                else if (operations.operation == string.Empty)
                {
                    showOps.Text = $" {operations.operation2}({num})";
                    calcuOutput.Text = (1 / num).ToString();
                    num1 = showOps.Text;
                }


            }

            else if (operations.operation2 == "%")
            {
                //If user clicks any of the operators (+, -, x, ÷) beforehand, will multiply the first number to (second number/100), then assigns the new value as the 2nd number
                if (operations.operation == "x")
                {
                    calcuOutput.Text = (num / 100).ToString();
                    showOps.Text = $"{operations.result} {operations.operation} {calcuOutput.Text}";
                    num1 = showOps.Text;
                }

                else if (operations.operation == "+")
                {
                    calcuOutput.Text = (operations.result * (num / 100)).ToString();
                    showOps.Text = $"{operations.result} {operations.operation} {calcuOutput.Text}";
                    num1 = showOps.Text;
                }

                else if (operations.operation == "-")
                {
                    calcuOutput.Text = (operations.result * (num / 100)).ToString();
                    showOps.Text = $"{operations.result} {operations.operation} {calcuOutput.Text}";
                    num1 = showOps.Text;
                }
                else if (operations.operation == "÷")
                {
                    calcuOutput.Text = (operations.result * (num / 100)).ToString();
                    showOps.Text = $"{operations.result} {operations.operation} {calcuOutput.Text}";
                    num1 = showOps.Text;
                }

                else if (operations.operation == string.Empty)
                {
                    calcuOutput.Text = "0";
                    showOps.Text = "0";
                    num1 = showOps.Text;
                }
            }

            else if (calcuOutput.Text == null || calcuOutput.Text == string.Empty)
            {
                //Prevents System.FormatException; second number is null/empty
                return;
            }
        }

        private void decimalChecker()
        {
            float num = float.Parse(calcuOutput.Text);

            //Checks if the output text contains a decimal, if it does, appends the decimal according to the string format specifier {0:N}
            //e.g. output text length (with decimal point) is 5, subtract to index of "." then subtract the current value to 1 again, then insert into {0:N(insert value here)} format specifier

            int dotPos = 0;                                                                //Variable for the decimal position, initialized to 0

            if (calcuOutput.Text.Contains("."))
            {
                dotPos = calcuOutput.Text.Length - calcuOutput.Text.IndexOf(".");         //Subtracts the text length of the output to the first position of the decimal

                if (dotPos == 1)                                                          //Checks if, after subtraction from text length of output, dotPos is equal to 1
                {                                                                         //This prevents dotPos from returning 0 which will affect the string format specifier
                    return;
                }

                string formatDec = "{0:N" + (dotPos - 1) + "}";                           //{0:N0} = no decimal after number N, dotPos increments by 1 as long as text length increases
                calcuOutput.Text = string.Format(formatDec, num);


            }

            //Otherwise, proceeds to thousands separator-formatted number
            else
            {
                calcuOutput.Text = string.Format("{0:N0}", num);
            }
        }

        //---------------------------End of Button-press methods---------------------------



        //---------------------------------Main functions---------------------------------
        private void oneNumBtn_Click(object sender, EventArgs e)
        {
            numberButtonPress(oneNumBtn.Text);
            decimalChecker();
        }

        private void twoNumBtn_Click(object sender, EventArgs e)
        {
            numberButtonPress(twoNumBtn.Text);
            decimalChecker();
        }

        private void threeNumBtn_Click(object sender, EventArgs e)
        {
            numberButtonPress(threeNumBtn.Text);
            decimalChecker();
        }

        private void fourNumBtn_Click(object sender, EventArgs e)
        {
            numberButtonPress(fourNumBtn.Text);
            decimalChecker();
        }

        private void fiveNumBtn_Click(object sender, EventArgs e)
        {
            numberButtonPress(fiveNumBtn.Text);
            decimalChecker();
        }

        private void sixNumBtn_Click(object sender, EventArgs e)
        {
            numberButtonPress(sixNumBtn.Text);
            decimalChecker();
        }

        private void sevenNumBtn_Click(object sender, EventArgs e)
        {
            numberButtonPress(sevenNumBtn.Text);
            decimalChecker();
        }

        private void eightNumBtn_Click(object sender, EventArgs e)
        {
            numberButtonPress(eightNumBtn.Text);
            decimalChecker();
        }

        private void nineNumBtn_Click(object sender, EventArgs e)
        {
            numberButtonPress(nineNumBtn.Text);
            decimalChecker();
        }
        private void zeroNumBtn_Click(object sender, EventArgs e)
        {
            numberButtonPress(zeroNumBtn.Text);
            decimalChecker();
        }

        private void clrAllBtn_Click(object sender, EventArgs e)
        {
            //Clears the value of all variables. Also clears the output on the calculator.
            operations.operation = "";
            operations.result = 0;
            calcuOutput.Text = "0";
            showOps.Text = "";
            divideZero.Visible = false;

            sqrtBtn.Enabled = true;
            sqrBtn.Enabled = true;
            percentBtn.Enabled = true;
            fractBtn.Enabled = true;
            plusBtn.Enabled = true;
            minusBtn.Enabled = true;
            multBtn.Enabled = true;
            divideBtn.Enabled = true;
            decBtn.Enabled = true;
            plusMinusBtn.Enabled = true;

            btnMemSave.Enabled = true;
            btnMemMinus.Enabled = true;
            btnMemPlus.Enabled = true;
        }

        private void clrRecentBtn_Click(object sender, EventArgs e)
        {
            //Clears the value of the recent entry being typed in the calculator.
            calcuOutput.Text = "0";
            divideZero.Visible = false;

            sqrtBtn.Enabled = true;
            sqrBtn.Enabled = true;
            percentBtn.Enabled = true;
            fractBtn.Enabled = true;
            plusBtn.Enabled = true;
            minusBtn.Enabled = true;
            multBtn.Enabled = true;
            divideBtn.Enabled = true;
            decBtn.Enabled = true;
            plusMinusBtn.Enabled = true;

            btnMemSave.Enabled = true;
            btnMemMinus.Enabled = true;
            btnMemPlus.Enabled = true;
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            operationsPress("+");
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            operationsPress("-");
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            operationsPress("x");
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            operationsPress("÷");
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            operations2Press(sqrtBtn.Text);
        }

        private void sqrBtn_Click(object sender, EventArgs e)
        {
            operations2Press("sqr");
        }

        private void fractBtn_Click(object sender, EventArgs e)
        {
            operations2Press("1/");
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            operations2Press(percentBtn.Text);
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            if (calcuOutput.Text.Contains(".") == false)                    //Checks if there is a decimal point already present, if it is present, does not enter dec. point
            {                                                               //If not present, enters decimal point
                calcuOutput.Text += decBtn.Text;
            }
        }

        private void plusMinusBtn_Click(object sender, EventArgs e)
        {
            if (calcuOutput.Text.StartsWith("-"))                                                           //Checks if output already starts with negative sign (-)
            {
                calcuOutput.Text = calcuOutput.Text.Substring(1);                                           //Strips negative sign (-) to make the number positive
            }
            else if (!string.IsNullOrEmpty(calcuOutput.Text) && calcuOutput.Text != "0")                    //Checks if the string is not null or empty, and if the value
            {                                                                                               //of the output display of the calculator is not equal to 0
                calcuOutput.Text = "-" + calcuOutput.Text;                                                  //Adds negative sign (-) if conditions are met
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (calcuOutput.Text.Length > 0)                                                  //Checks for text length, if greater than 0, removes text by 1 per click
            {
                calcuOutput.Text = calcuOutput.Text.Remove(calcuOutput.Text.Length - 1, 1);
            }

            if (calcuOutput.Text == "")
            {
                calcuOutput.Text = "0";
            }
        }
        private void equalsBtn_Click(object sender, EventArgs e)
        {
            //Method for checking and performing of operations
            operationsChecker();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            //Switches to History tab, makes all Memory-related buttons and displays invisible
            memoryContLabel.Visible = false;
            memoryDisp.Visible = false;
            memActiveColor.Visible = false;

            historyContLabel.Visible = true;
            historyDisp.Visible = true;
            histActiveColor.Visible = true;

            //History delete button enable
            if (historyDisp.Text.Length > 0)
            {
                clearHistory.Visible = true;
            }

            //Memory delete button disable
            if (historyContLabel.Visible == true && historyDisp.Visible == true)
            {
                clearMemory.Visible = false;
            }

            //Memory delete button enable
            else if (memoryDisp.Text.Length > 0)
            {
                clearMemory.Visible = true;
            }

        }

        private void clearHistory_Click(object sender, EventArgs e)
        {
            //If no text is in the history, changes the text to "There's no history yet" and clears the history
            //Hides clear history button after use

            historyDisp.Text = "";
            clearHistory.Visible = false;

            //History label "There's no history yet."
            if (historyContLabel.Text == "")
            {
                historyContLabel.Text = "There's no history yet";
            }
        }

        private void clearMemory_Click(object sender, EventArgs e)
        {
            //If no text is in the memory, changes the text to "There's nothing saved in memory" and clears the memory
            //Hides clear memory button after use
            storedNum = 0;
            memoryDisp.Text = "";
            clearMemory.Visible = false;
            btnMemClear.Enabled = false;
            btnMemRecall.Enabled = false;

            //Memory label "There's nothing saved in memory."
            if (memoryContLabel.Text == "")
            {
                memoryContLabel.Text = "There's nothing saved in memory";
            }
        }

        private void memoryBtn_Click(object sender, EventArgs e)
        {
            //Switches to Memory tab, makes all History-related buttons and displays invisible
            historyContLabel.Visible = false;
            historyDisp.Visible = false;
            histActiveColor.Visible = false;
            clearHistory.Visible = false;

            memoryContLabel.Visible = true;
            memoryDisp.Visible = true;
            memActiveColor.Visible = true;

            //Memory delete button disable
            if (historyContLabel.Visible == true && historyDisp.Visible == true)
            {
                clearMemory.Visible = false;
            }

            //Memory delete button enable
            if (memoryDisp.Text.Length > 0)
            {
                clearMemory.Visible = true;
            }
        }

        private void btnMemSave_Click(object sender, EventArgs e)
        {
            //Memory Save
            storedNum = float.Parse(calcuOutput.Text);
            btnMemClear.Enabled = true;
            btnMemRecall.Enabled = true;

            memoryContLabel.Text = "";

            //Decimal checker for MS button
            if (storedNum % 1 > 0)
            {
                memoryDisp.AppendText($"{string.Format("{0:N}", storedNum)}\n\n");
            }

            else
            {
                memoryDisp.AppendText($"{string.Format("{0:N0}", storedNum)}\n\n");
            }

            if (historyContLabel.Visible == true && historyDisp.Visible == true)
            {
                clearMemory.Visible = false;
            }

            else
            {
                clearMemory.Visible = true;
            }
        }

        private void btnMemMinus_Click(object sender, EventArgs e)
        {
            //Memory Minus
            //Checks for decimal number, if decimal, rounds of to two decimal places & thousands separator
            if ((storedNum % 1) > 0)
            {
                storedNum -= float.Parse(calcuOutput.Text);
                calcuOutput.Text = string.Format("{0:N}", storedNum);
            }

            else
            {
                storedNum -= float.Parse(calcuOutput.Text);
                calcuOutput.Text = string.Format("{0:N0}", storedNum);
            }
        }

        private void btnMemPlus_Click(object sender, EventArgs e)
        {
            //Memory Plus
            //Checks for decimal number, if decimal, rounds of to two decimal places & thousands separator
            if ((storedNum % 1) > 0)
            {
                storedNum += float.Parse(calcuOutput.Text);
                calcuOutput.Text = string.Format("{0:N}", storedNum);
            }
            else
            {
                storedNum += float.Parse(calcuOutput.Text);
                calcuOutput.Text = string.Format("{0:N0}", storedNum);
            }
        }

        private void btnMemRecall_Click(object sender, EventArgs e)
        {
            //Memory Recall
            //Checks for decimal number, if decimal, rounds of to two decimal places & thousands separator
            if ((storedNum % 1) > 0)
            {
                calcuOutput.Text = string.Format("{0:N}", storedNum);
            }
            else
            {
                calcuOutput.Text = string.Format("{0:N0}", storedNum);
            }
        }

        private void btnMemClear_Click(object sender, EventArgs e)
        {
            //Clears Memory value and disables recall and clear buttons
            storedNum = 0;
            btnMemClear.Enabled = false;
            btnMemRecall.Enabled = false;

            memoryDisp.Text = "";
            memoryContLabel.Text = "There's nothing saved in memory";
            clearMemory.Visible = false;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            //On-off switch for the calculator mode button
            if (calcuModePress)
            {
                calcuMenu.Visible = false;
                calcuModePress = !calcuModePress;
            }

            else
            {
                calcuMenu.Visible = true;
                calcuModePress = !calcuModePress;
            }
        }

        private void calcuMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Menu for Calculator Mode
            //Does not have alternate modes, just replaces text on calculator mode
            if (e.Node.Name == "Node0")
            {
                modeLabel.Text = "Standard";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node2")
            {
                modeLabel.Text = "Scientific";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node4")
            {
                modeLabel.Text = "Graphing";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node6")
            {
                modeLabel.Text = "Programmer";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node8")
            {
                modeLabel.Text = "Date Calculation";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node10")
            {
                modeLabel.Text = "Currency";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node12")
            {
                modeLabel.Text = "Volume";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node14")
            {
                modeLabel.Text = "Length";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node16")
            {
                modeLabel.Text = "Weight and Mass";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node18")
            {
                modeLabel.Text = "Temperature";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node20")
            {
                modeLabel.Text = "Energy";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node22")
            {
                modeLabel.Text = "Area";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node24")
            {
                modeLabel.Text = "Speed";
                calcuMenu.Visible = false;
            }

            else if (e.Node.Name == "Node26")
            {
                modeLabel.Text = "Time";
                calcuMenu.Visible = false;
            }
        }
    }
}
