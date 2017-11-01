using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Square newSquare = new Square(4);

            Console.WriteLine(newSquare.Area());


            //Challenge:
            //Create a circle class, which inherits from Shape
            //and implement the Area() method

            Circle newCircle = new Circle(5);
            Console.WriteLine(newCircle.Area());
        }
    }
}
