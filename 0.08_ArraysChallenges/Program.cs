using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ArraysChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //------BRONZE------
            //initialize an array of your favorite 3 foods, log to console
            Console.WriteLine("------BRONZE------");
            string[] foods = {"Spaghetti", "Pizza", "Pho"};
            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }
            Console.WriteLine("");

            //------SILVER------
            //create two arrays of integers length 5 and create a new array
            //whose values are the sums of the first two arrays
            Console.WriteLine("------SILVER------");
            int[] numsOne = {1, 2, 3, 4, 5};
            int[] numsTwo = {6, 7, 8, 9, 10};
            int[] numsThree = new int[5];
            for (int i = 0; i < numsOne.Length; i++)
            {
                numsThree[i] = numsOne[i] + numsTwo[i];
                Console.WriteLine(numsThree[i]);
            }
            Console.WriteLine("");
            


            //------GOLD------
            //create an array of 10 random numbers
            Console.WriteLine("------GOLD------");
            Random rand = new Random();
            int[] randNums = new int[10];
            for (int i = 0; i < randNums.Length; i++)
            {
                randNums[i] = rand.Next(0, 100);
                Console.WriteLine(randNums[i]);
            }
        }
    }
}
