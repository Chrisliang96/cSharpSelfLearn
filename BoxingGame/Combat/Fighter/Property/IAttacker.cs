using System.Drawing;

namespace cSharpSelfLearn.BoxingGame.Combat.Fighter.Property
{
    public interface IAttacker
    {
        void Attack(IDefender defender);

        Point GetPosition();
    }
}