using CardGame.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Interfaces
{
    /// <summary>
    /// Basic Operations for any card types that inehrit ICardServices
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICardService<T>
        where T: ICard
    {
        Stack<T> GetCardSet();
        void DisplayCard(T card);

    }
}
