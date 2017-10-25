using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Taylor";

            switch (friend)
            {
                case "Taylor":
                    Console.WriteLine("WHAT UP THO.");
                    break;
                case "Paul":
                    Console.WriteLine("Paul is pretty cool too.");
                    break;
                case "Kenn":
                    Console.WriteLine("Silent master Kenn . . .");
                    break;
                default:
                    Console.WriteLine("I don't know you");
                    break;
            }
        }
    }
}
