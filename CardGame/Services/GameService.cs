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
    public class GameService : IDisposable
    {
        public GameService()
        {

        }
        public void Run()
        {
            ICardService<Card> cardService = new ClassicCardService();
            IDeckService<Card> deckService = new DeckService<Card>(cardService.GetCardSet());
            Console.WriteLine("Pick a option");
            while (true)
            {
                try
                {
                    int gameMode = ReadUserResponse();
                    switch (gameMode)
                    {
                        case GameOption.PICK:
                            var card = deckService.GetTopCard();
                            cardService.DisplayCard(card);
                            var deckSize = deckService.GetCount();
                            Console.WriteLine($"{deckSize} - cards left in the deck.");
                            break;
                        case GameOption.SHUFFLE:
                            deckService.Shuffle();
                            Console.WriteLine("Deck shuffled succesfully!.");
                            break;
                        case GameOption.RESTART:
                            deckService.ResetDeck(cardService.GetCardSet());
                            Console.WriteLine("New game!!.");
                            break;
                        case GameOption.QUIT:
                            return;
                        default:
                            throw new InvalidOperationException("Please choose the options from the menu");
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
        public void Dispose()
        {

        }
        #region private Methods
        private int ReadUserResponse()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1) Pick a card  2)Shuffle the deck 3) Restart the game 4)Quit");

            try
            {
                int inputOption = int.Parse(Console.ReadLine());
                return inputOption;
            }
            catch (FormatException exception)
            {
                throw new FormatException("Please enter only numbers.");
            }
            catch (Exception exception)
            {
                throw new Exception("Unhandled Exception occured.");
            }
        }
        #endregion
    }
}
