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

        //Variable that stores the current number being entered
        string input = "0";

        //Variable that stores the first number 
        string num1 = "0";

        //Variable that stores the second number
        string num2 = "0";

        //Variable that stores the operations
        string fn = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }


        private void oneNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if the input is not equal to zero. If it is not equal to zero, adds the same number next to the entered number. Otherwise, the input will only be equal to the number.
            if (input != "0")
            {
                input = input + "1"; //can be input += "1";
            }
            else
            {
                input = "1";
            }

            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += input;
            
            
        }

        private void twoNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if the input is not equal to zero. If it is not equal to zero, adds the same number next to the entered number. Otherwise, the input will only be equal to the number.
            if (input != "0")
            {
                input = input + "2"; // can be input += "2";
            }
            else
            {
                input = "2";
            }
            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += input;
        }

        private void threeNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if the input is not equal to zero. If it is not equal to zero, adds the same number next to the entered number. Otherwise, the input will only be equal to the number.
            if (input != "0")
            {
                input = input + "3";
            }
            else
            {
                input = "3";
            }
            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += input;
        }

        private void fourNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if the input is not equal to zero. If it is not equal to zero, adds the same number next to the entered number. Otherwise, the input will only be equal to the number.
            if (input != "0")
            {
                input = input + "4";
            }
            else
            {
                input = "4";
            }
            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += input;
        }

        private void fiveNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if the input is not equal to zero. If it is not equal to zero, adds the same number next to the entered number. Otherwise, the input will only be equal to the number.
            if (input != "0")
            {
                input = input + "5";
            }
            else
            {
                input = "5";
            }
            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += input;
        }

        private void sixNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if the input is not equal to zero. If it is not equal to zero, adds the same number next to the entered number. Otherwise, the input will only be equal to the number.
            if (input != "0")
            {
                input = input + "6";
            }
            else
            {
                input = "6";
            }
            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += input;
        }

        private void sevenNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if the input is not equal to zero. If it is not equal to zero, adds the same number next to the entered number. Otherwise, the input will only be equal to the number.
            if (input != "0")
            {
                input = input + "7";
            }
            else
            {
                input = "7";
            }
            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += input;
        }

        private void eightNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if the input is not equal to zero. If it is not equal to zero, adds the same number next to the entered number. Otherwise, the input will only be equal to the number.
            if (input != "0")
            {
                input = input + "8";
            }
            else
            {
                input = "8";
            }
            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += input;
        }

        private void nineNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if the input is not equal to zero. If it is not equal to zero, adds the same number next to the entered number. Otherwise, the input will only be equal to the number.
            if (input != "0")
            {
                input = input + "9";
            }
            else
            {
                input = "9";
            }
            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += input;
        }
        private void zeroNumBtn_Click(object sender, EventArgs e)
        {
            //Checks if the input is not equal to zero. If it is not equal to zero, adds the same number next to the entered number. Otherwise, the input will only be equal to the number.
            if (input != "0")
            {
                input = input + "0";
            }
            else
            {
                input = "0";
            }
            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += input;
        }

        private void clrAllBtn_Click(object sender, EventArgs e)
        {
            //Clears the value of all variables, therefore there is nothing to parse or convert to the double n1, n2, and result. Also clears the output on the calculator.
            input = "";
            num1 = "";
            num2 = "";
            fn = "";
            this.calcuOutput.Text = "0";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            num1 = input;
            input = "0";
            this.calcuOutput.Text = num1 + "+";
            fn = "+";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            num1 = input;
            input = "0";
            this.calcuOutput.Text = num1 + "-";
            fn = "-";
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            num1 = input;
            input = "0";
            this.calcuOutput.Text = num1 + "x";
            fn = "*";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            num1 = input;
            input = "0";
            this.calcuOutput.Text = num1 + "÷";
            fn = "/";
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            num2 = input;
            if (fn != string.Empty)
            {
                double n1, n2, result;

                try
                {
                    double.TryParse(num1, out n1);
                    double.TryParse(num2, out n2);

                    switch (fn)
                    {
                        case "+":
                            this.calcuOutput.Text = "+";
                            result = n1 + n2;
                            this.calcuOutput.Text = result.ToString();
                            break;

                        case "-":
                            this.calcuOutput.Text = "-";
                            result = n1 - n2;
                            this.calcuOutput.Text = result.ToString();
                            break;

                        case "*":
                            this.calcuOutput.Text = "x";
                            result = n1 * n2;
                            this.calcuOutput.Text = result.ToString();
                            break;

                        case "/":
                            this.calcuOutput.Text = "÷";
                            result = n1 / n2;
                            this.calcuOutput.Text = result.ToString();
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Math Error!");
                    input = "";
                    num1 = "";
                    num2 = "";
                    fn = "";
                }
            }
        }
    }
}
