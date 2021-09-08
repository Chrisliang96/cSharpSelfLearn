using System;
using System.Drawing;
using System.Security.Principal;
using cSharpSelfLearn.BoxingGame.Combat.Armor;
using cSharpSelfLearn.BoxingGame.Combat.Attact;
using cSharpSelfLearn.BoxingGame.Combat.Fighter.Property;
using cSharpSelfLearn.BoxingGame.Combat.Tools;
using cSharpSelfLearn.BoxingGame.Combat.Weapon;

namespace cSharpSelfLearn.BoxingGame.Combat.Fighter
{
    public class Human : ICombatant
    {
        private float HP;
        private IArmor _armor;
        private IWeapon _weapon;
        private Point _position;

        public Human(float hp, IArmor armor, IWeapon weapon, Point position)
        {
            HP = hp;
            _armor = armor;
            _weapon = weapon;
            _position = position;
        }
        
        public void Move(Point position)
        {
            
            var positionX = (Int32)(position.X - 3*new Random().NextDouble());
            var positionY = (Int32)(position.Y - 3*new Random().NextDouble());
            Console.WriteLine($"Fighter position has change to [{positionX},{positionY}]");
            _position = new Point(positionX, positionY);
        }

        public void Defended(IAttack attack)
        {
            var defenceDamage = 1 - _armor.GetArmor();
            HP -= attack.GetDamage() * defenceDamage;
            Console.WriteLine("Armor defend some of attack successfully");
            if (HP < 0) HP = 0;
            
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
            var weaponAttack = _weapon.GetAttack();
            var distance = Distance.GetDistance(defender.GetPosition(),_position);
            if (weaponAttack.GetRange() > distance)
            {
                Console.WriteLine("Fighter hit Monster");
                defender.Defended(weaponAttack);
            }
            else
            {
                Move(_position);
            }
        }

        
    }
}