using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21_TryCatch
{
    //inherits from the regular Exception class
    public class AgeException : Exception
    {
        //constructor that defines the message for your custom exception
        public AgeException(string message) : base(message)
        {

        }

    }
}
