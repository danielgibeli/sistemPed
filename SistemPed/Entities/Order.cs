using SistemPed.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemPed.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public List<Client> Clients { get; set; } = new List<Client>();

        public Order()
        {
        }

        public Order(DateTime date, OrderStatus status)
        {
            Date = date;
            Status = status;
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

    }
}
