using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_FantasyRPG
{
    class Dragon : Enemy
    {
        public Dragon()
        {
            DodgeChance = 0.2;
            Level = 5;
            AttackPower = 10;
            Name = "Dragon";
            HitPoints = 35;
            Experience = 5;
            //UGLY ASS ASCII ART, GOD FORGIVE ME FOR THIS
            Art = "DRAGON PICTURE GOES HERE";

        }
    }
}
