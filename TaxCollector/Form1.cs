using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Duc Tran
 * Professor Frank Friedman
 * CIS 3309 - Assignment 6.2x // TaxCollector
 * Last Updated: February 4, 2019
 */

namespace TaxCollector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtName.Focus();
        }

        /*
         * Uses the ValidateTaxableIncome to confirm if user input is a valid number and calculate the 
         * appropriate tax owed based on the Tax Table used in the TaxTableLookUp method.
         */

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateTaxableIncome())
            {
                double income = double.Parse(txtTaxableIncome.Text);
                txtIncomeTaxOwed.Text = TaxTableLookUp(income).ToString();
                txtTaxableIncome.Focus();
            }
        }

        /*
         * Checks if user's name is present in the text box.
         *  -If present, program welcomes user and enables TaxIncome and IncomeTaxOwed labels and txtTaxableIncome,
         *   btnNameOK becomes invisible, txtName is read-only and txtTaxableIncome is focused.
         *  -Otherwise, a message box will ask user to input a name.
         */

        private void btnNameOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a name to continue.", "No Name Found!");
                txtName.Focus();
            }
            else
            {
                MessageBox.Show("Welcome " + txtName.Text + "!", "Welcome!");
                txtName.ReadOnly = true;
                btnNameOK.Visible = false;
                lblTaxableIncome.Enabled = true;
                lblIncomeTaxOwed.Enabled = true;
                txtTaxableIncome.Enabled = true;
                btnCalculate.Enabled = true;
                txtTaxableIncome.Focus();
            }
        }

        /*
         * When the Exit button is clicked, the application will close.
         */

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Event handler for the Calculate function when the 'Enter' key is pressed, the tax owed is calculated.
         */

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            btnCalculate_Click(sender, e);
        }

        /*
         * Event handler for the Exit function when the 'Esc' key is pressed, the application closes.
         */

        private void EscPress(object sender, KeyPressEventArgs e)
        {
            btnExit_Click(sender, e);
        }

        /*
         * Method that returns a boolean variable to determine whether the user-inputted income is a valid value.
         *  -Returns true if input is a valid value
         *  -Otherwise, returns false for an invalid input and displays a message box requesting the user to enter a valid number
         */

        public bool ValidateTaxableIncome()
        {
            bool result = false;
            double income;
            bool success = double.TryParse(txtTaxableIncome.Text, out income);
            if (success)
            {
                Console.WriteLine(income + " is a valid value.");
                result = true;
                return result;
            }
            else
            {
                MessageBox.Show("The value you have entered is not a valid number.", "Incorrect Input!");
                Console.WriteLine(income + " is not a valid value.");
                txtTaxableIncome.Focus();
            }

            return result;
        }

        /*
         * Aids in the calculation of tax owed based on a table from the IRS provided and the user-inputted income.
         */

        public double TaxTableLookUp(double taxableIncome)
        {
            double taxOwed = 0;
            if(taxableIncome > 0 && taxableIncome <= 9225)
            {
                taxOwed = 0 + 0.10 * (taxableIncome - 0);
            }
            else if(taxableIncome > 9225 && taxableIncome <= 37450)
            {
                taxOwed = 922.50 + 0.15 * (taxableIncome - 9225);
            }
            else if(taxableIncome > 37450 && taxableIncome <= 90750)
            {
                taxOwed = 5156.25 + 0.25 * (taxableIncome - 37450);
            }
            else if(taxableIncome > 90750 && taxableIncome <= 189300)
            {
                taxOwed = 18481.25 + 0.28 * (taxableIncome - 90750);
            }
            else if(taxableIncome > 189300 && taxableIncome <= 411500)
            {
                taxOwed = 46075.25 + 0.33 * (taxableIncome - 189300);
            }
            else if(taxableIncome > 411500 && taxableIncome <= 413200)
            {
                taxOwed = 119401.25 + 0.35 * (taxableIncome - 411500);
            }
            else if(taxableIncome < 413200)
            {
                taxOwed = 119996.25 + 0.396 * (taxableIncome - 413200);
            }
            else
            {
                taxOwed = -1.0;
            }
            return taxOwed;
        }
    }
}
