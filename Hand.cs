namespace Blackjack
{
    public class Hand
    {
        List<Card> hand = new List<Card>();

        public void Clear()
        {
            hand.Clear();
        }

        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        public Card GetCard(int index)
        {
            return hand[index];
        }

        public int GetTotal()
        {
            int total = 0;
            bool hasAce = false;
            foreach (Card card in hand)
            {
                if (card.Value is Value.Ace)
                {
                    total += 11;
                    hasAce = true;
                }
                else if (card.Value is Value.Jack || card.Value is Value.King || card.Value is Value.Queen) total += 10;
                else total += (int)card.Value + 1;
            }
            if (total > 21 && hasAce) total -= 10;
            return total;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Card card in hand) result += card.ToString() + "\n";
            return result;
        }
    }
}
