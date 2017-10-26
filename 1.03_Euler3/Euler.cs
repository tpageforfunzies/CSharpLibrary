using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03_Euler3
{
    class Euler
    {
        public static void PrimeFactor(long n)
        {
            List<int> sList = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if ((n % i) == 0)
                {
                    long temp = 1;
                    temp = n / i;
                    sList.Add(i);
                    i = 1;
                    n = temp;
                }
            }
            string arr = string.Join(",", sList.ToArray());
            Console.Write(arr);
            Console.WriteLine(".");
            Console.WriteLine("The Biggest Prime number is: {0}", sList.Max());
        }
    }
}
