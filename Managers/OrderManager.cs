using System;
using System.Threading.Tasks;
using OrderManagement.Interfaces;
using OrderManagement.Models;

namespace OrderManagement.Managers
{
    public class OrderManager : IOrderManager
    {
        private IOrderSender orderSender;

        public OrderManager(IOrderSender sender)
        {
            orderSender = sender;
        }

        public Order Get()
        {
            return new Order()
            {
                CustomerId = "123",
                Date = DateTime.UtcNow,
                TotalAmount = 10.5M
            };
        }

        public async Task<string> Transmit(Order order)
        {
            return await orderSender.Send(order);
        }
    }
}
