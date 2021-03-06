using System;
using System.Drawing;
using cSharpSelfLearn.BoxingGame.Combat.Armor;
using cSharpSelfLearn.BoxingGame.Combat.Attack;
using cSharpSelfLearn.BoxingGame.Combat.Attact;
using cSharpSelfLearn.BoxingGame.Combat.Fighter;
using cSharpSelfLearn.BoxingGame.Combat.Fighter.Property;
using cSharpSelfLearn.BoxingGame.Combat.Weapon;

namespace cSharpSelfLearn.BoxingGame.Combat.Services
{
    public class GameSimulatorV1
    {
        private const int RangeX = 40;
        private const int RangeY = 40;

        public static void Run()
        {
            var fighter = new Human(100, new ArmorEfficent(), new Sword(), new Point(RangeX,RangeY));
            var monster = new Monster(300, new IAttack[] { new Punch(),new RandomAttack() }, new Point(10,10));
            var round = 0;
            while (fighter.GetHitPoint() > 0 && monster.GetHitPoint() > 0 )
            {
                AnnounceRound(round);
                Fight(fighter,monster);
                ReportRound(fighter,monster);
                round++;
            }
            WinnerResult(fighter, monster);
            Console.WriteLine("Try again? (y/n)");
            var input = Console.ReadKey();
            if (input.KeyChar == 'y')
            {
                Console.WriteLine();
                Console.WriteLine();

                Run();  
            }

        }

        private static void WinnerResult(ICombatant fighter, ICombatant monster)
        {
            string winner;
            if (fighter.GetHitPoint() > monster.GetHitPoint())
            {
                winner = "Fighter ";
            }else
            {
                winner = "monster ";
            }
            Console.Write("The winner is: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(winner);
            Console.ResetColor();
        }
        
        
        private static void AnnounceRound(int round)
        {
            Console.WriteLine($"Round {round} is about to start.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }
        
        private static void Fight(Human fighter, Monster monster)
        {
            fighter.Attack(monster);
            monster.Attack(fighter);
        }
        
        private static void ReportRound(Human fighter, Monster monster)
        {
            if (fighter.GetHitPoint() > monster.GetHitPoint())
            {
                AnnounceWinning(fighter, nameof(fighter));
                Console.Write(", ");
                AnnounceLoosing(monster, nameof(monster));
            }
            else if (fighter.GetHitPoint() < monster.GetHitPoint())
            {
                AnnounceLoosing(fighter, nameof(fighter));
                Console.Write(", ");
                AnnounceWinning(monster, nameof(monster));
            }
            else
            {
                AnnounceDraw(fighter, monster);
            }
            Console.WriteLine();
        }

        private static void AnnounceDraw(Human fighter, Monster monster)
        {
            Console.Write($"Fighter: {fighter.GetHitPoint()} hp, ");
            Console.Write($"Monster: {monster.GetHitPoint()} hp.");
        }

        private static void AnnounceLoosing(ICombatant monster, string monsterName)
        {
            AnnounceInColoredHp(monster , monsterName , ConsoleColor.Red);
        }

        private static void AnnounceWinning(ICombatant fighter, string fighterName)
        {
            AnnounceInColoredHp(fighter,fighterName,ConsoleColor.Blue);
        }
        
        private static void AnnounceInColoredHp(ICombatant combatant, string name, ConsoleColor color)
        {
            Console.Write($"{name}: ");
            Console.ForegroundColor = color;
            Console.Write($"{combatant.GetHitPoint()} hp");
            Console.ResetColor();
        }
    }
}