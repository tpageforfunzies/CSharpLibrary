using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_FantasyRPG
{
    class Ogre : Enemy
    {
        public Ogre()
        {
            DodgeChance = 0.05;
            Level = 1;
            AttackPower = 2;
            Name = "OGRE";
            HitPoints = 20;
            Experience = 5;
        }
    }
}
