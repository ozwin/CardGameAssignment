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
    public class ClassicCardService : CardService<ClassicCard>, IClassicCardService
    {
        public ClassicCardService()
        {

        }
        public override Stack<ClassicCard> GetCardSet()
        {
            var cards = new Stack<ClassicCard>();
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (ClassicCardTypes cardType in Enum.GetValues(typeof(ClassicCardTypes)))
                {
                    cards.Push(new ClassicCard() { Suit = suit, Type = cardType });
                }
            }
            return cards;
        }
        public override void DisplayCard(ClassicCard card)
        {
            Console.WriteLine($"{card.Suit} and {card.Type}");
        }

    }
}
