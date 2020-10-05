using CardGame.Constants;
using CardGame.Entities;
using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Services
{
    public class ClassicCardService:ICardService<Card>
    {
        public ClassicCardService()
        {

        }
        public Stack<Card> GetCardSet()
        {
            var cards = new Stack<Card>();
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (CardTypes cardType in Enum.GetValues(typeof(CardTypes)))
                {
                    cards.Push(new Card() { Suit = suit, Type = cardType });
                }
            }
            return cards;
        }
    }
}
