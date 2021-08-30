using System;

namespace cSharpSelfLearn.ObjectOriented.Colonerable
{
    public class Deck : ICloneable
    {
        
        private Cards cards = new Cards();
        
        public Deck()
        {
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 9; rankVal++)
                {
                    cards.Add(new Card((Rank) suitVal, (Suit) rankVal));
                }
            }
        }
        
        public Deck(Cards newCards)
        {
            cards = newCards;
        }

        public void Shuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[31];
            Random sourceGen = new Random();
            for (int i = 0; i < 30; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(30);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }
            newDeck.CopyTo(cards);
        }
        
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 )
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                    "Value must be between 0 and 51."));
        }


        public object Clone()
        {
            Deck newDeck = new Deck(cards.Clone() as Cards);
            return newDeck;
        }
    }

   
}