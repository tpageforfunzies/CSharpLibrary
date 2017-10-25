using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_ForLoopsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //------BRONZE------
            //Create a for loop that prints 0-5 into the console
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            //------SILVER------
            //Create a while loop that prints 0-100 by 5s
            int counter = 0;
            while (counter <= 100)
            {
                Console.WriteLine(counter);
                counter += 5;
            }
            Console.WriteLine("");

            //------GOLD------
            //fizzbuzz
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine(i + " FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            //------PLATINUM------
            //sum of even numbers in fibonacci sequence
            int firstNum = 1;
            int secondNum = 2;
            int temp;
            int total = 2;

            while (secondNum <= 4000000)
            {
                temp = firstNum + secondNum;
                if (temp % 2 == 0)
                {
                    total += temp;
                }
                firstNum = secondNum;
                secondNum = temp;               
            }
            Console.WriteLine(total);
            



        }
    }
}
