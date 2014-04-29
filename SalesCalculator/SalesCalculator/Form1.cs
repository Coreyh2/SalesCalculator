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
                int subTotal = Convert.ToInt32(subTotalIn.Text);
                int taxes = Convert.ToInt32(taxIn.Text);
                int total = subTotal + taxes;
                totalBox.Text = total.ToString();
            }


        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
