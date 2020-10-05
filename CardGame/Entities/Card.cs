using CardGame.Constants;
using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Entities
{
    /// <summary>
    /// This class is strictly written for Basic 52 cards deck
    /// If we assume the deck of any game cards then these Suits and CardTypes need to be added in sub class and card class can be either empty or can have common feature shared by all cards
    /// for eg Card can be a base class inherited by UNO Cards or 52 Cards deck or any other cards
    /// </summary>
    public class Card 
    {
      public  Suits Suit { get; set; }
      public  CardTypes Type { get; set; }

    }
}
