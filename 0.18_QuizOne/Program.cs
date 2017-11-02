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
            // PART ONE: OVERRIDE
            //
            //Create an abstract class 'Shape'
            //that has an abstract method 'Area()'
            //
            //Create a class 'Triangle' that inherits
            //from Shape.
            //
            //'Triangle' should have a constructor that accepts
            //2 Parameters, TBase and THeight (as Int)
            //
            //Triangle should also have an Area property.
            //
            //Implement Area()
            //SIDENOTE: Area of Triangle = (1/2)*(Base)*(Height)
            //
            //Create 5 triangles, and use the Area() method
            //to set their Area property.

            Triangle triangleOne = new Triangle(1, 2);
            Triangle triangleTwo = new Triangle(9, 1);
            Triangle triangleThree = new Triangle(4, 7);
            Triangle triangleFour = new Triangle(2, 2);
            Triangle triangleFive = new Triangle(7, 5);

            triangleOne.Area();
            triangleTwo.Area();
            triangleThree.Area();
            triangleFour.Area();
            triangleFive.Area();

            //PART TWO: LINQ
            //
            //Create a List of Triangle Objects
            //
            //Using LINQ, set up a query that selects Triangles above
            //a certain area, and sorts them by ascending value
            //
            //Display the results of the query using a loop
            IEnumerable<Triangle> triangles = new List<Triangle>()
            {
                triangleOne,
                triangleTwo,
                triangleThree,
                triangleFour,
                triangleFive
            };

            IEnumerable<Triangle> query = from t in triangles
                                          where t.Area() > 2
                                          orderby t.Area() ascending
                                          select t;

            foreach (var i in query)
            {
                Console.WriteLine(i.Area());
            }
        }
    }
}
