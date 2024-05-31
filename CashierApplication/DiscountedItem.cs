using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNameSpace
{
    internal class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;      

        public DiscountedItem(string name, double price, int quantity, double discount) : base (name, price, quantity)
        {
            item_discount = discount * 0.01;
            double total = item_discount * price;
            discounted_price = price - total;
        }
        public override double getTotalPrice()
        {
            total_price = discounted_price * item_quantity;
            return total_price;
        }
        public override void setPayment(double amount)
        {
            payment_amount = amount;
        }

        public double getChange() 
        {
            change = payment_amount - getTotalPrice();
            return change;
        }
    }    
}
