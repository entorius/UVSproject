using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVSproject.Repository
{
    public class ProductRepository
    {
        UVS_DatabaseEntities2 context = new UVS_DatabaseEntities2();
        public Product AddProduct(string productName, int amount, double cost)
        {
            long newId = 0;
            if (context.Product.ToList().Count != 0)
            {
                newId = context.Product.ToList().Last().Id + 1;
            }
            var product = new Product()
            {
                Id = newId,
                ProductName = productName,
                Amount = amount,
                Cost = cost,
            };
            context.Product.Add(product);
            context.SaveChanges();
            return product;
        }
        public List<Product> getAllProducts()
        {
            return context.Product.ToList();
        }
        public bool IsProductEnough(Product product,int amount)
        {
            var selectedProduct = context.Product.Where(x => x.Id.Equals(product.Id)).FirstOrDefault();
            return selectedProduct.Amount >= amount ? true : false;

        }
        public string BuyProduct(Product product, int amount)
        {
            Product selectedProduct = context.Product.ToList().FindLast(p => p.Id.Equals(product.Id));
            if (selectedProduct.Amount.Value > amount)
            {
               
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        int productAmount = selectedProduct.Amount.Value - amount;
                       
                        context.Database.ExecuteSqlCommand(
                        @"UPDATE dbo.Product SET Amount = " + productAmount.ToString() +
                            " WHERE Id =" + product.Id.ToString()
                        );

                        context.SaveChanges();

                        dbContextTransaction.Commit();
                    }
                    
                
                return "Transaction succesfull";
            }
            else
            {
                return "There was insufficient amount of the product";
            }
        }
    }
}
