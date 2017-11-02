using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_QuizOne
{
    class Triangle : Shape
    {
        //Constructor
        public Triangle(int tBase, int tHeight)
        {
            this.Base = tBase;
            this.Height = tHeight;
        }

        //Properties
        public int Base { get; set; }
        public int Height { get; set; }
        public double TArea { get; set; }

        //Methods
        public override double Area()
        {
            
            TArea = (Base * Height * 0.5);
            return TArea;
        }
    }
}
