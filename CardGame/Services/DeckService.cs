using CardGame.Constants;
using CardGame.Entities;
using CardGame.Helpers;
using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Services
{
    /// <summary>
    /// This service handles the deck and operations related to a deck
    /// </summary>
    public class DeckService<T> : IDeckService<T>
        where T:ICard   // Type check for card type to restict from using other than card types
    {
        private Deck<T> _deck;
        public DeckService() { }
        public DeckService(Stack<T> cards)
        {
            _deck = IntializeDeck(cards);
            Shuffle();
        }
        public T GetTopCard()
        {
            if (_deck.Cards.Count > 0)
                return _deck.Cards.Pop();
            throw new Exception("No cards left in deck! Choose the option 3 to reset the deck.");
        }
        public void Shuffle()
        {
            if (_deck.Cards.Count > 0)
                _deck.Cards = _deck.Cards.Shuffle();
            else
                throw new Exception("No cards left in deck for shuffling! Choose the option 3 to reset the deck.");
        }
        public void ResetDeck(Stack<T> cards)
        {
            _deck.Cards.Clear();
            _deck.Cards = cards;
        }
        public int GetCount()
        {
            return _deck.Cards.Count;
        }
        public void Dispose()
        {
            _deck.Cards.Clear();
            _deck = null;
        }
        #region private mthods
        private Deck<T> IntializeDeck(Stack<T> cards)
        {
            Deck<T> deck = new Deck<T>();
            deck.Cards = cards;
            return deck;
        }
        #endregion

    }
}
