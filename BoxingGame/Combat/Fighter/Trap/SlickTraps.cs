using System.Drawing;
using cSharpSelfLearn.BoxingGame.Combat.Attack;
using cSharpSelfLearn.BoxingGame.Combat.Attact;

namespace cSharpSelfLearn.BoxingGame.Combat.Fighter.Trap
{
    public class SlickTraps : Traps
    {
        public SlickTraps( Point point) : base(new Slick(), point)
        {
        }
    }
}