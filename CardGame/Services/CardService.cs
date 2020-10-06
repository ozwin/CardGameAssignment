using CardGame.Entities;
using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Services
{
    public abstract class CardService<T> : ICardService<T>
         where T : ICard
    {
        public virtual Stack<T> GetCardSet()
        {
            throw new NotImplementedException("No generic implementation for cards.");
        }
        public abstract void DisplayCard(T card);

    }
}
