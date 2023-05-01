using System;
using System.Collections.Generic;

namespace MathsTutor
{
    public class Pack
    {
        private List<Card> cards = new List<Card>();

        public Pack()
        {
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card(value, suit));
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public int[] Deal(int numCards)
        {
            int[] cardValues = new int[numCards * 2 + 1];
            Random random = new Random();

            for (int i = 0; i < numCards * 2 + 1; i += 2)
            {
                Card card1 = cards[random.Next(cards.Count)];
                Card card2 = cards[random.Next(cards.Count)];
                Card operatorCard = operators[random.Next(operators.Count)];

                cardValues[i] = card1.Value;
                cardValues[i + 1] = operatorCard.Value;
                cardValues[i + 2] = card2.Value;

                cards.Remove(card1);
                cards.Remove(card2);
            }

            return cardValues;
        }
        List<operators> operators = new List<operators>
{
    new operators(1, "+"),
    new operators(2, "-"),
    new operators(3, "*"),
    new operators(4, "/")
};


    }
}
