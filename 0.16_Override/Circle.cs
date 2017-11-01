using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Override
{
    class Circle : Shape
    {
        //Constructor
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        //Property
        public double Radius { get; set; }

        //Method
        public override double Area()
        {
            return (Math.PI * Radius * Radius);
        }
    }
}
