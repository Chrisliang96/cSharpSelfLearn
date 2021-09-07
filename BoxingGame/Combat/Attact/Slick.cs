namespace cSharpSelfLearn.BoxingGame.Combat.Attact
{
    public class Slick : IAttack
    {
        public float GetDamage()
        {
            return 30f;
        }
        public float GetRange()
        {
            return 6f;
            
        }
    }
}