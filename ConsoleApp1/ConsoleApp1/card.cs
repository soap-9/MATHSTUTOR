using System;

namespace MathsTutor
{
    public class Card
    {
        public int Value { get; set; }
        public int Suit { get; set; }

        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            string valueStr;
            switch (Value)
            {
                case 1:
                    valueStr = "Ace";
                    break;
                case 11:
                    valueStr = "Jack";
                    break;
                case 12:
                    valueStr = "Queen";
                    break;
                case 13:
                    valueStr = "King";
                    break;
                default:
                    valueStr = Value.ToString();
                    break;
            }

            string suitStr;
            switch (Suit)
            {
                case 1:
                    suitStr = "+";
                    break;
                case 2:
                    suitStr = "-";
                    break;
                case 3:
                    suitStr = "*";
                    break;
                default:
                    suitStr = "/";
                    break;
            }

            return $"{valueStr} {suitStr}";
        }
    }
}
