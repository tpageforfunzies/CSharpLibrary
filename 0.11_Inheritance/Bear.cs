using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    class Bear : Animal
    {
        public Bear()
        {
            Habitat = "Cave";
            NumberOfLegs = 4;
            HasFur = true;
            HasWings = false;
            CanFly = false;
        }

        public override void StateType()
        {
            Console.WriteLine("I am a bear.");
        }

        public virtual void EatHiker()
        {
            Console.WriteLine("I just ate a hiker.");
        }

        public override void GetMad()
        {
            Console.WriteLine("RAAWRR IM A BIG SCARY BEAR");
        }
    }
}
