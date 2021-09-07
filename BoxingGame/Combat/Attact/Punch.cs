namespace cSharpSelfLearn.BoxingGame.Combat.Attact
{
    public class Punch : IAttack
    {
        public float GetDamage()
        {
            return 60f; 
        }

        public float GetRange()
        {
            return 3f;
        }
    }
}