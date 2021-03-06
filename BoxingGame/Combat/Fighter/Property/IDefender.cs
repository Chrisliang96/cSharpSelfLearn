using System.Drawing;
using cSharpSelfLearn.BoxingGame.Combat.Attact;

namespace cSharpSelfLearn.BoxingGame.Combat.Fighter.Property
{
    public interface IDefender
    {
        void Defended(IAttack attack);

        float GetHitPoint();
        
        Point GetPosition();

    }
}