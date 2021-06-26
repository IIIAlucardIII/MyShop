using ConsoleEShopLow.Interfaces;
using ConsoleEShopLow.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEShopLow.Services
{
    public class ProductService : IProductService
    {
        readonly ICurrentUser _currentUser;
        readonly IProductRepository _productRepository;
        public ProductService(ICurrentUser currentUser,IProductRepository productRepository)
        {
            _currentUser = currentUser;
            _productRepository = productRepository;
        }
        public Product CreateProduct(string productName, Category productCategory, string productDescription, decimal price)
        {
            Product product = new Product
            {
                CurrentCategory = productCategory,
                Name = productName,
                Price = price,
                Description = productDescription
                
            };
            _productRepository.AddProduct(product);

            return product;

        }

        public Product EditProduct(int productId, string productName, Category productCategory, string productDescription, decimal price)
        {
            var currentProduct = _productRepository.GetProductById(productId);
            currentProduct.Name = productName;
            currentProduct.CurrentCategory = productCategory;
            currentProduct.Description = productDescription;
            currentProduct.Price = price;

            return currentProduct;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
