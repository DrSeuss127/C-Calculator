using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double result = 0;
        string operation = "";
        string num1, num2;

        public Form1()
        {
            InitializeComponent();
            clearHistory.Visible = false;
        }


        private void oneNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if calculator output text is not equal to 0, if != 0, appends the number to existing number. Else, the number replaces 0
            if (calcuOutput.Text != "0")
            {
                calcuOutput.Text += oneNumBtn.Text;
            }

            else
            {
                calcuOutput.Text = oneNumBtn.Text;
            }
        }

        private void twoNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if calculator output text is not equal to 0, if != 0, appends the number to existing number. Else, the number replaces 0
            if (calcuOutput.Text != "0")
            {
                calcuOutput.Text += twoNumBtn.Text;
            }

            else
            {
                calcuOutput.Text = twoNumBtn.Text;
            }
        }

        private void threeNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if calculator output text is not equal to 0, if != 0, appends the number to existing number. Else, the number replaces 0
            if (calcuOutput.Text != "0")
            {
                calcuOutput.Text += threeNumBtn.Text;
            }

            else
            {
                calcuOutput.Text = threeNumBtn.Text;
            }
        }

        private void fourNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if calculator output text is not equal to 0, if != 0, appends the number to existing number. Else, the number replaces 0
            if (calcuOutput.Text != "0")
            {
                calcuOutput.Text += fourNumBtn.Text;
            }

            else
            {
                calcuOutput.Text = fourNumBtn.Text;
            }
        }

        private void fiveNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if calculator output text is not equal to 0, if != 0, appends the number to existing number. Else, the number replaces 0
            if (calcuOutput.Text != "0")
            {
                calcuOutput.Text += fiveNumBtn.Text;
            }

            else
            {
                calcuOutput.Text = fiveNumBtn.Text;
            }
        }

        private void sixNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if calculator output text is not equal to 0, if != 0, appends the number to existing number. Else, the number replaces 0
            if (calcuOutput.Text != "0")
            {
                calcuOutput.Text += sixNumBtn.Text;
            }

            else
            {
                calcuOutput.Text = sixNumBtn.Text;
            }
        }

        private void sevenNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if calculator output text is not equal to 0, if != 0, appends the number to existing number. Else, the number replaces 0
            if (calcuOutput.Text != "0")
            {
                calcuOutput.Text += sevenNumBtn.Text;
            }

            else
            {
                calcuOutput.Text = sevenNumBtn.Text;
            }
        }

        private void eightNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if calculator output text is not equal to 0, if != 0, appends the number to existing number. Else, the number replaces 0
            if (calcuOutput.Text != "0")
            {
                calcuOutput.Text += eightNumBtn.Text;
            }

            else
            {
                calcuOutput.Text = eightNumBtn.Text;
            }
        }

        private void nineNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if calculator output text is not equal to 0, if != 0, appends the number to existing number. Else, the number replaces 0
            if (calcuOutput.Text != "0")
            {
                calcuOutput.Text += nineNumBtn.Text;
            }

            else
            {
                calcuOutput.Text = nineNumBtn.Text;
            }
        }
        private void zeroNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if calculator output text is not equal to 0, if != 0, appends the number to existing number. Else, the number replaces 0
            if (calcuOutput.Text != "0")
            {
                calcuOutput.Text += zeroNumBtn.Text;
            }

            else
            {
                calcuOutput.Text = zeroNumBtn.Text;
            }
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
            //Clears the value of all variables. Also clears the output on the calculator.
            operation = "";
            result = 0;
            calcuOutput.Text = "0";
            showOps.Text = "";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as +, then displays to showOps label
            result = double.Parse(calcuOutput.Text);
            operation = "+";
            calcuOutput.Text = "";
            showOps.Text = $"{result} {operation}";
            num1 = showOps.Text;
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as -, then displays to showOps label
            result = double.Parse(calcuOutput.Text);
            operation = "-";
            calcuOutput.Text = "";
            showOps.Text = $"{result} {operation}";
            num1 = showOps.Text;
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as x, then displays to showOps label
            result = double.Parse(calcuOutput.Text);
            operation = "x";
            calcuOutput.Text = "";
            showOps.Text = $"{result} {operation}";
            num1 = showOps.Text;
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as ÷, then displays to showOps label
            result = double.Parse(calcuOutput.Text);
            operation = "÷";
            calcuOutput.Text = "";
            showOps.Text = $"{result} {operation}";
            num1 = showOps.Text;
        }
        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as √, then displays to showOps label and calculator output text
            result = double.Parse(calcuOutput.Text);
            operation = "√";
        
            showOps.Text += $" {operation}{result}";                          //Displays the operation
            calcuOutput.Text = (Math.Sqrt(result)).ToString();              //Displays result directly to calcu output text when sqrt button is clicked
            num1 = showOps.Text;
        }

        private void sqrBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as n², then displays to showOps label and calculator output text
            result = double.Parse(calcuOutput.Text);
            operation = "square";

            showOps.Text += $" sqr({result})";
            calcuOutput.Text = (Math.Pow(result, 2)).ToString();
            num1 = showOps.Text;
        }

        private void fractBtn_Click(object sender, EventArgs e)
        {
            //Performs operation 1/(x), then shows the output on the calculator display
            result = double.Parse(calcuOutput.Text);
            operation = "div";

            showOps.Text += $" 1/({result})";
            calcuOutput.Text = (1 / result).ToString();
            num1 = showOps.Text;
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {

            result = double.Parse(calcuOutput.Text);
            operation = "%";

            calcuOutput.Text = (result / 100).ToString();
            showOps.Text += $"{result}";
            num1 = showOps.Text;
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
            else if (!string.IsNullOrEmpty(calcuOutput.Text) && decimal.Parse(calcuOutput.Text) != 0)       //Checks if the string is null or empty, and if the decimal value
            {                                                                                               //of the output is not equal to 0
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

        private void clearHistory_Click(object sender, EventArgs e)
        {
            if (historyContLabel.Text == "")
            {
                historyContLabel.Text = "There's no history yet";
                historyDisp.Text = "";
                clearHistory.Visible = false;
            }
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            if (operation != string.Empty)
            {

                try
                {
                    double result2 = double.Parse(calcuOutput.Text);
                    num2 = calcuOutput.Text;
                    showOps.Text = "";
                    //Compares the value stored inside the "fn" (short for function) variable to each case, then executes the code contained inside the chosen case.
                    switch (operation)
                    {
                        //Case for the addition operation
                        case "+":
                            calcuOutput.Text = (result + result2).ToString();

                            //Memory or history display
                            clearHistory.Visible = true;                            //Makes the button for clearing the history visible
                            historyDisp.AppendText(num1 + " " + num2 + "   =   ");      //Appends the text from the showOps label to the history display
                            historyDisp.AppendText(calcuOutput.Text + "\n\n");
                            historyContLabel.Text = "";                             //Removes the text "There's no history yet"

                            //Operations display
                            showOps.Text = num1 + " " + num2 + "   =   " + calcuOutput.Text;
                            break;

                        //Case for the subtraction operation
                        case "-":
                            calcuOutput.Text = (result - result2).ToString();

                            //Memory or history display
                            clearHistory.Visible = true;                            //Makes the button for clearing the history visible
                            historyDisp.AppendText(num1 + " " + num2 + "   =   ");      //Appends the text from the showOps label to the history display
                            historyDisp.AppendText(calcuOutput.Text + "\n\n");
                            historyContLabel.Text = "";                             //Removes the text "There's no history yet"

                            //Operations display
                            showOps.Text = num1 + " " + num2 + "   =   " + calcuOutput.Text;
                            break;
                        
                        //Case for the multiplication operation
                        case "x":
                            calcuOutput.Text = (result * result2).ToString();

                            //Memory or history display
                            clearHistory.Visible = true;                            //Makes the button for clearing the history visible
                            historyDisp.AppendText(num1 + " " + num2 + "   =   ");      //Appends the text from the showOps label to the history display
                            historyDisp.AppendText(calcuOutput.Text + "\n\n");
                            historyContLabel.Text = "";                             //Removes the text "There's no history yet"

                            //Operations display
                            showOps.Text = num1 + " " + num2 + "   =   " + calcuOutput.Text;
                            break;
                        
                        //Case for the division operation
                        case "÷":
                            calcuOutput.Text = (result / result2).ToString();

                            //Memory or history display
                            clearHistory.Visible = true;                            //Makes the button for clearing the history visible
                            historyDisp.AppendText(num1 + " " + num2 + "   =   ");      //Appends the text from the showOps label to the history display
                            historyDisp.AppendText(calcuOutput.Text + "\n\n");
                            historyContLabel.Text = "";                             //Removes the text "There's no history yet"

                            //Operations display
                            showOps.Text = num1 + " " + num2 + "   =   " + calcuOutput.Text;
                            break;

                        case "square":
                            //Memory or history display
                            clearHistory.Visible = true;                            //Makes the button for clearing the history visible
                            historyDisp.AppendText(num1 + "   =   ");      //Appends the text from the showOps label to the history display
                            historyDisp.AppendText(calcuOutput.Text + "\n\n");
                            historyContLabel.Text = "";                             //Removes the text "There's no history yet"

                            //Operations display
                            showOps.Text = num1 + "   =   " + calcuOutput.Text;
                            break;

                        case "√":
                            //Memory or history display
                            clearHistory.Visible = true;                            //Makes the button for clearing the history visible
                            historyDisp.AppendText(num1 + "   =   ");      //Appends the text from the showOps label to the history display
                            historyDisp.AppendText(calcuOutput.Text + "\n\n");
                            historyContLabel.Text = "";                             //Removes the text "There's no history yet"

                            //Operations display
                            showOps.Text = num1 + "   =   " + calcuOutput.Text;
                            break;

                        case "div":
                            //Memory or history display
                            clearHistory.Visible = true;                            //Makes the button for clearing the history visible
                            historyDisp.AppendText(num1 + "   =   ");      //Appends the text from the showOps label to the history display
                            historyDisp.AppendText(calcuOutput.Text + "\n\n");
                            historyContLabel.Text = "";

                            //Operations display
                            showOps.Text = num1 + "   =   " + calcuOutput.Text;
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
        }
    }
}
