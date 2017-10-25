using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 253; //range: 0 - 255

            int number1 = 15;

            float myFloat = 3.14f; //f explicitly casts to float

            decimal myDecimal = 3.14159m; //m explicitly casts to decimal

            double myDouble = 2.54;

            char myLetter = 'A';

            string myName = "Taylor";

            bool myBool = true; //takes 1 byte, either 1(true) or 0(false)

            //Declaration
            //<type> <variableName> = <optional initializer/value>;
            int age;
            string country;
            //Initialization
            //On the right of the equal sign
            age = 25;
            country = "United States of America";




        }
    }
}
