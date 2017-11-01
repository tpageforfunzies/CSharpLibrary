using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Interfaces
{

    public interface IInterface
    {
        //cannot have fields/variables, uncommenting below will throw errors

        //public string id = 1;
        //public string title = "The King";
        //public string name = "Taylor";

        //it can only have the signatures
        String ID { get; set; }
        String Title { get; set; }
        String Name { get; set; }

        //cannot have any implementation
        //cannot have access modifiers
        //all are assumed public
        //cannot have virtual methods

        //must implement every method/props from the interface

        String Update();
        String Add();
        String Delete();
        String Search();
        String CalculateWage();


    }
}
