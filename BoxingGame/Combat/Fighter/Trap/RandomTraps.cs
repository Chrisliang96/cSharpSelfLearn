using System.Drawing;
using cSharpSelfLearn.BoxingGame.Combat.Attact;

namespace cSharpSelfLearn.BoxingGame.Combat.Fighter.Trap
{
    public class RandomTraps : Traps
    {
        public RandomTraps( Point point) : base(new RandomAttack(), point)
        {
        }
    }
}