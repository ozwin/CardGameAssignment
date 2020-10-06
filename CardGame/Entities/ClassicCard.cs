using CardGame.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Entities
{
    public class ClassicCard : Card
    {
        public Suits Suit { get; set; }
        public ClassicCardTypes Type { get; set; }
    }
}
