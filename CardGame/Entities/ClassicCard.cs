using CardGame.Constants;

namespace CardGame.Entities
{
    public class ClassicCard : Card
    {
        public Suits Suit { get; set; }
        public ClassicCardTypes Type { get; set; }
    }
}
