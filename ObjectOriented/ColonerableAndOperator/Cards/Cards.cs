using System;
using System.Collections.Generic;

namespace cSharpSelfLearn.ObjectOriented.ColonerableAndOperator
{
    public class Cards : List<Card>, ICloneable
    {
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }
        
        public object Clone()
        {
            Cards newCards = new Cards();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;
        }
    }
}