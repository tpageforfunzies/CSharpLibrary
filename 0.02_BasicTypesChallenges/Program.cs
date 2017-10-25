using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //------CHALLENGES------
            //------BRONZE------
            //Create a list of value types, two of each with one 
            //being a declaration and one being both a declaration and an initialization
            int int1;
            int int2 = 1;
            string string1;
            string string2 = "Taylor";
            bool bool1;
            bool bool2 = false;
            float float1;
            float float2 = 3.14f;
            double double1;
            double double2 = 3.14;
            decimal decimal1;
            decimal decimal2 = 3.14m;

            //------SILVER------
            //Concatenate a string from the types above
            string concat = string2 + " is my name and pi is " + float2 + ".";
            Console.WriteLine(concat);

            //------GOLD------
            //Declare year you were born as a string, convert it to an int and 
            //print it with a message to the console
            string birthYear = "1991";
            int yearOfBirth = Int32.Parse(birthYear);
            Console.WriteLine("I was born in " + yearOfBirth + ".");
        }
    }
}
