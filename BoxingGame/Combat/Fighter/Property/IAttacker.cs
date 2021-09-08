using System.Drawing;
using cSharpSelfLearn.BoxingGame.Combat.Fighter.Property;

namespace cSharpSelfLearn.BoxingGame.Combat.Fighter
{
    public interface IAttacker
    {
        void Attack(IDefender defender);

        Point GetPosition();
    }
}