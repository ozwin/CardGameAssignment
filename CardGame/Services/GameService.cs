using CardGame.Entities;
using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Services
{
    public class GameService
    {
        public GameService()
        {

        }
        public void Run()
        {
            ICardService<Card> _cards = new ClassicCardService();
            IDeckService<Card> _deckService = new DeckService<Card>(_cards.GetCardSet());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pick a option");
            while (true)
            {
                Console.WriteLine("1) Pick a card  2)Shuffle the deck 3) Restart the game");
                try
                {
                    int inputOption = int.Parse(Console.ReadLine());
                    switch (inputOption)
                    {
                        case 1:
                            var card = _deckService.GetTopCard();
                            Console.WriteLine($"{card.Suit} and {card.Type}");
                            break;
                        case 2:
                            _deckService.Shuffle();
                            break;
                        case 3:
                            _deckService.ResetDeck(_cards.GetCardSet());
                            break;
                        default:
                            throw new InvalidOperationException("Please choose the options from the meu");
                    }

                }
                catch (Exception exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(exception.Message);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
        }
    }
}
