using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesCalculator
{
    public partial class salesForm : Form
    {
        public salesForm()
        {
            InitializeComponent();      
        }

        private void salesForm_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // check to see if the fields are empty, if they are ask for input
            if (string.IsNullOrEmpty(this.subTotalIn.Text))
            {
                MessageBox.Show("Please Input a subtotal");
            }
            if (string.IsNullOrEmpty(this.taxIn.Text))
            {
                MessageBox.Show("Please Input The Taxes");
            }
            else
            {
                // do the calculation
                decimal subTotal = Convert.ToDecimal(subTotalIn.Text);
                decimal taxes = Convert.ToDecimal(taxIn.Text);
                decimal taxCalc = subTotal * taxes / 100;
                Console.WriteLine(taxCalc);
                decimal total = subTotal + taxCalc;
               

                // display the results
                subTotalBox.Text = subTotalIn.Text;
                taxesBox.Text = taxCalc.ToString();
                totalBox.Text = total.ToString();
            }


        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
