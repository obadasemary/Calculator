using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class App : Form
    {
        double number1, number2, result;
        char op;
        public App()
        {
            InitializeComponent();
        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult RES = MessageBox.Show("Do You Want To Close ? ", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (RES == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "1";
        }

        private void txtCalc2_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "2";
        }

        private void txtCalc3_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "3";
        }

        private void txtCalc4_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "4";
        }

        private void txtCalc5_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "5";
        }

        private void txtCalc6_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "6";
        }

        private void txtCalc7_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "7";
        }

        private void txtCalc8_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "8";
        }

        private void txtCalc9_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "9";
        }

        private void txtCalc0_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "0";
        }

        private void txtCalcDot_Click(object sender, EventArgs e)
        {
            txtCalc.Text += ".";
        }

        private void txtCalcClear_Click(object sender, EventArgs e)
        {
            txtCalc.Clear();
        }

        private void txtCalcPlus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtCalc.Text);
            op = '+';
            txtCalc.Clear();
            txtCalc.Focus();
        }

        private void txtCalcMuns_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtCalc.Text);
            op = '-';
            txtCalc.Clear();
            txtCalc.Focus();
        }

        private void txtCalcIn_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtCalc.Text);
            op = '*';
            txtCalc.Clear();
            txtCalc.Focus();
        }

        private void txtCalcDev_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtCalc.Text);
            op = '/';
            txtCalc.Clear();
            txtCalc.Focus();
        }

        private void txtCalcEqual_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(txtCalc.Text);
            switch (op)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
            }
            txtCalc.Text = result.ToString();
        }
    }
}
