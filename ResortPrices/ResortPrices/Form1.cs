using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortPrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateNights_Click(object sender, EventArgs e)
        {
            int numOfNights = Int32.Parse(nightsInput.Text);
            if(numOfNights == 1 || numOfNights == 2)
            {
                outputLabel.Text = $"Your total stay will cost ${200 * numOfNights}. The price per night is $200";
            }
            else if (numOfNights == 3 || numOfNights == 4)
            {
                outputLabel.Text = $"Your total stay will cost ${180 * numOfNights}. The price per night is $180.";
            }
            else if (numOfNights >= 5 && numOfNights <= 7)
            {
                outputLabel.Text = $"Your total stay will cost ${160 * numOfNights}. The price per night is $160.";
            }
            else if (numOfNights >= 8)
            {
                outputLabel.Text = $"Your total stay will cost ${145 * numOfNights}. The price per night is $145.";
            }
            else
            {
                outputLabel.Text = "Please enter a valid number of nights.";
            }
        }
    }
}
