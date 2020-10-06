using System;
using System.Collections.Generic;

namespace CardGame.Interfaces
{
    public interface IDeckService<T> : IDisposable
        where T : ICard
    {
        T GetTopCard();
        void Shuffle();
        void ResetDeck(Stack<T> cards);
        int GetCount();

    }
}
