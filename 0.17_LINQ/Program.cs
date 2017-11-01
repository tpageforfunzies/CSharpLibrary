using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new array of instructors
            string[] instructors = { "Jay", "Paul", "Kenn", "Dave", "Auri" };

            //Set up the query
            IEnumerable<string> query = from i in instructors
                                        where i.Length == 4
                                        select i;

            //Loop through the array in the query
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }




            //Creating a list of employee objects
            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {Id = 1, Name = "Johnboy", HireDate = new DateTime(2016, 3, 5)},
                new Employee {Id = 2, Name = "Susan", HireDate = new DateTime(2011, 6, 8)},
                new Employee {Id = 3, Name = "Rolf", HireDate = new DateTime(2008, 11, 11)},
                new Employee {Id = 4, Name = "Ed", HireDate = new DateTime(2016, 1, 6)},
                new Employee {Id = 5, Name = "Aaron", HireDate = new DateTime(2010, 2, 20)}
            };


            //Set up the query
            IEnumerable<Employee> queryTwo = from e in employees
                where e.HireDate.Year == 2016
                orderby e.Name ascending
                select e;

            Console.WriteLine("");
            //Loop through the array in the query
            foreach (var i in queryTwo)
            {
                Console.WriteLine(i.Name);
            }
            
        }
    }
}
