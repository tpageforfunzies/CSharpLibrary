using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._02_Euler2
{
    class Euler
    {
        public static int FibSumEvens()
        {
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
            return total;
        }
    }
}
