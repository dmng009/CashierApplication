using ItemNameSpace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            double price = Convert.ToDouble(textBox3.Text);
            int quantity = Convert.ToInt32(textBox4.Text);
            double discount = Convert.ToDouble(textBox2.Text);
                      
            DiscountedItem items = new DiscountedItem(item, price, quantity, discount);
            TotalAmount.Text = items.getTotalPrice().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            double price = Convert.ToDouble(textBox3.Text);
            int quantity = Convert.ToInt32(textBox4.Text);
            double discount = Convert.ToDouble(textBox2.Text);

            DiscountedItem items = new DiscountedItem(item, price, quantity, discount);
            items.setPayment(Convert.ToDouble(textBox5.Text));
            Change.Text = items.getChange().ToString();
        }
    }
}
