using System;

namespace cSharpSelfLearn.ObjectOriented.ColonerableAndOperator
{
    public class Card : ICloneable 
    {
        private readonly Rank rank;
        public readonly Suit suit;

        public Card(Rank NewRank , Suit NewSuit)
        {
            rank = NewRank;
            suit = NewSuit;
        }

        public override string ToString() => "The rank is " + rank +  "s";
        
        public object Clone() => MemberwiseClone();
        
        public static bool operator ==(Card card1, Card card2) => (card1.suit == card2.suit) && (card1.rank == card2.rank);

        public static bool operator !=(Card card1, Card card2) => !(card1 == card2);

        public static bool operator >(Card card1, Card card2) => (card1.rank > card2.rank);
        
        public static bool operator <(Card card1, Card card2) => !(card1 >= card2);

        public static bool operator >=(Card card1, Card card2) => (card1.rank >= card2.rank);

        public static bool operator <=(Card card1, Card card2) => !(card1 > card2);
    }
}
