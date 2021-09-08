namespace cSharpSelfLearn.BoxingGame.Combat.Attact
{
    public class Punch : IAttack
    {
        public float GetDamage()
        {
            return 20f; 
        }

        public float GetRange()
        {
            return 3f;
        }
    }
}