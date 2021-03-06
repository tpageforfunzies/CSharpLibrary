﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Netflix
    {
        //Properties
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        //Method
        public string GetSuggestion()
        {
            string good = "You should definitely watch this show.";
            string decent = "It's a pretty good show.";
            string bad = "You probably don't want to watch this show.";
            if (this.Rating >= 4)
            {
                return good;
            }
            else if (this.Rating > 1 && this.Rating < 4)
            {
                return decent;
            }
            else
            {
                return bad;
            }
        }
    }
}
