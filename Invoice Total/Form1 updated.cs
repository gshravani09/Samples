using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Total
{
    public partial class Form1 : Form
    {
        private object txtDiscountPercent;
        private object txtDiscountAmount;
        private object txttotal;
        private object txtTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0m;
            if (subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;
            }
            txtDiscPercent.Text = discountPercent.ToString();
            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;
            txtDiscPercent.Text = discountPercent.ToString("p1");
            textDiscount.Text = discountAmount.ToString("c");
            txtT.Text = invoiceTotal.ToString("c");

            txtSubtotal.Focus();
        }

        
    }
}

