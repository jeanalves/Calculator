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

        private double dNum1 = 0;
        private double dNum2 = 0;
        private string sNum1 = "";
        private string sNum2 = "";

        CurrentMath cm = CurrentMath.None;

        private bool dotUsed = false;

        public Calculator()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            
        }

        #region ButtonClick
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            display.Text += "0";
            setNumbers("0");
            getFocus.Focus();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            display.Text += "1";
            setNumbers("1");
            getFocus.Focus();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            display.Text += "2";
            setNumbers("2");
            getFocus.Focus();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            display.Text += "3";
            setNumbers("3");
            getFocus.Focus();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            display.Text += "4";
            setNumbers("4");
            getFocus.Focus();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            display.Text += "5";
            setNumbers("5");
            getFocus.Focus();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            display.Text += "6";
            setNumbers("6");
            getFocus.Focus();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            display.Text += "7";
            setNumbers("7");
            getFocus.Focus();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            display.Text += "8";
            setNumbers("8");
            getFocus.Focus();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            display.Text += "9";
            setNumbers("9");
            getFocus.Focus();
        }

        private void CommaButton_Click(object sender, EventArgs e)
        {
            if (dotUsed == false && sNum1 != "" && cm == CurrentMath.None)
            {
                display.Text += ".";
                setNumbers(".");
                dotUsed = true;
            }
            else if (dotUsed == false && sNum2 != "")
            {
                display.Text += ".";
                setNumbers(".");
                dotUsed = true;
            }
            getFocus.Focus();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (cm == CurrentMath.None && display.Text != "")
            {
                cm = CurrentMath.Plus;
                display.Text += " + ";
                dotUsed = false;
            }
            getFocus.Focus();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (cm == CurrentMath.None && display.Text != "")
            {
                cm = CurrentMath.Minus;
                display.Text += " - ";
                dotUsed = false;
            }
            getFocus.Focus();
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            if (cm == CurrentMath.None && display.Text != "")
            {
                cm = CurrentMath.Times;
                display.Text += " x ";
                dotUsed = false;
            }
            getFocus.Focus();
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (cm == CurrentMath.None && display.Text != "")
            {
                cm = CurrentMath.Division;
                display.Text += " ÷ ";
                dotUsed = false;
            }
            getFocus.Focus();
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            sNum1 = "";
            sNum2 = "";
            cm = CurrentMath.None;
            dotUsed = false;
            getFocus.Focus();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            dNum1 = Convert.ToDouble(sNum1);
            dNum2 = Convert.ToDouble(sNum2);

            switch (cm)
            {
                case CurrentMath.Plus:
                    display.Text = (dNum1 + dNum2).ToString();
                    break;
                case CurrentMath.Minus:
                    display.Text = (dNum1 - dNum2).ToString();
                    break;
                case CurrentMath.Times:
                    display.Text = (dNum1 * dNum2).ToString();
                    break;
                case CurrentMath.Division:
                    display.Text = (dNum1 / dNum2).ToString();
                    break;
                default:
                    break;
            }

            sNum1 = "";
            sNum2 = "";

            cm = CurrentMath.None;
            dotUsed = false;
            getFocus.Focus();
        }

        #endregion
        

        #region KeysPress
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

        #endregion

        private void setNumbers(string num)
        {
            if (cm == CurrentMath.None)
            {
                sNum1 += num;
            }
            else if (cm != CurrentMath.None)
            {
                sNum2 += num;
            }
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
