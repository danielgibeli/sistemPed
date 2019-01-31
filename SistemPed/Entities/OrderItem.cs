using System;
using System.Collections.Generic;
using System.Text;

namespace SistemPed.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
