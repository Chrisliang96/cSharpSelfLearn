using System.Drawing;

namespace cSharpSelfLearn.BoxingGame.Combat.Fighter
{
    public interface IAttacker
    {
        void Attack(IDefender defender);

        Point GetPosition();
    }
}