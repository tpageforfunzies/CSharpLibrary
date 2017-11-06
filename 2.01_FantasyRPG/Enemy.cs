using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_FantasyRPG
{
    abstract class Enemy
    {
        public double DodgeChance { get; set; }
        public int Level { get; set; }
        public int AttackPower { get; set; }
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int Experience { get; set; }
        public int DamageOut { get; set; }
        public string Art { get; set; }


        public void Attack(Player player)
        {
            Console.WriteLine($"\n{Name} attacks!");
            Console.WriteLine($"{Name} dealt {(AttackPower - player.Defense)} damage!");
            if ((AttackPower - player.Defense) <= 0)
            {
                Console.WriteLine("It couldn't pierce your armor!");
            }
            else
            {
                player.HitPoints -= (AttackPower - player.Defense);
            }

            if (HitPoints <= 0)
            {
                Console.WriteLine($"{player.Name} defeated the {Name}!");
            }
            else if (player.HitPoints <= 0)
            {
                Console.WriteLine($"The {Name} has defeated you.");
            }
            else
            {
                Console.WriteLine($"{player.Name} has {player.HitPoints} HP left.\n");

            }

        }

        public void Announce()
        {
            Console.WriteLine(Art);
            Console.WriteLine($"                   RAWRRRRRR IM A BIG SCARY {Name.ToUpper()}\n");
        }

        public void LevelUp(Player player)
        {
            Console.WriteLine("You have leveled up!");
            player.Level += 1;
            player.Stats();
        }
    }
}
