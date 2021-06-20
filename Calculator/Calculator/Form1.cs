using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double result = 0;
        double storedNum;
        string operation = "";
        string operation2 = "";
        string num1, num2;
        bool enterNewValue = false;

        public Form1()
        {
            InitializeComponent();
            clearHistory.Visible = false;
            clearMemory.Visible = false;
            btnMemClear.Enabled = false;
            btnMemRecall.Enabled = false;
        }

        private void operationsChecker()
        {
            if (operation != string.Empty)
            {

                try
                {
                    double result2 = double.Parse(calcuOutput.Text);
                    num2 = calcuOutput.Text;

                    //Compares the value stored inside the operation variable to each case, then executes the code contained inside the chosen case.
                    switch (operation)
                    {
                        //Case for the addition operation
                        case "+":
                            if (showOps.Text.Contains("√") || showOps.Text.Contains("sqr") || showOps.Text.Contains("1/("))
                            {

                                calcuOutput.Text = (result + result2).ToString();

                                if (calcuOutput.Text.Contains("."))
                                {
                                    //Decimal format for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N}", num);
                                }

                                else
                                {
                                    //Thousands separator for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N0}", num);
                                }

                                //History display
                                clearHistory.Visible = true;                                    //Makes the button for clearing the history visible
                                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                                historyDisp.AppendText($"{num1} = {calcuOutput.Text}\n\n");     //Appends the text from the showOps label to the history display
                                historyContLabel.Text = "";

                                showOps.Text = $"{num1} =";
                            }
                            else
                            {
                                calcuOutput.Text = (result + result2).ToString();

                                if (calcuOutput.Text.Contains("."))
                                {
                                    //Decimal format for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N}", num);
                                }

                                else
                                {
                                    //Thousands separator for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N0}", num);
                                }

                                //History display
                                clearHistory.Visible = true;
                                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                                historyDisp.AppendText($"{num1} {num2} = ");                    
                                historyDisp.AppendText(calcuOutput.Text + "\n\n");
                                historyContLabel.Text = "";

                                //Operations display
                                showOps.Text = $"{num1} {num2}   =";
                            }

                            if (operation2 == "%")
                            {
                                calcuOutput.Text = (result + result2).ToString();

                                if (calcuOutput.Text.Contains("."))
                                {
                                    //Decimal format for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N}", num);
                                }

                                else
                                {
                                    //Thousands separator for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N0}", num);
                                }

                                //History display
                                clearHistory.Visible = true;
                                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                                historyDisp.AppendText($"{num1} = {calcuOutput.Text}\n\n");
                                historyContLabel.Text = "";

                                showOps.Text = $"{num1} =";
                            }
                            break;

                        //Case for the subtraction operation
                        case "-":
                            if (showOps.Text.Contains("√") || showOps.Text.Contains("sqr") || showOps.Text.Contains("1/("))
                            {

                                calcuOutput.Text = (result - result2).ToString();

                                if (calcuOutput.Text.Contains("."))
                                {
                                    //Decimal format for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N}", num);
                                }

                                else
                                {
                                    //Thousands separator for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N0}", num);
                                }

                                //History display
                                clearHistory.Visible = true;
                                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                                historyDisp.AppendText($"{num1} = {calcuOutput.Text}\n\n");
                                historyContLabel.Text = "";

                                showOps.Text = $"{num1} =";
                            }
                            else
                            {
                                calcuOutput.Text = (result - result2).ToString();

                                if (calcuOutput.Text.Contains("."))
                                {
                                    //Decimal format for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N}", num);
                                }

                                else
                                {
                                    //Thousands separator for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N0}", num);
                                }

                                //History display
                                clearHistory.Visible = true;
                                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                                historyDisp.AppendText($"{num1} {num2} = ");                    
                                historyDisp.AppendText(calcuOutput.Text + "\n\n");
                                historyContLabel.Text = "";

                                //Operations display
                                showOps.Text = $"{num1} {num2}   =";
                            }

                            if (operation2 == "%")
                            {
                                calcuOutput.Text = (result - result2).ToString();

                                if (calcuOutput.Text.Contains("."))
                                {
                                    //Decimal format for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N}", num);
                                }

                                else
                                {
                                    //Thousands separator for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N0}", num);
                                }

                                //History display
                                clearHistory.Visible = true;
                                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                                historyDisp.AppendText($"{num1} = {calcuOutput.Text}\n\n");
                                historyContLabel.Text = "";

                                showOps.Text = $"{num1} =";
                            }
                            break;

                        //Case for the multiplication operation
                        case "x":
                            if (showOps.Text.Contains("√") || showOps.Text.Contains("sqr") || showOps.Text.Contains("1/("))
                            {

                                calcuOutput.Text = (result * result2).ToString();

                                if (calcuOutput.Text.Contains("."))
                                {
                                    //Decimal format for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N}", num);
                                }

                                else
                                {
                                    //Thousands separator for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N0}", num);
                                }

                                //History display
                                clearHistory.Visible = true;
                                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                                historyDisp.AppendText($"{num1} = {calcuOutput.Text}\n\n");
                                historyContLabel.Text = "";

                                showOps.Text = $"{num1} =";
                            }

                            else
                            {
                                calcuOutput.Text = (result * result2).ToString();

                                if (calcuOutput.Text.Contains("."))
                                {
                                    //Decimal format for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N}", num);
                                }

                                else
                                {
                                    //Thousands separator for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N0}", num);
                                }

                                //History display
                                clearHistory.Visible = true;
                                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                                historyDisp.AppendText($"{num1} {num2} = ");      
                                historyDisp.AppendText(calcuOutput.Text + "\n\n");
                                historyContLabel.Text = "";

                                //Operations display
                                showOps.Text = $"{num1} {num2}   =";
                            }

                            if (operation2 == "%")
                            {
                                calcuOutput.Text = (result * result2).ToString();

                                if (calcuOutput.Text.Contains("."))
                                {
                                    //Decimal format for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N}", num);
                                }

                                else
                                {
                                    //Thousands separator for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N0}", num);
                                }

                                //History display
                                clearHistory.Visible = true;
                                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                                historyDisp.AppendText($"{num1} = {calcuOutput.Text}\n\n");
                                historyContLabel.Text = "";

                                showOps.Text = $"{num1} =";
                            }
                            break;

                        //Case for the division operation
                        case "÷":
                            if (showOps.Text.Contains("√") || showOps.Text.Contains("sqr") || showOps.Text.Contains("1/("))
                            {

                                calcuOutput.Text = (result / result2).ToString();

                                if (calcuOutput.Text.Contains("."))
                                {
                                    //Decimal format for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N}", num);
                                }

                                else
                                {
                                    //Thousands separator for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N0}", num);
                                }

                                //History display
                                clearHistory.Visible = true;
                                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                                historyDisp.AppendText($"{num1} = {calcuOutput.Text}\n\n");
                                historyContLabel.Text = "";

                                showOps.Text = $"{num1} =";
                            }

                            else
                            {
                                calcuOutput.Text = (result / result2).ToString();

                                if (calcuOutput.Text.Contains("."))
                                {
                                    //Decimal format for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N}", num);
                                }

                                else
                                {
                                    //Thousands separator for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N0}", num);
                                }

                                //History display
                                clearHistory.Visible = true;
                                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                                historyDisp.AppendText($"{num1} {num2} = ");      
                                historyDisp.AppendText(calcuOutput.Text + "\n\n");
                                historyContLabel.Text = "";

                                //Operations display
                                showOps.Text = $"{num1} {num2}   =";
                            }
                            if (operation2 == "%")
                            {
                                calcuOutput.Text = (result / result2).ToString();

                                if (calcuOutput.Text.Contains("."))
                                {
                                    //Decimal format for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N}", num);
                                }

                                else
                                {
                                    //Thousands separator for the result
                                    double num = double.Parse(calcuOutput.Text);
                                    calcuOutput.Text = string.Format("{0:N0}", num);
                                }

                                //History display
                                clearHistory.Visible = true;
                                historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                                historyDisp.AppendText($"{num1} = {calcuOutput.Text}\n\n");
                                historyContLabel.Text = "";

                                showOps.Text = $"{num1} =";
                            }
                            break;

                        default:
                            break;

                    }
                    result = double.Parse(calcuOutput.Text);
                    operation = "";


                }
                catch
                {
                    MessageBox.Show("Math Error!");
                    showOps.Text = "";
                    result = 0;
                    operation = "";
                }


            }
            else if (operation2 != string.Empty)
            {
                try
                {
                    //Checks the value of operation2 for operations that are complex
                    switch (operation2)
                    {
                        //Case for square root
                        case "√":

                            //History display
                            clearHistory.Visible = true;                            //Makes the button for clearing the history visible
                            historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                            historyDisp.AppendText(num1 + "   =   ");               //Appends the text from the showOps label to the history display
                            historyDisp.AppendText(calcuOutput.Text + "\n\n");
                            historyContLabel.Text = "";                             //Removes the text "There's no history yet"

                            //Operations display
                            showOps.Text = $"{num1}   =   ";
                            break;

                        //Case for x² 
                        case "sqr":

                            //History display
                            clearHistory.Visible = true;
                            historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                            historyDisp.AppendText(num1 + "   =   ");
                            historyDisp.AppendText(calcuOutput.Text + "\n\n");
                            historyContLabel.Text = "";

                            //Operations display
                            showOps.Text = $"{num1}   =   ";
                            break;

                        //Case for 1/x
                        case "1/":

                            //History display
                            clearHistory.Visible = true;
                            historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                            historyDisp.AppendText(num1 + "   =   ");
                            historyDisp.AppendText(calcuOutput.Text + "\n\n");
                            historyContLabel.Text = "";

                            //Operations display
                            showOps.Text = $"{num1}   =   ";
                            break;

                        //Case for %
                        case "%":
                            //History display
                            clearHistory.Visible = true;
                            historyDisp.SelectionAlignment = HorizontalAlignment.Right;
                            historyDisp.AppendText(num1 + "   =   ");
                            historyDisp.AppendText(calcuOutput.Text + "\n\n");
                            historyContLabel.Text = "";

                            //Operations display
                            showOps.Text = $"{num1}   =   ";
                            break;

                        default:
                            break;
                    }
                    result = double.Parse(calcuOutput.Text);
                    operation2 = "";
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void decimalChecker()
        {
            double num = double.Parse(calcuOutput.Text);

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

        private void oneNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if output text is equal to 0 or if the boolean to enter a new value is true
            //If true, sets the text to the number of the button clicked, else, appends the same number to the existing text
            //Disables enter new value unless an operation is pressed that will enable the function again. (Used for adding multiple numbers in quick succession)
            if (calcuOutput.Text == "0" || enterNewValue == true)
            {
                calcuOutput.Text = oneNumBtn.Text;
                enterNewValue = false;
            }

            else 
            {
                calcuOutput.Text += oneNumBtn.Text;
            }

            decimalChecker();
        }

        private void twoNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if output text is equal to 0 or if the boolean to enter a new value is true
            //If true, sets the text to the number of the button clicked, else, appends the same number to the existing text
            //Disables enter new value unless an operation is pressed that will enable the function again. (Used for adding multiple numbers in quick succession)
            if (calcuOutput.Text == "0" || enterNewValue == true)
            {
                calcuOutput.Text = twoNumBtn.Text;
                enterNewValue = false;
            }

            else
            {
                calcuOutput.Text += twoNumBtn.Text;
            }

            decimalChecker();
        }

        private void threeNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if output text is equal to 0 or if the boolean to enter a new value is true
            //If true, sets the text to the number of the button clicked, else, appends the same number to the existing text
            //Disables enter new value unless an operation is pressed that will enable the function again. (Used for adding multiple numbers in quick succession)
            if (calcuOutput.Text == "0" || enterNewValue == true)
            {
                calcuOutput.Text = threeNumBtn.Text;
                enterNewValue = false;
            }

            else
            {
                calcuOutput.Text += threeNumBtn.Text;
            }

            decimalChecker();
        }

        private void fourNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if output text is equal to 0 or if the boolean to enter a new value is true
            //If true, sets the text to the number of the button clicked, else, appends the same number to the existing text
            //Disables enter new value unless an operation is pressed that will enable the function again. (Used for adding multiple numbers in quick succession)
            if (calcuOutput.Text == "0" || enterNewValue == true)
            {
                calcuOutput.Text = fourNumBtn.Text;
                enterNewValue = false;
            }

            else
            {
                calcuOutput.Text += fourNumBtn.Text;
            }

            decimalChecker();
        }

        private void fiveNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if output text is equal to 0 or if the boolean to enter a new value is true
            //If true, sets the text to the number of the button clicked, else, appends the same number to the existing text
            //Disables enter new value unless an operation is pressed that will enable the function again. (Used for adding multiple numbers in quick succession)
            if (calcuOutput.Text == "0" || enterNewValue == true)
            {
                calcuOutput.Text = fiveNumBtn.Text;
                enterNewValue = false;
            }

            else
            {
                calcuOutput.Text += fiveNumBtn.Text;
            }

            decimalChecker();
        }

        private void sixNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if output text is equal to 0 or if the boolean to enter a new value is true
            //If true, sets the text to the number of the button clicked, else, appends the same number to the existing text
            //Disables enter new value unless an operation is pressed that will enable the function again. (Used for adding multiple numbers in quick succession)
            if (calcuOutput.Text == "0" || enterNewValue == true)
            {
                calcuOutput.Text = sixNumBtn.Text;
                enterNewValue = false;
            }

            else
            {
                calcuOutput.Text += sixNumBtn.Text;
            }

            decimalChecker();
        }

        private void sevenNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if output text is equal to 0 or if the boolean to enter a new value is true
            //If true, sets the text to the number of the button clicked, else, appends the same number to the existing text
            //Disables enter new value unless an operation is pressed that will enable the function again. (Used for adding multiple numbers in quick succession)
            if (calcuOutput.Text == "0" || enterNewValue == true)
            {
                calcuOutput.Text = sevenNumBtn.Text;
                enterNewValue = false;
            }

            else
            {
                calcuOutput.Text += sevenNumBtn.Text;
            }

            decimalChecker();
        }

        private void eightNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if output text is equal to 0 or if the boolean to enter a new value is true
            //If true, sets the text to the number of the button clicked, else, appends the same number to the existing text
            //Disables enter new value unless an operation is pressed that will enable the function again. (Used for adding multiple numbers in quick succession)
            if (calcuOutput.Text == "0" || enterNewValue == true)
            {
                calcuOutput.Text = eightNumBtn.Text;
                enterNewValue = false;
            }

            else
            {
                calcuOutput.Text += eightNumBtn.Text;
            }

            decimalChecker();
        }

        private void nineNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if output text is equal to 0 or if the boolean to enter a new value is true
            //If true, sets the text to the number of the button clicked, else, appends the same number to the existing text
            //Disables enter new value unless an operation is pressed that will enable the function again. (Used for adding multiple numbers in quick succession)
            if (calcuOutput.Text == "0" || enterNewValue == true)
            {
                calcuOutput.Text = nineNumBtn.Text;
                enterNewValue = false;
            }

            else
            {
                calcuOutput.Text += nineNumBtn.Text;
            }

            decimalChecker();
        }
        private void zeroNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if output text is equal to 0 or if the boolean to enter a new value is true
            //If true, sets the text to the number of the button clicked, else, appends the same number to the existing text
            //Disables enter new value unless an operation is pressed that will enable the function again. (Used for adding multiple numbers in quick succession)
            if (calcuOutput.Text == "0" || enterNewValue == true)
            {
                calcuOutput.Text = zeroNumBtn.Text;
                enterNewValue = false;
            }

            else
            {
                calcuOutput.Text += zeroNumBtn.Text;
            }

            decimalChecker();
        }

        private void clrAllBtn_Click(object sender, EventArgs e)
        {
            //Clears the value of all variables. Also clears the output on the calculator.
            operation = "";
            result = 0;
            calcuOutput.Text = "0";
            showOps.Text = "";
        }

        private void clrRecentBtn_Click(object sender, EventArgs e)
        {
            //Clears the value of the recent entry being typed in the calculator.
            calcuOutput.Text = "0";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as +, then displays to showOps label
            //Allows addition of multiple values in succession
            if (result != 0)
            {
                enterNewValue = true;
                equalsBtn.PerformClick();
                operation = "+";
                showOps.Text = $"{result} {operation}";
                num1 = showOps.Text;
            }

            else
            {
                //Gets value from calculator output display, assigns operation as +, then displays to showOps label
                result = double.Parse(calcuOutput.Text);
                operation = "+";
                calcuOutput.Text = "";
                showOps.Text = $"{result} {operation}";
                num1 = showOps.Text;
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as -, then displays to showOps label
            //Allows subtraction of multiple values in succession
            if (result != 0)
            {
                enterNewValue = true;
                equalsBtn.PerformClick();
                operation = "-";
                showOps.Text = $"{result} {operation}";
                num1 = showOps.Text;
            }

            else
            {
                result = double.Parse(calcuOutput.Text);
                operation = "-";
                calcuOutput.Text = "";
                showOps.Text = $"{result} {operation}";
                num1 = showOps.Text;
            }
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as x, then displays to showOps label
            //Allows multiplication of multiple values in succession
            if (result != 0)
            {
                enterNewValue = true;
                equalsBtn.PerformClick();
                operation = "x";
                showOps.Text = $"{result} {operation}";
                num1 = showOps.Text;
            }

            else
            {
                result = double.Parse(calcuOutput.Text);
                operation = "x";
                calcuOutput.Text = "";
                showOps.Text = $"{result} {operation}";
                num1 = showOps.Text;
            }
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as ÷, then displays to showOps label
            //Allows division of multiple values in succession
            if (result != 0)
            {
                enterNewValue = true;
                equalsBtn.PerformClick();
                operation = "÷";
                showOps.Text = $"{result} {operation}";
                num1 = showOps.Text;
            }

            else
            {
                result = double.Parse(calcuOutput.Text);
                operation = "÷";
                calcuOutput.Text = "";
                showOps.Text = $"{result} {operation}";
                num1 = showOps.Text;
            }
        }
        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as √, then displays to showOps label and calculator output text;
            double sqrtNum = double.Parse(calcuOutput.Text);
            operation2 = "√";
        
            showOps.Text += $" {operation2}{sqrtNum}";                          //Displays the operation
            calcuOutput.Text = (Math.Sqrt(sqrtNum)).ToString();                 //Displays result directly to calcu output text when sqrt button is clicked
            num1 = showOps.Text;
        }

        private void sqrBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as n², then displays to showOps label and calculator output text
            double sqrNum = double.Parse(calcuOutput.Text);
            operation2 = "sqr";

            showOps.Text += $" {operation2}({sqrNum})";
            calcuOutput.Text = (Math.Pow(sqrNum, 2)).ToString();
            num1 = showOps.Text;
        }

        private void fractBtn_Click(object sender, EventArgs e)
        {
            //Performs operation 1/(x), then shows the output on the calculator display
            double fractNum = double.Parse(calcuOutput.Text);
            operation2 = "1/";

            showOps.Text += $" {operation2}({fractNum})";
            calcuOutput.Text = (1 / fractNum).ToString();
            num1 = showOps.Text;
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as n/100, then displays to showOps label and calculator output text
            double percentNum = double.Parse(calcuOutput.Text);
            operation2 = "%";

            calcuOutput.Text = (percentNum / 100).ToString();
            showOps.Text += $" {calcuOutput.Text}";
            num1 = showOps.Text;
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            if (calcuOutput.Text.Contains(".") == false)                    //Checks if there is a decimal point already present, if it is present, does not enter dec. point
            {                                                               //If not present, enters decimal point
                calcuOutput.Text += decBtn.Text;
            }

            else
            {
                return;
            }
        }

        private void plusMinusBtn_Click(object sender, EventArgs e)
        {
            if (calcuOutput.Text.StartsWith("-"))                                                           //Checks if output already starts with negative sign (-)
            {
                calcuOutput.Text = calcuOutput.Text.Substring(1);                                           //Strips negative sign (-) to make the number positive
            }
            else if (!string.IsNullOrEmpty(calcuOutput.Text) && decimal.Parse(calcuOutput.Text) != 0)       //Checks if the string is not null or empty, and if the decimal value
            {                                                                                               //of the output display of the calculator is not equal to 0
                calcuOutput.Text = "-" + calcuOutput.Text;                                                  //Adds negative sign (-) if conditions are met
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (calcuOutput.Text.Length > 0)                                                  //Checks for text length, if greater than 0, removes text by 1 per click
            {
                calcuOutput.Text = calcuOutput.Text.Remove(calcuOutput.Text.Length -1, 1);
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
            memoryContLabel.Visible = false;
            memoryDisp.Visible = false;

            historyContLabel.Visible = true;
            historyDisp.Visible = true;

            if (historyDisp.Text.Length > 0)
            {
                clearHistory.Visible = true;
            }

            if (historyContLabel.Visible == true && historyDisp.Visible == true)
            {
                clearMemory.Visible = false;
            }

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
            if (historyContLabel.Text == "")
            {
                historyContLabel.Text = "There's no history yet";
            }
        }

        private void clearMemory_Click(object sender, EventArgs e)
        {
            //If no text is in the memory, changes the text to "There's nothing saved in memory" and clears the memory
            storedNum = 0;
            memoryDisp.Text = "";
            clearMemory.Visible = false;
            btnMemClear.Enabled = false;
            btnMemRecall.Enabled = false;

            if (memoryContLabel.Text == "")
            {
                memoryContLabel.Text = "There's nothing saved in memory";
            }
        }

        private void memoryBtn_Click(object sender, EventArgs e)
        {
            historyContLabel.Visible = false;
            historyDisp.Visible = false;
            clearHistory.Visible = false;

            memoryContLabel.Visible = true;
            memoryDisp.Visible = true;

            if (historyContLabel.Visible == true && historyDisp.Visible == true)
            {
                clearMemory.Visible = false;
            }

            if (memoryDisp.Text.Length > 0)
            {
                clearMemory.Visible = true;
            }
        }

        private void btnMemSave_Click(object sender, EventArgs e)
        {
            //Memory Save
            storedNum = double.Parse(calcuOutput.Text);
            btnMemClear.Enabled = true;
            btnMemRecall.Enabled = true;

            memoryContLabel.Text = "";
            if (storedNum % 1 > 0)
            {
                memoryDisp.AppendText($"{string.Format("{0:N}", storedNum)}\n\n");
            }
            else
            {
                memoryDisp.AppendText($"{string.Format("{0:N0}", storedNum)}\n\n");
            }

            if (historyContLabel.Visible == true  && historyDisp.Visible == true)
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
                storedNum -= double.Parse(calcuOutput.Text);
                calcuOutput.Text = string.Format("{0:N}", storedNum);
            }
            else
            {
                storedNum -= double.Parse(calcuOutput.Text);
                calcuOutput.Text = string.Format("{0:N0}", storedNum);
            }
        }

        private void btnMemPlus_Click(object sender, EventArgs e)
        {
            //Memory Plus
            //Checks for decimal number, if decimal, rounds of to two decimal places & thousands separator
            if ((storedNum % 1) > 0)
            {
                storedNum += double.Parse(calcuOutput.Text);
                calcuOutput.Text = string.Format("{0:N}", storedNum);
            }
            else
            {
                storedNum += double.Parse(calcuOutput.Text);
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
            calcuMenu.Visible = true;
        }

        private void calcuMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
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
