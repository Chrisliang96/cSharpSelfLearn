using cSharpSelfLearn.BoxingGame.Combat.Attact;

namespace cSharpSelfLearn.BoxingGame.Combat.Attack
{
    public class Slick : IAttack
    {
        public float GetDamage()
        {
            return 30f;
        }
        public float GetRange()
        {
            return 8f;
            
        }
    }
}