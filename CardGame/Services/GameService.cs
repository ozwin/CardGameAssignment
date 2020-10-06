using CardGame.Constants;
using CardGame.Entities;
using CardGame.Interfaces;
using System;

namespace CardGame.Services
{
    /// <summary>
    /// This service handles the responsibilty of playing games based on the user input
    /// </summary>
    public class GameService : IDisposable
    {
        public GameService()
        {

        }
        /// <summary>
        /// This method runs the classic card version game 
        /// </summary>
        public void Run()
        {
            IClassicCardService cardService = new ClassicCardService();
            IDeckService<ClassicCard> deckService = new DeckService<ClassicCard>(cardService.GetCardSet());
            Console.WriteLine("Choose a option from below menu");
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
                            deckService.Dispose();
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
        /// <summary>
        /// This method is intended for only numerics as user input
        /// </summary>
        /// <returns></returns>
        private int ReadUserResponse()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1) Pick a card  2)Shuffle the deck 3)Restart the game 4)Quit");
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
