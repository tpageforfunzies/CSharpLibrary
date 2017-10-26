using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_StringsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //------CHALLENGES------
            //------BRONZE------
            //Create examples that show techniques for basic string manipulation.  You'll need to show how to concatenate
            //multiple strings.  Using composite formatting, show how to use escapes, and how to manipulate
            //numbers
            Console.WriteLine("------BRONZE------");
            string name = "Taylor";
            int age = 25;
            string composite = $"{name} is the man.  \"He is very cool, how he is only {age} is a mystery they all say\".";
            Console.WriteLine(composite);
            Console.WriteLine("");


            //------SILVER------
            //Create a note to a potential employer that states your goals as a developer.
            //Create a potentialEmployerName variable and a date.  Includet he date in the string by 
            //creating a date string that is converted to a short date string
            Console.WriteLine("------SILVER------");
            string potentialEmployerName = "Google";
            DateTime today = DateTime.Today;
            Console.WriteLine("Dear {0}, today is {1} and I am enjoying my C# class " +
                "and one day hope to work for a Big 4 company like you.", potentialEmployerName, today.ToShortDateString());
            Console.WriteLine("");

            //------GOLD------
            //Create two strings: Your username in lowercase, and your username in uppercase
            //write code that compares the two strings and prints whether or not they are equal
            //print one sentence that says that they are equal.  Print another string that says they are not equal

            string lowerCase = "tjpage";
            string upperCase = "TJPAGE";
            Console.WriteLine("------GOLD------");

            Console.WriteLine("The Strings are equal when case is ignored? - {0}",
                        String.Compare(lowerCase, upperCase, true) == 0
                                       ? "yep" : "nope");
            Console.WriteLine("The Strings are equal when case is considered? - {0}",
                        String.Compare(lowerCase, upperCase, false) == 0
                                       ? "yep" : "nope");
            Console.WriteLine("");

        }
    }
}