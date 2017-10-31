using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    //can inherit from a subclass
    class PandaBear : Bear
    {
        public override void StateType()
        {
            Console.WriteLine("I am a panda bear.");
        }

        public override void EatHiker()
        {
            Console.WriteLine("No thanks, I'm good with my bamboo.");
        }

        public override void GetMad()
        {
            Console.WriteLine("MEEHHHHH IM A CHILL PANDA BEAR");
        }
    }
}
