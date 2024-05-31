using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ItemNameSpace
{
    internal abstract class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        protected double total_price;

        public Item(string name, double price, int quantity)
        {
            item_name = name;
            item_price = price;
            item_quantity = quantity;
        }
        public abstract double getTotalPrice();           
        public abstract void setPayment(double amount);
    }
}
