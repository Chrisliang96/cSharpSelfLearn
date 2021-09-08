using System;
using System.Drawing;
using cSharpSelfLearn.BoxingGame.Combat.Attact;
using cSharpSelfLearn.BoxingGame.Combat.Exception;
using cSharpSelfLearn.BoxingGame.Combat.Fighter.Property;
using cSharpSelfLearn.BoxingGame.Combat.Tools;

namespace cSharpSelfLearn.BoxingGame.Combat.Fighter
{
    public class Monster : ICombatant
    {
        private readonly Random _random;
        private float HP;
        private readonly IAttack[] _attacks;
        private Point _position;

        public Monster(float hp, IAttack[] attacks, Point position)
        {
            if (attacks.Length == 0)
            {
                throw new NoneOfAttackException("monster must attack");
            }

            HP = hp;
            _attacks = attacks;
            _position = position;
            _random = new Random();
        }

        public void Move(Point position)
        {
            _position = position;
        }

        public void Defended(IAttack attack)
        {
            HP -= attack.GetDamage();
        }

        public float GetHitPoint()
        {
            return HP;
        }

        public Point GetPosition()
        {
            return _position;
        }

        public void Attack(IDefender defender)
        {
            var attackDamage = _attacks[_random.Next(0,_attacks.Length)];
            var distance = Distance.GetDistance(_position,defender.GetPosition());
            if (attackDamage.GetRange() > distance)
            {
                defender.Defended(attackDamage);
            }
        }
        
    }
}