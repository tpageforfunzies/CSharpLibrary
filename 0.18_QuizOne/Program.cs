using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_QuizOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangleOne = new Triangle(1, 2);
            Triangle triangleTwo = new Triangle(9, 1);
            Triangle triangleThree = new Triangle(4, 7);
            Triangle triangleFour = new Triangle(2, 2);
            Triangle triangleFive = new Triangle(7, 5);

            Console.WriteLine(triangleTwo.Area());
        }
    }
}
