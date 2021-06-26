using ConsoleEShopLow.Interfaces;
using ConsoleEShopLow.Models;
using System;
using System.Collections.Generic;

namespace ConsoleEShopLow.Services
{
    public class OrdersService : IOrdersService
    {
        readonly ICurrentUser _currentUser;
        readonly IOrderRepository _orderRepository;
        
        

        public OrdersService(ICurrentUser currentUser, IOrderRepository orderRepository)
        {
            _currentUser = currentUser;
            _orderRepository = orderRepository;
            
        }
        public Order CreateOrder(Product product)
        {
            Order order = new Order
            {
                ProductId = product.ProductId,
                CreatedBy = _currentUser.GetCurrentUser().UserId,
                Date = DateTime.UtcNow,
                OrderStatus = OrderStatus.New
            };

            _orderRepository.CreateOrder(order);
            return order;
             
        }

        public void EditOrderStatus(int orderId, OrderStatus orderStatus)
        {
            var currentOrder = _orderRepository.GetOrder(orderId);

            if (_currentUser.GetCurrentUser().CurentRole == Role.Admin)
            {
                if (orderStatus != OrderStatus.New && orderStatus != OrderStatus.CanceledByUser)
                {
                    currentOrder.OrderStatus = orderStatus;
                }
                else
                {
                    throw new InvalidOperationException("");
                }
            }
            if (_currentUser.GetCurrentUser().CurentRole == Role.User)
            {
                if (orderStatus == OrderStatus.CanceledByUser || orderStatus == OrderStatus.Received)
                {
                    currentOrder.OrderStatus = orderStatus;
                }
                else
                {
                    throw new InvalidOperationException("");
                }
            }
        }

        public IEnumerable<Order> GetMyOrders()
        {
            return _orderRepository.GetMyOrders();
        }

        public IEnumerable<Order> GetOrdersForAdmin()
        {
            if (_currentUser.GetCurrentUser().CurentRole == Role.Admin)
            {
                return _orderRepository.GetOrdersForAdmin();
            }
            else
            {
                throw new Exception("");
            }
        }
    }
}
