using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Override
{
    class Square : Shape
    {
        //Constructor
        public Square(int length)
        {
            this.SideLength = length;
        }

        //Properties
        public int SideLength { get; set; }

        //Methods
        public override double Area()
        {
            return Math.Pow(SideLength, 2);
        }
    }
}
