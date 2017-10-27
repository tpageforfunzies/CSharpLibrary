using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using full constructor
            Student taylorOne = new Student("Taylor", "Page", 25, 9000);

            //Using empty constructor
            Student taylorTwo = new Student();
            taylorTwo.FirstName = "Taylor";
            taylorTwo.LastName = "Page";
            taylorTwo.Age = 25;
            taylorTwo.Grade = 9000;
        }
    }
}
