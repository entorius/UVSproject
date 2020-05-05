using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVSproject.Repository;

namespace UVSproject.Services
{
    public class ProductServices
    {
        ProductRepository productRepository = new ProductRepository();
        public Product AddProduct(string productName, int amount, double cost)
        {
            return productRepository.AddProduct(productName, amount, cost);
        }
        public List<Product> GetAllProducts()
        {
            return productRepository.getAllProducts();
        }
        public string BuyProduct(Product product , int amount)
        {
            return productRepository.BuyProduct(product, amount);
        }
        public bool IsProductEnough(Product product, int amount)
        {
            return productRepository.IsProductEnough(product, amount);
        }
    }
}
