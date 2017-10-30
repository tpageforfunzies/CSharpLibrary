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
    }
}
