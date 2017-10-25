using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_ConditionalsPairCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Oh god, how can I help?");
                    break;
                case "2":
                    Console.WriteLine("Hang in there!");
                    break;
                case "3":
                    Console.WriteLine("Atleast you're not bad.");
                    break;
                case "4":
                    Console.WriteLine("That's pretty good!");
                    break;
                case "5":
                    Console.WriteLine("Glad to hear you are doing so well!");
                    break;
                default:
                    Console.WriteLine("That wasn't an option, bro.");
                    break;
            }

        }
    }
}
