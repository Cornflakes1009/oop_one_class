using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurricane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int windSpeed = Int32.Parse(windSpeedInput.Text);

            if(windSpeed >= 157)
            {
                speedCalculatedLabel.Text = "Category 5 hurricane.";
            } else if(windSpeed >= 130)
            {
                speedCalculatedLabel.Text = "Category 4 hurricane.";

            } else if(windSpeed > 111)
            {
                speedCalculatedLabel.Text = "Category 3 hurricane.";

            } else if(windSpeed >= 96)
            {
                speedCalculatedLabel.Text = "Category 2 hurricane.";

            } else if(windSpeed >= 74)
            {
                speedCalculatedLabel.Text = "Category 1 hurricane.";

            } else
            {
                speedCalculatedLabel.Text = "Not a hurricane.";
            }
        }
    }
}
