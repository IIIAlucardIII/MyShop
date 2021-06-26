using System;

namespace ConsoleEShopLow.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }

        public int ProductId { get; set; }

        public int CreatedBy { get; set; }

        public OrderStatus OrderStatus {get; set;}

    }
}
