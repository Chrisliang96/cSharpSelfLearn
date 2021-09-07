using System;

namespace cSharpSelfLearn.BoxingGame.Combat.Attact
{
    public class RandomAttack : IAttack
    {
        private Random _random = new Random();
        public float GetDamage()
        {
            return (float) _random.NextDouble() * 100;
        }

        public float GetRange()
        {
            return (float) _random.NextDouble() * 10;
        }
    }
}