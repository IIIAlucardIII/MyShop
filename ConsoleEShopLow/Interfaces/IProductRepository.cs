using ConsoleEShopLow.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEShopLow.Interfaces
{
    public interface IProductRepository
    {
        void AddProduct(Product product);

        IEnumerable<Product> GetProduct(string str);

        IEnumerable<Product> GetAllProducts();

        Product GetProductById(int productId);
    }
}
