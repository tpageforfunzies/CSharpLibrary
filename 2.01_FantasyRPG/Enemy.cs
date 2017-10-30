using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_FantasyRPG
{
    class Enemy
    {
        public double DodgeChance { get; set; }
        public int Level { get; set; }
        public int AttackPower { get; set; }
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int Experience { get; set; }
        public int DamageOut { get; set; }


        public void Attack()
        {
            Console.WriteLine($"{this.Name} dealt {this.AttackPower}\n");
            DamageOut = AttackPower;
        }

        public void Announce()
        {
            Console.WriteLine($"RAWRRRRRR IM A BIG SCARY {this.Name}\n");
        }
    }
}
