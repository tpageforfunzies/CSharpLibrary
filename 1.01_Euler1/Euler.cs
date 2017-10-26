using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._01_Euler1
{
    class Euler
    {
        public static int MultiplesSum(int limit)
        {
            //initialize sum at 0
            int sum = 0;

            //loops through every number up to the limit passed
            for (int i = 0; i < limit; i++)
            {
                //if i is multiple of 3 or 5, add it to the sum
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }

            return sum;

        }
    }
}
