using CardGame.Interfaces;
using System.Collections.Generic;

namespace CardGame.Entities
{
    /// <summary>
    /// This is a generic class for deck of cards , i.e class that inherit Card class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Deck<T> where T:ICard
    {
        public Stack<T> Cards { get; set; } = new Stack<T>();
    }
}
