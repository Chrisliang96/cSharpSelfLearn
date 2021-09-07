using System.Drawing;
using cSharpSelfLearn.BoxingGame.Combat.Attact;
using cSharpSelfLearn.BoxingGame.Combat.Tools;

namespace cSharpSelfLearn.BoxingGame.Combat.Fighter.Trap
{
    public abstract class Traps :IAttacker
    {
        private IAttack _attack;
        private Point _point;

        protected Traps(IAttack attack, Point point)
        {
            _attack = attack;
            _point = point;
        }

        public void Attack(IDefender defender)
        {
            if (Distance.GetDistance(defender.GetPositon(), _point) < _attack.GetRange())
            {
                defender.Defended(_attack);
            }
        }

        public Point GetPosition()
        {
            return _point;
        }
    }
}