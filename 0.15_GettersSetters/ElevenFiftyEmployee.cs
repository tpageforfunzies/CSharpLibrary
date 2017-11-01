using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_GettersSetters
{
    class ElevenFiftyEmployee
    {
        //fields, private fields start with underscore
        private int _id; //id cannot be negative
        private int _yearsExperience; //an employee has some experience
        private string _jobTitle;
        private string _employeeName; //name can't be null
        private string _commonWorkQuote;
        private string _company;

        //to deal with Id issue of not being negative, without a getter/setter it could be set negative
        //public int Id { get; set; }; becomes
        public int Id
        {
            set
            {
                //prevents it from being negative
                if (Id < 0)
                    throw new Exception("The Employee ID is not valid.");
                this._id = value;
            }
            //simply returns the value
            get { return _id; }
        }

        //similar problem for the employeeName field, cannot be null or whitespace so need to
        //verify before allowing it to be set
        public string Name
        {
            set
            {
                //prevents it from being null/empty/whitespace
                if (string.IsNullOrEmpty(value))
                    throw new Exception("The Employee Name is not valid");
                this._employeeName = value;
            }
            //simply returns the value
            get { return this._employeeName; }
        }

        //this example and the example below are functionally the same
        //this example is how it works under the hood using getter/setters
        public void SetCommonWorkQuote(string quote)
        {
            this._commonWorkQuote = quote;
        }

        public string GetQuote()
        {
            return this._commonWorkQuote;
        }

        //this is the syntatic sugar for the get/set process
        public string CommonWorkQuote
        {
            set
            {
                this._commonWorkQuote = value;
            }
            get
            {
                return this._commonWorkQuote;
            }
        }

        //use these if you don't have conditions to deal with
        //public string CommonWorkQuote { get; set; }
        public string CompanyName { get; set; }

        
    }
}
