using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    abstract class Animal
    {
        public string Habitat { get; set; }
        public int NumberOfLegs { get; set; }

        public bool HasFur { get; set; }
        public bool HasWings { get; set; }
        public bool CanFly { get; set; }

        public virtual void StateType()
        {
            Console.WriteLine("I am an animal.");
        }

        public virtual void GetMad()
        {
            Console.WriteLine("RRRRRROOOOOAAARRRRRR");
        }
    }
}
