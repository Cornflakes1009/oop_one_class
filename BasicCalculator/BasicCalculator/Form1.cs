using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // clears the user input text
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = string.Empty;
            FocusInputText();

            InsertTextValue("0");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(this.UserInputText.Text.Length >= this.UserInputText.SelectionStart + 1)
                this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);
            FocusInputText();
        }


        // Inserts Decimal
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
        }
        

        // Equals Button
        private void EqualsButton_Click(object sender, EventArgs e)
        {

        }


        // Operators
        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
        }


        // Numbers
        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
        }


        // Public Methods
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }
        private void InsertTextValue(string value)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);
        }
        private void CalculateEquation()
        {

        }
    }
}
