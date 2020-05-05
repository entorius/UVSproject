using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVSproject.Repository
{
    public class DiscountRepository
    {
        UVS_DatabaseEntities2 context = new UVS_DatabaseEntities2();
        public void AddDiscount(string discountCode, bool isUsed, int productId)
        {
            long newId = 0;
            if (context.Discount.ToList().Count != 0)
            {
                newId = context.Discount.ToList().Last().Id + 1;
            }
            
            var discount = new Discount()
            {
                Id = newId,
                DiscountCode = discountCode,
                IsUsed = isUsed,
                ProductId = productId

            };
            context.Discount.Add(discount);
            context.SaveChanges();
            Console.WriteLine("has runned");
        }
        public bool IsDiscountExists(string discountCode)
        {
            var discount = context.Discount.Where(x => x.DiscountCode.Equals(discountCode)).FirstOrDefault();
            return discount == null ? false : true;
        }
        public List<Discount> GetAllDiscounts()
        {
            return context.Discount.ToList();

        }
        
        public int UseCode(string discountCode)
        {
            string discountCodeUpperCase = discountCode.ToUpper();
            Discount selectedDiscount = context.Discount.ToList().FindLast(d => d.DiscountCode.Equals(discountCodeUpperCase));
            if (selectedDiscount != null)
            {
                
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        

                        context.Database.ExecuteSqlCommand(
                        @"UPDATE dbo.Discount SET IsUsed = 1" + 
                            " WHERE Id =" + selectedDiscount.Id.ToString()
                        );

                        context.SaveChanges();

                        dbContextTransaction.Commit();
                    
                    }

                return 200;
            }
            else
            {
                return 404;
            }
        }
    }
}
