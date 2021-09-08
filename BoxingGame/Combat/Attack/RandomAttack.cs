using System;

namespace cSharpSelfLearn.BoxingGame.Combat.Attact
{
    public class RandomAttack : IAttack
    {
        private Random _random = new Random();
        public float GetDamage()
        {
            return (float) Math.Ceiling(_random.NextDouble() * 50) ;
        }

        public float GetRange()
        {
            return (float) Math.Ceiling(_random.NextDouble() * 10) ;
        }
    }
}