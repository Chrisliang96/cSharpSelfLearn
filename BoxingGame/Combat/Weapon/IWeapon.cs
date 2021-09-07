using cSharpSelfLearn.BoxingGame.Combat.Attact;

namespace cSharpSelfLearn.BoxingGame.Combat.Weapon
{
    public interface IWeapon
    {
        IAttack GetAttack();
    }
}