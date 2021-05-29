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

        public Form1()
        {
            InitializeComponent();
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
            //Clears the value of all variables, therefore there is nothing to parse or convert to the double n1, n2, and result. Also clears the output on the calculator.
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
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as -, then displays to showOps label
            result = double.Parse(calcuOutput.Text);
            operation = "-";
            calcuOutput.Text = "";
            showOps.Text = $"{result} {operation}";
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as x, then displays to showOps label
            result = double.Parse(calcuOutput.Text);
            operation = "x";
            calcuOutput.Text = "";
            showOps.Text = $"{result} {operation}";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as ÷, then displays to showOps label
            result = double.Parse(calcuOutput.Text);
            operation = "÷";
            calcuOutput.Text = "";
            showOps.Text = $"{result} {operation}";
        }
        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            //Gets value from calculator output display, assigns operation as √, then displays to showOps label and calculator output text
            result = double.Parse(calcuOutput.Text) ;
            operation = "√";
        
            showOps.Text = $"{operation}{result}";                          //Displays the operation
            calcuOutput.Text = (Math.Sqrt(result)).ToString();
            
            
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            if (calcuOutput.Text.Contains(".") == false)                    //Checks if there is a decimal point already present, if it is present, does not enter dec. point
            {                                                               //If not present, enters decimal point
                calcuOutput.Text += decBtn.Text;
            }
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            if (operation != string.Empty)
            {

                try
                {
                    showOps.Text = "";
                    //Compares the value stored inside the "fn" (short for function) variable to each case, then executes the code contained inside the chosen case.
                    switch (operation)
                    {
                        //Case for the addition operation
                        case "+":
                            calcuOutput.Text = (result + double.Parse(calcuOutput.Text)).ToString();
                            break;

                        //Case for the subtraction operation
                        case "-":
                            calcuOutput.Text = (result - double.Parse(calcuOutput.Text)).ToString();
                            break;
                        
                        //Case for the multiplication operation
                        case "x":
                            calcuOutput.Text = (result * double.Parse(calcuOutput.Text)).ToString();
                            break;
                        
                        //Case for the division operation
                        case "÷":
                            calcuOutput.Text = (result / double.Parse(calcuOutput.Text)).ToString();
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
