using System.Drawing;

namespace cSharpSelfLearn.BoxingGame.Combat.Fighter
{
    public interface IDefender
    {
        void Defended(IAttacker attacker);

        float GetHitPoint();

        Point GetPositon();

    }
}