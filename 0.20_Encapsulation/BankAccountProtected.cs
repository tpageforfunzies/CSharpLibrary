using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_Encapsulation
{
    public class BankAccountProtected
    {
        public void CloseAccount()
        {
            ApplyLateCharges();
            CalculateInterest();
        }

        protected virtual void ApplyLateCharges()
        {
            Console.WriteLine("Apply late charges ran.");
        }

        protected virtual void CalculateInterest()
        {
            Console.WriteLine("Calculate interest ran.");
        }
    }
}
