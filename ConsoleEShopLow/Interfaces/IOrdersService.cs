using ConsoleEShopLow.Models;
using System.Collections.Generic;

namespace ConsoleEShopLow.Interfaces
{
    public interface IOrdersService
    {
        IEnumerable<Order> GetMyOrders();
        IEnumerable<Order> GetOrdersForAdmin();
        Order CreateOrder(Product product);
        void EditOrderStatus(int orderId, OrderStatus orderStatus);
    }
}
