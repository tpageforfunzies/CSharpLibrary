using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Netflix
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }

        public string GetSuggestion()
        {
            string good = "You should definitely watch this show.";
            string bad = "You probably don't want to watch this show.";
            if (this.Rating >= 4)
                {
                    return good;
                }
                else
                {
                    return bad;
                }
            }
        }
}
