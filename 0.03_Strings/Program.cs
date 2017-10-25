using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRING CONCATENATION
            string firstName;
            string lastName;
            string occupation;

            firstName = "Fred";
            lastName = "Rogers";
            occupation = "TV personality";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //STRING INTERPOLATION
            Console.WriteLine("Hello, my name is {0}.  I am a {1}.", fullName, occupation);
            Console.WriteLine($"Hello, my name is {fullName}.  I am a {occupation}.");
            string sentence = $"Hello, my name is {fullName}.  I am a {occupation}.";
            Console.WriteLine(sentence);
        }
    }
}
