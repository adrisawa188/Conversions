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
                    InchToCm(number);
                }
                else if (choice == 2)
                {
                    FeetToCm(number);
                }
                else if (choice == 3)
                {
                    YardsToMetres(number);
                }
                else if (choice == 4)
                {
                    KilometresToMiles(number);
                }
                else
                {
                    outputLabel.Text = "Please enter a number between 1 and 4";
                }
            }

            catch { outputLabel.Text = "Please enter a number between 1 and 4"; }

        }

        public void InchToCm(double inch)
        {
            double cm = inch * 2.54;

            outputLabel.Text = $"{inch} inches is {cm} cms";
        }

        public void FeetToCm(double feet)
        {
            double cm = feet * 30.48;

            outputLabel.Text = $"{feet} feet is {cm} cms";
        }

        public void YardsToMetres(double yard)
        {
            double metre = yard * 0.91;

            outputLabel.Text = $"{yard} yards is {metre} metres";
        }

        public void KilometresToMiles(double mile)
        {
            double kilometre = mile * 1.6;

            outputLabel.Text = $"{mile} miles is {kilometre} kilometres";
        }
    }
}

