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
    public class DeckService<T> : IDeckService<T>
    {
        private Deck<T> _deck;
        public DeckService(Stack<T> cards)
        {
            _deck = IntializeDeck(cards);
            Shuffle();
        }
        public Card GetTopCard()
        {
            return _deck.Cards.Pop();
        }
        public void Shuffle()
        {
            _deck.Cards = _deck.Cards.Shuffle();
        }
        public Deck<T> IntializeDeck(Stack<T> cards)
        {
            Deck<T> deck = new Deck<T>();
            deck.Cards = cards;
            return deck;
        }
        public void ResetDeck(Stack<T> cards)
        {
            _deck.Cards.Clear();
            _deck.Cards = cards;
        }
        public void Dispose()
        {
            _deck.Cards.Clear();
            _deck = null;
        }

    }
}
