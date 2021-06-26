using ConsoleEShopLow.Interfaces;
using ConsoleEShopLow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleEShopLow.Repository
{
    public class ProductsRepository : IProductRepository
    {
        readonly List<Product> products = new List<Product>();
        int productId = 0;

        public ProductsRepository()
        {
            products.Add(new Product
            {
                Name = "Aple",
                Description = "Green and sour",
                ProductId = 1,
                CurrentCategory = Category.Fruits,
                Price = 2
                
            });
        }
        public void AddProduct(Product product)
        {
            productId++;
            product.ProductId = productId;
            products.Add(product);
        }

        public IEnumerable<Product> GetProduct(string str)
        {
            return products
                .Where(p => p.Name.Contains(str));
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
