namespace ConsoleEShopLow.Models
{
   public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Category CurrentCategory { get; set; }

        public decimal Price { get; set; }
    }
}
