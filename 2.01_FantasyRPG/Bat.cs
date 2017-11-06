using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_FantasyRPG
{
    class Bat : Enemy
    {
        public Bat()
        {
            DodgeChance = 0.2;
            Level = 1;
            AttackPower = 3;
            Name = "Bat";
            HitPoints = 10;
            Experience = 2;
            //UGLY ASS ASCII ART, GOD FORGIVE ME FOR THIS
            Art = "     " +
                  "            _..__.          .__.._\r\n       " +
                  "        .^\"-.._ \'-(\\__/)-\' _..-\"^.\r\n           " +
                  "           \'-.\' oo \'.-\'\r\n                      " +
                  "   `-..-\'     ";

        }
    }
}
