using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVSproject.Repository;

namespace UVSproject.Services
{
    
    class CardServices
    {
        CardRepository cardRepository = new CardRepository();
        public void AddCard(string cardId)
        {
            cardRepository.AddCard(cardId);
        }
        public void AddCards(List<string> cardIds)
        {
            foreach (string cardId in cardIds)
            {
                AddCard(cardId);
            }
        }
        public bool IsCardExists(string cardNumber)
        {
            return cardRepository.IsCardExists(cardNumber);
        }
        public Card GetCard(string cardNumber)
        {
            return cardRepository.GetCard(cardNumber);
        }
    }
}
