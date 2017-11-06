using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_FantasyRPG
{
    class Demon : Enemy
    {
        public Demon()
        {
            DodgeChance = 0.2;
            Level = 5;
            AttackPower = 11;
            Name = "Demon";
            HitPoints = 42;
            Experience = 5;
            //UGLY ASS ASCII ART, GOD FORGIVE ME FOR THIS
            Art = "\nDEMON PICTURE GOES HERE";
        }
    }
}
