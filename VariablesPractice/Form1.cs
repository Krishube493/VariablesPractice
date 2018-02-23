using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HockeyB_Click(object sender, EventArgs e)
        {
            //Create Variable 
            double WayneGretzkyNumber;
            WayneGretzkyNumber = 99;

            //Create Text
            outputLabel.Text = "Wayne Gretzky is number :" + WayneGretzkyNumber;
        }

        private void AreaB_Click(object sender, EventArgs e)
            //NEEDS FIXING 
        {
            //Create Variables
            double Pi, Radius;
            double sum, difference, product, quotient;
            Pi = 3.14159265359;
            Radius = 15;
        
            // Get sum
            product = Pi * Radius;
            outputLabel.Text = "The area of a Circle with a 15cm Radius is: " + product;
        }

        private void CarpetB_Click(object sender, EventArgs e)
        {

        }

        private void BillB_Click(object sender, EventArgs e)
        {

        }
    }
}
