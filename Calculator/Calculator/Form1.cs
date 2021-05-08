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
        public Form1()
        {
            InitializeComponent();
        }

        private void oneNumBtn_Click(object sender, EventArgs e)
        {
            calcuOutput.Text = calcuOutput.Text + "1";
        }

        private void twoNumBtn_Click(object sender, EventArgs e)
        {
            calcuOutput.Text = calcuOutput.Text + "2";
        }

        private void threeNumBtn_Click(object sender, EventArgs e)
        {
            calcuOutput.Text = calcuOutput.Text + "3";
        }

        private void fourNumBtn_Click(object sender, EventArgs e)
        {
            calcuOutput.Text = calcuOutput.Text + "4";
        }

        private void fiveNumBtn_Click(object sender, EventArgs e)
        {
            calcuOutput.Text = calcuOutput.Text + "5";
        }

        private void sixNumBtn_Click(object sender, EventArgs e)
        {
            calcuOutput.Text = calcuOutput.Text + "6";
        }

        private void sevenNumBtn_Click(object sender, EventArgs e)
        {
            calcuOutput.Text = calcuOutput.Text + "7";
        }

        private void eightNumBtn_Click(object sender, EventArgs e)
        {
            calcuOutput.Text = calcuOutput.Text + "8";
        }

        private void nineNumBtn_Click(object sender, EventArgs e)
        {
            calcuOutput.Text = calcuOutput.Text + "9";
        }

        private void clrAllBtn_Click(object sender, EventArgs e)
        {
            calcuOutput.Text = "0";
        }
    }
}
