using System;
using System.Drawing;
using cSharpSelfLearn.BoxingGame.Combat.Attact;
using cSharpSelfLearn.BoxingGame.Combat.Fighter.Property;

namespace cSharpSelfLearn.BoxingGame.Combat.Fighter
{
    public class Monster : IPray , IHunter
    {
        private readonly Random _random;
        private float HP;
        private readonly IAttack[] _attacks;
        private Point _position;

        public Monster(float hp, IAttack[] attacks, Point position)
        {
            if (attacks.Length == 0)
            {
                
            }

            HP = hp;
            _attacks = attacks;
            _position = position;
        }

        public void Move(Point position)
        {
            throw new System.NotImplementedException();
        }

        public void Defended(IAttack attack)
        {
            throw new System.NotImplementedException();
        }

        public float GetHitPoint()
        {
            throw new System.NotImplementedException();
        }

        public Point GetPosition()
        {
            throw new System.NotImplementedException();
        }

        public void Attack(IDefender defender)
        {
            throw new System.NotImplementedException();
        }
        
    }
}