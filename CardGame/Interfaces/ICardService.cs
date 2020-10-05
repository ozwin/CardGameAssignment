using CardGame.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Interfaces
{
    public interface ICardService<T>
    {
        Stack<T> GetCardSet();

    }
}
