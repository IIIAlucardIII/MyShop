using ConsoleEShopLow.Interfaces;
using ConsoleEShopLow.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleEShopLow.Repository
{
    public class OrdersRepository : IOrderRepository
    {
        readonly List<Order> orders = new List<Order>();

        readonly ICurrentUser _currentUser;
        public OrdersRepository(ICurrentUser currentUser)
        {
            _currentUser = currentUser;
        }

        int orderId = 0;

        public void CreateOrder(Order order)
        {
            orderId++;
            order.OrderId = orderId;

            orders.Add(order);
        }

        public IEnumerable<Order> GetMyOrders()
        {
            return orders
                 .Where(o => o.CreatedBy == _currentUser.GetCurrentUser().UserId);
        }
        public Order GetOrder(int orderId)
        {
            return orders.FirstOrDefault(o => o.OrderId == orderId);
        }

        public IEnumerable<Order> GetOrdersForAdmin()
        {
            
            return orders;       
        }

        public void RemoveOrder(Order order)
        {
            orders.Remove(order);
        }
    }
}
