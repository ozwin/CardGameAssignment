using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame.Helpers
{
    public static class StackExtension
    {
        static Random _random = new Random();
        public static Stack<T> Shuffle<T>(this Stack<T> stack)
        {
            return new Stack<T>(stack.OrderBy(x => _random.Next()));
        }

    }
}
