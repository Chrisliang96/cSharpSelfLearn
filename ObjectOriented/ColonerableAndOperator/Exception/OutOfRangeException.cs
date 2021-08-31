using System;
    
namespace cSharpSelfLearn.ObjectOriented.ColonerableAndOperator.Exception
{
    public class OutOfRangeException : System.Exception
    {
        public Cards DeckContents { get; }

        public OutOfRangeException(Cards sourceDeckContents)
            : base("There are only 52 cards in the deck.")
        {
            DeckContents = sourceDeckContents;
        }
    }
}