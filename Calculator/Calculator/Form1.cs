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
            //Stores the input number in the one button to result as a double
            result = double.Parse(oneNumBtn.Text);

            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += result;
            
            
        }

        private void twoNumBtn_Click(object sender, EventArgs e)
        {
            //Stores the input number in the two button to result as a double
            result = double.Parse(twoNumBtn.Text);

            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += result;
        }

        private void threeNumBtn_Click(object sender, EventArgs e)
        {
            //Stores the input number in the three button to result as a double
            result = double.Parse(threeNumBtn.Text);

            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += result;
        }

        private void fourNumBtn_Click(object sender, EventArgs e)
        {
            //Stores the input number in the four button to result as a double
            result = double.Parse(fourNumBtn.Text);

            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += result;
        }

        private void fiveNumBtn_Click(object sender, EventArgs e)
        {
            //Stores the input number in the five button to result as a double
            result = double.Parse(fiveNumBtn.Text);

            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += result;
        }

        private void sixNumBtn_Click(object sender, EventArgs e)
        {
            //Stores the input number in the six button to result as a double
            result = double.Parse(sixNumBtn.Text);

            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += result;
        }

        private void sevenNumBtn_Click(object sender, EventArgs e)
        {
            //Stores the input number in the seven button to result as a double
            result = double.Parse(sevenNumBtn.Text);

            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += result;
        }

        private void eightNumBtn_Click(object sender, EventArgs e)
        {
            //Stores the input number in the eight button to result as a double
            result = double.Parse(eightNumBtn.Text);

            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += result;
        }

        private void nineNumBtn_Click(object sender, EventArgs e)
        {
            //Stores the input number in the nine button to result as a double
            result = double.Parse(nineNumBtn.Text);
            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += result;
        }
        private void zeroNumBtn_Click(object sender, EventArgs e)
        {
            //Stores the input number in the zero button to result as a double
            result = double.Parse(zeroNumBtn.Text);

            //Clears the text box, then appends the input number.
            this.calcuOutput.Text = "";
            this.calcuOutput.Text += result;
        }

        private void clrAllBtn_Click(object sender, EventArgs e)
        {
            //Clears the value of all variables, therefore there is nothing to parse or convert to the double result. Also clears the output on the calculator.
            result = 0;
            operation = "";
            this.calcuOutput.Text = "0";
            this.showOps.Text = "";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            //Displays number and operation used in the showOps label
            operation = "+";
            this.calcuOutput.Text = "";
            this.showOps.Text = $"{result} {operation}";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            //Displays number and operation used in the showOps label
            operation = "-";
            this.calcuOutput.Text = "";
            this.showOps.Text = $"{result} {operation}";
            
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            //Displays number and operation used in the showOps label
            operation = "x";
            this.calcuOutput.Text = "";
            this.showOps.Text = $"{result} {operation}";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            //Displays number and operation used in the showOps label
            operation = "÷";
            this.calcuOutput.Text = "";
            this.showOps.Text = $"{result} {operation}";
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            if (operation != string.Empty)
            {

                try
                {
                    //Compares the value stored inside the "fn" (short for function) variable to each case, then executes the code contained inside the chosen case.
                    switch (operation)
                    {
                        //Case for the addition operation
                        case "+":
                            result = result + double.Parse(calcuOutput.Text);
                            this.calcuOutput.Text = result.ToString();
                            break;

                        //Case for the subtraction operation
                        case "-":
                            result = result - double.Parse(calcuOutput.Text);
                            this.calcuOutput.Text = result.ToString();
                            break;
                        
                        //Case for the multiplication operation
                        case "x":
                            result = result * double.Parse(calcuOutput.Text);
                            this.calcuOutput.Text = result.ToString();
                            break;
                        
                        //Case for the division operation
                        case "÷":
                            result = result / double.Parse(calcuOutput.Text);
                            this.calcuOutput.Text = result.ToString();
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Math Error!");
                    showOps.Text = "";
                    calcuOutput.Text = "0";
                    result = 0;
                    operation = "";
                }
            }
        }
    }
}
