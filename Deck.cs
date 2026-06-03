namespace Blackjack
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            foreach(Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value))) cards.Add(new Card(suit, value));
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                Card card = cards[j];
                cards[j] = cards[i];
                cards[i] = card;

            }
        }

        public Card Deal()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }
}
