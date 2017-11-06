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
            AttackPower = 5;
            Name = "Ogre";
            HitPoints = 20;
            Experience = 1;
            //UGLY ASS ASCII ART, GOD FORGIVE ME FOR THIS
            Art = "                          __,=\'`````\'=/__\r\n              " +
                  "            \'//  (o) \\(o) \\ `\'         _,-,\r\n       " +
                  "                   //|     ,_)   (`\\      ,-\'`_,-\\\r\n   " +
                  "                     ,-~~~\\  `\'===\'  /-,      \\==```` \\__\r\n  " +
                  "                     /        `----\'     `\\     \\       \\/\r\n  " +
                  "                  ,-`                  ,   \\  ,.-\\       \\\r\n         " +
                  "          /      ,               \\,-`\\`_,-`\\_,..--\'\\\r\n            " +
                  "      ,`    ,/,              ,>,   )     \\--`````\\\r\n              " +
                  "    (      `\\`---\'`  `-,-\'`_,<   \\      \\_,.--\'`\r\n            " +
                  "       `.      `--. _,-\'`_,-`  |    \\\r\n                 " +
                  "   [`-.___   <`_,-\'`------(    /\r\n                   " +
                  " (`` _,-\\   \\ --`````````|--`\r\n                   " +
                  "  >-`_,-`\\,-` ,          |\r\n                " +
                  "   <`_,\'     ,  /\\          /\r\n            " +
                  "        `  \\/\\,-/ `/  \\/`\\_/V\\_/\r\n       " +
                  "                (  ._. )    ( .__. )\r\n          " +
                  "             |      |    |      |\r\n             " +
                  "           \\,---_|    |_---./\r\n                " +
                  "        ooOO(_)    (_)OOoo";
        }
    }
}
