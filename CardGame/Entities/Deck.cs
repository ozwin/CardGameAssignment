using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Entities
{
    /// <summary>
    /// This is a generic class for deck , and the cards can be of any type e.g UNO deck, Pokemon cards deck
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Deck<T>
    {
        public Stack<T> Cards { get; set; } = new Stack<T>();
    }
}
