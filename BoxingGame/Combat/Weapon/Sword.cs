using cSharpSelfLearn.BoxingGame.Combat.Attact;

namespace cSharpSelfLearn.BoxingGame.Combat.Weapon
{
     class Sword : IWeapon
    {

        public IAttack GetAttack()
        {
            return new Slick();
        }
    }
}