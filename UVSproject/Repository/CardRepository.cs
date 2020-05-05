using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVSproject.Repository
{
    public class CardRepository
    {
        UVS_DatabaseEntities2 context = new UVS_DatabaseEntities2();
        public void AddCard(string cardId)
        {
            int newId = 0;
            if (context.Card.ToList().Count != 0)
            {
                newId = context.Card.ToList().Last().Id + 1;
            }
            var card = new Card()
            {
                Id = newId,
                CardId = "123584695",
                
            };
            context.Card.Add(card);
            context.SaveChanges();
            Console.WriteLine("has runned");
        }
        public bool IsCardExists(string cardNumber)
        {
            Card card = context.Card.Where(x => x.CardId.Equals(cardNumber)).FirstOrDefault();
            return card == null ? false : true;
        }
        public Card GetCard(string cardNumber)
        {
            Card card = context.Card.Where(x => x.CardId.Equals(cardNumber)).FirstOrDefault();
            return card;
        }
    }
}
