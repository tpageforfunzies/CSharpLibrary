using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear yogi = new Bear();
            yogi.StateType();
            yogi.GetMad();

            PandaBear panda = new PandaBear();
            panda.StateType();
            panda.GetMad();
        }
    }
}
