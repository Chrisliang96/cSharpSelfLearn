using System.Drawing;
using cSharpSelfLearn.BoxingGame.Combat.Attact;

namespace cSharpSelfLearn.BoxingGame.Combat.Fighter.Trap
{
    public class PunchTraps : Traps
    {
        public PunchTraps( Point point) : base(new Punch(), point)
        {
        }
    }
}