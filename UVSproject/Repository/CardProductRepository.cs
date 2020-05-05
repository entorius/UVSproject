using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVSproject.Repository
{
    public class CardProductRepository
    {
        UVS_DatabaseEntities2 context = new UVS_DatabaseEntities2();
        public void BuyProductWithCard(Product product, Card card, int amount, double cost )
        {
            int newId = 0;
            if(context.CardProduct.ToList().Count > 0)
            {
                newId = context.CardProduct.ToList().Count;
            }
            var cardProduct = new CardProduct()
            {
                Id = newId,
                ProductId = product.Id,
                CardId = card.Id,
                Amount = amount,
                Cost = cost

            };
            context.CardProduct.Add(cardProduct);
            context.SaveChanges();
            Console.WriteLine("Card Product Added");
            Console.WriteLine(context.CardProduct.ToList().Count);
        }
        public (int Action, string[] ProductCodes) Check(string cardId)
        {
            int cardIdNumber = Int32.Parse(cardId);
           
            Card card = context.Card.ToList().Find(c => c.CardId.Trim(' ').Equals(cardId));
            if (card != null)
            {
                List<CardProduct> cardProducts = context.CardProduct.ToList().FindAll(p => p.CardId == card.Id);
                if (cardProducts.Count > 0)
                {
                    string[] ProductCodes = cardProducts.Select(item => item.ProductId.ToString()).Distinct().ToArray();
                    return (Action: 200, ProductCodes: ProductCodes);
                }
                else
                {
                    return (Action: 404, ProductCodes: new string[0]);
                }
            }
            else
            {
                return (Action: 404, ProductCodes: new string[0]);
            }
        }
    }
}
