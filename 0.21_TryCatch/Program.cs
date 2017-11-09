using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Age ageInstance = new Age();
            ageInstance.ObjectAge = 200;
            try
            {
                ageInstance.ShowAge();
            }
            catch (AgeException exception)
            {
                Console.WriteLine("Age too high exception: {0}", exception.Message);
            }
        }
    }
}
