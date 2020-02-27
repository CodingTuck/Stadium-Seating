using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                const double CLASS_A_PRICE = 15.0; // a seats value
                const double CLASS_B_PRICE = 12.0; // b seats value
                const double CLASS_C_PRICE = 9.0; // c seats value

                double aSeats, bSeats, cSeats, totalGenerated; // variables

                //Get tickets sold in each class
                aSeats = double.Parse(userInputA.Text);
                bSeats = double.Parse(userInputB.Text);
                cSeats = double.Parse(userInputC.Text);

                //Calculate revenue generated for A, B, C, and Total
                aSeats = (aSeats * CLASS_A_PRICE);
                bSeats = (bSeats * CLASS_B_PRICE);
                cSeats = (cSeats * CLASS_C_PRICE);
                totalGenerated = (aSeats) + (bSeats) + (cSeats);

                //Display Revenue Generated in each class and total box in currency rounded to 2 decimal places
                aRevenueOutput.Text = aSeats.ToString("c");
                bRevenueOutput.Text = bSeats.ToString("c");
                cRevenueOutput.Text = cSeats.ToString("c");
                totalOutput.Text = totalGenerated.ToString("c");

            }
            catch 
            {
                MessageBox.Show("Please fill out all boxes or only input numbers");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears user input form tickets sold and total revenues
            userInputA.Text = "";
            userInputB.Text = "";
            userInputC.Text = "";
            aRevenueOutput.Text = "";
            bRevenueOutput.Text = "";
            cRevenueOutput.Text = "";
            totalOutput.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
