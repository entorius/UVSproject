using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVSproject.Repository;

namespace UVSproject.Services
{
    public class CardProductServices
    {
        CardProductRepository cardProductRepository = new CardProductRepository();
        public void BuyProductWithCard(Product product, Card card, int amount, bool discountUsed)
        {
            double countedCost = amount * product.Cost.Value;
            if (discountUsed)
            {
                countedCost = 0;
            }
            cardProductRepository.BuyProductWithCard(product, card, amount, countedCost);
        }
        public (int Action, string[] ProductCodes) Check(string cardId)
        {
            return cardProductRepository.Check(cardId);
        }
    }
}
