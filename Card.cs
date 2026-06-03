namespace Blackjack
{
    public enum Suit
    {
        Spade,
        Heart,
        Diamond,
        Club
    }

    public enum Value
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public Card(Suit suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
