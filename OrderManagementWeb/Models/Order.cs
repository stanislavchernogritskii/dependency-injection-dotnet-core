using System;
using System.Collections.Generic;

namespace OrderManagement.Models
{
    [Serializable]
    public class Order
    {
        public string CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order()
        {
            Items = new List<OrderItem>();
        }
    }
}
