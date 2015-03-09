using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0m;
            if (total >= 500)
            {
                discountPercent = 0.2m;
            }
            else if (total >= 250 && total < 500)
            {
                discountPercent = 0.15m;
            }
            else if (total >= 100 && total < 250)
            {
                discountPercent = 0.1m;
            }

            decimal discountAmount = total * discountPercent;
            decimal invoiceTotal = total - discountAmount;

            lblDiscountPercent.Text = discountPercent.ToString("p1");
            lblDiscountAmount.Text = discountAmount.ToString("c");
            lblTotal.Text = invoiceTotal.ToString("c");

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
