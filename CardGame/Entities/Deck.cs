using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
