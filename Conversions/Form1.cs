using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double choice = Convert.ToDouble(choiceInput.Text);
                double number = Convert.ToDouble(inputValue.Text);

                if (choice == 1)
                {
                    double total1 = InchToCm(number);
                    outputLabel.Text = $"{number} inches is {total1} cms";
                }
                else if (choice == 2)
                {
                    double total2 = FeetToCm(number);
                    outputLabel.Text = $"{number} feet is {total2} cms";
                }
                else if (choice == 3)
                {
                   double total3 = YardsToMetres(number);
                   outputLabel.Text = $"{number} yards is {total3} metres";
                }
                else if (choice == 4)
                {
                    double total4 = KilometresToMiles(number);
                    outputLabel.Text = $"{number} miles is {total4} kilometres";
                }
                else
                {
                    outputLabel.Text = "Please enter a number between 1 and 4";
                }
            }

            catch { outputLabel.Text = "Please enter a number between 1 and 4"; }

        }

        public double InchToCm(double inch)
        {
            double cm = inch * 2.54;
            return cm;
        }

        public double FeetToCm(double feet)
        {
            double cm = feet * 30.48;
            return cm;         
        }

        public double YardsToMetres(double yard)
        {
            double metre = yard * 0.91;
            return metre;           
        }

        public double KilometresToMiles(double mile)
        {
            double kilometre = mile * 1.6;
            return kilometre;
            
        }
    }
}

