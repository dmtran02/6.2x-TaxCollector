using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCollector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtName.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateTaxableIncome())
            {
                double income = double.Parse(txtTaxableIncome.Text);
                txtIncomeTaxOwed.Text = TaxTableLookUp(income).ToString();
                txtTaxableIncome.Focus();
            }
        }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            btnCalculate_Click(sender, e);
        }

        private void EscPress(object sender, KeyPressEventArgs e)
        {
            btnExit_Click(sender, e);
        }

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
