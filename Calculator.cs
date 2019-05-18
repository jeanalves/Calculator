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

        private double num1 = 0;
        private double num2 = 0;

        CurrentMath cm = CurrentMath.None;

        private bool dotUse = false;

        public Calculator()
        {
            InitializeComponent();
            this.KeyPreview = true;
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
            if (dotUse == false && display.Text != "")
            { 
                display.Text += ".";
                dotUse = true;
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (cm == CurrentMath.None)
            {
                num1 = Convert.ToDouble(display.Text);
                cm = CurrentMath.Plus;
                display.Text += " + ";
                dotUse = false;
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (cm == CurrentMath.None)
            {
                num1 = Convert.ToDouble(display.Text);
                cm = CurrentMath.Minus;
                display.Text += " - ";
                dotUse = false;
            }
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            if (cm == CurrentMath.None)
            {
                num1 = Convert.ToDouble(display.Text);
                cm = CurrentMath.Times;
                display.Text += " x ";
                dotUse = false;
            }
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (cm == CurrentMath.None)
            {
                num1 = Convert.ToDouble(display.Text);
                cm = CurrentMath.Division;
                display.Text += " ÷ ";
                dotUse = false;
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            num1 = 0;
            num2 = 0;
            cm = CurrentMath.None;
            dotUse = false;
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
            dotUse = false;
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

        private void KeyDetection(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            { 
                //Button functions
                case Keys.Delete:
                    cleanButton.PerformClick();
                    break;
                case Keys.Enter:
                    equalButton.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                //Numbers
                case '0':
                    zeroButton.PerformClick();
                    break;
                case '1':
                    oneButton.PerformClick();
                    break;
                case '2':
                    twoButton.PerformClick();
                    break;
                case '3':
                    threeButton.PerformClick();
                    break;
                case '4':
                    fourButton.PerformClick();
                    break;
                case '5':
                    fiveButton.PerformClick();
                    break;
                case '6':
                    sixButton.PerformClick();
                    break;
                case '7':
                    sevenButton.PerformClick();
                    break;
                case '8':
                    eightButton.PerformClick();
                    break;
                case '9':
                    nineButton.PerformClick();
                    break;
                case '.':
                    commaButton.PerformClick();
                    break;

                //Math simbols
                case '+':
                    plusButton.PerformClick();
                    break;
                case '-':
                    minusButton.PerformClick();
                    break;
                case '*':
                    timesButton.PerformClick();
                    break;
                case '/':
                    divisionButton.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
