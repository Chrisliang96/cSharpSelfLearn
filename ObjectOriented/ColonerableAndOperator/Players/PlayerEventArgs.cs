using System;

namespace cSharpSelfLearn.ObjectOriented.ColonerableAndOperator
{
    public class PlayerEventArgs : EventArgs
    {
        public Player Player { get; set; }
        public PlayerState State { get; set; }
    }
}