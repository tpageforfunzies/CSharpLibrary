using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notice we have the potential for invalid conditions. Ugh.

            ElevenFiftyEmployee paul = new ElevenFiftyEmployee();
            paul.Id = 10;
            paul.Name = "Paul O'Connor";
            paul.CompanyName = "Eleven Fifty";

            Console.WriteLine("{0} {1} {2}", paul.Id, paul.Name, paul.CompanyName);

            //no getter/setters
            paul.CommonWorkQuote = "Somebody's got a case of the Mondays";
            Console.WriteLine(paul.CommonWorkQuote);

            //using getters/setters
            paul.SetCommonWorkQuote("Test");
            Console.WriteLine(paul.GetQuote());
            
        }
    }
}
