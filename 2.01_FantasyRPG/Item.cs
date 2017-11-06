using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_FantasyRPG
{
    abstract class Item
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public double DodgeChance { get; set; }
        public double CriticalChance { get; set; }
        public string Name { get; set; }

        public void Announce()
        {
            Console.WriteLine($"The enemy dropped a {Name}!");
            Console.WriteLine("Your stats have improved!");
        }

        public void AddStats(Player player)
        {
            player.AttackPower += Attack;
            player.Defense += Defense;
            player.DodgeChance += DodgeChance;
            player.CriticalChance += CriticalChance;
        }
    }
}
