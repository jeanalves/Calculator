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
    public partial class Calculator : Form
    {

        private double num1;
        private double num2;

        CurrentMath cm = CurrentMath.None;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void CommaButton_Click(object sender, EventArgs e)
        {
            display.Text += ".";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (cm == CurrentMath.None)
            {
                num1 = Convert.ToDouble(display.Text);
                cm = CurrentMath.Plus;
                display.Text += " + ";
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (cm == CurrentMath.None)
            {
                num1 = Convert.ToDouble(display.Text);
                cm = CurrentMath.Minus;
                display.Text += " - ";
            }
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            if (cm == CurrentMath.None)
            {
                num1 = Convert.ToDouble(display.Text);
                cm = CurrentMath.Times;
                display.Text += " x ";
            }
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (cm == CurrentMath.None)
            {
                num1 = Convert.ToDouble(display.Text);
                cm = CurrentMath.Division;
                display.Text += " ÷ ";
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            num1 = 0;
            num2 = 0;
            cm = CurrentMath.None;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            switch (cm)
            {
                case CurrentMath.Plus:
                    num2 = Convert.ToDouble(display.Text.Substring(display.Text.IndexOf("+") + 1));
                    display.Text = (num1 + num2).ToString();
                    break;
                case CurrentMath.Minus:
                    num2 = Convert.ToDouble(display.Text.Substring(display.Text.IndexOf("-") + 1));
                    display.Text = (num1 - num2).ToString();
                    break;
                case CurrentMath.Times:
                    num2 = Convert.ToDouble(display.Text.Substring(display.Text.IndexOf("x") + 1));
                    display.Text = (num1 * num2).ToString();
                    break;
                case CurrentMath.Division:
                    num2 = Convert.ToDouble(display.Text.Substring(display.Text.IndexOf("÷") + 1));
                    display.Text = (num1 / num2).ToString();
                    break;
            }
            cm = CurrentMath.None;
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }
        enum CurrentMath
        {
            Plus,
            Minus,
            Times,
            Division,
            None
        }


    }
}
