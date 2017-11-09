using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21_TryCatch
{
    public class Age
    {
        public int ObjectAge = 0;
        public void ShowAge()
        {
            if (ObjectAge >= 115)
            {
                //creates an instance of the AgeException class and the constructor accepts the message
                throw (new AgeException("Human's don't usually live that long bro."));
            }

            else
            {
                Console.WriteLine("{0} years old.", ObjectAge);
            }
        }
    }
}
