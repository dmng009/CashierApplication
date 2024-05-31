using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier("Clarisa Castro", "Finance", "cashier101", "Clarisa123");

            if (cashier.validateLogin(usernametxt.Text, passtxt.Text))
            {
                MessageBox.Show("Welcome, " + cashier.getFullName() + " of " + cashier.getDepartment());
                frmPurchaseDiscountedItem frmPurchaseDiscountedItem = new frmPurchaseDiscountedItem();
                frmPurchaseDiscountedItem.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
