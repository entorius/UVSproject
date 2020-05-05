using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVSproject.Repository;

namespace UVSproject.Services
{
    public class DiscountServices
    {
        DiscountRepository discountRepository = new DiscountRepository();
        public void AddDiscount(string discountCode, bool isUsed, int productId)
        {
            discountRepository.AddDiscount(discountCode, isUsed, productId);
        }
        public bool IsDiscountExists(string discountCode)
        {
            return discountRepository.IsDiscountExists(discountCode);
        }
        public List<Discount> GetAllDiscounts()
        {
            return discountRepository.GetAllDiscounts();
        }
        public List<string> GenerateDiscountNumbers(int amount, int productId)
        {
            if (amount <= 2000) { 
                List<string> discountCodes = new List<string>();
                for (int i = 0; i < amount; i++) {
                    string generatedDiscount = DiscountsGenerator.RandomString(8);
                    if (!IsDiscountExists(generatedDiscount))
                    {
                        discountCodes.Add(generatedDiscount);
                        AddDiscount(generatedDiscount, false, productId);
                    }
                    else
                    {
                        amount = amount + 1;
                    }
                }
                return discountCodes;
            }
            else
            {
                return new List<string>();
            }
           
        }
        
        public int UseCode(string discountCode)
        {
            return discountRepository.UseCode(discountCode);

        }
    }
}
