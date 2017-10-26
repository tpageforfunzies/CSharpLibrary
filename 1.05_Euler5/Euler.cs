using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._05_Euler5
{
    class Euler
    {
        public static int SmallestMultiple()
        {
            //starting the number we're checking at 1
            int number = 1;
            //will loop through all of the divisors up to 20
            for (int i = 1; i <= 20; i++)
            {
                //if the number is not evenly divisible, increment number and start over
                if (number % i != 0)
                {
                    //increment the number up by one
                    number++;
                    //reset the index, restarting the for loop
                    i = 1;
                }
            }
            return number;
        }
    }
}
