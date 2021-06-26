using ConsoleEShopLow.Models;
using System.Collections.Generic;

namespace ConsoleEShopLow.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);

        IEnumerable<Order> GetMyOrders();

        IEnumerable<Order> GetOrdersForAdmin();

        void RemoveOrder(Order order);
        Order GetOrder(int orderId);


    }
}
