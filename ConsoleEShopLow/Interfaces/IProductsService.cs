using ConsoleEShopLow.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEShopLow.Interfaces
{
    public interface IProductService

    {
        IEnumerable<Product> GetProducts();
        Product CreateProduct(string productName, Category productCategory, string productDescription, decimal price);
        Product EditProduct(int productId, string productName, Category productCategory, string productDescription, decimal price);
    }
}
