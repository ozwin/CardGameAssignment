using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Constants
{
    public enum Suits
    {
        CLUBS = 1,
        HEARTS = 2,
        SPADES = 3,
        DIAMOND = 4
    }
    public enum CardTypes
    {
        ACE = 1,
        TWO = 2,
        THREE = 3,
        FOUR = 4,
        FIVE = 5,
        SIX = 6,
        SEVEN = 7,
        EIGHT = 8,
        NINE = 9,
        TEN = 10,
        JACK = 11,
        QUEEN = 12,
        KING = 13

    }
    public static class GameOption
    {
        public const int PICK = 1;
        public const int SHUFFLE = 2;
        public const int RESTART = 3;
        public const int QUIT = 4;
    }
}
