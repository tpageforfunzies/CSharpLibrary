using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut jellyDonut = new Donut();

            jellyDonut.Filling = "Cherry Jelly";
            jellyDonut.Price = 7.99m;
            jellyDonut.Type = "Jelly";
            jellyDonut.IsSpecial = true;
        }
    }
}
