using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._06_Euler6
{
    class Euler
    {
        public static int SumOfSquare(int num)
        {
            int total = 0;

            for (int i = 1; i <= num; i++)
            {
                total += (i * i);
            }

            return total;
        }

        public static int SquareOfSum(int num)
        {
            int total = 0;

            for (int i = 1; i <= num; i++)
            {
                total += i;
            }

            total = (total * total);

            return total;

        }

        public static int Difference(int num)
        {
            return (SquareOfSum(num) - SumOfSquare(num));
        }
    }
}
