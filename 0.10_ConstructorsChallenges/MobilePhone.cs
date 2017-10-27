using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ConstructorsChallenges
{
    class MobilePhone
    {
        public MobilePhone(string name, string make, string model)
        {
            this.Name = name;
            this.Make = make;
            this.Model = model;

        }

        public string Name { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string Explain()
        {
            string output = $"{Name} has a {Make} {Model}. ";
            return output;
        }
    }
}
