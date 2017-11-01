using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new array of instructors
            string[] instructors = { "Jay", "Paul", "Kenn", "Dave", "Auri" };

            // Set up the query
            IEnumerable<string> query = from i in instructors
                                        where i.Length == 4
                                        select i;

            // Loop through the array using the query
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }

            // Example 2
            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {ID=1, Name="Johnboy", HireDate = new DateTime(2015,3,5)},
                new Employee {ID=1, Name="Rolph", HireDate = new DateTime(1905,4,4)},
                new Employee {ID=1, Name="Ke$ha", HireDate = new DateTime(2015,3,5)},
                new Employee {ID=1, Name="Balake", HireDate = new DateTime(2005,9,5)},
                new Employee {ID=1, Name="Oldman Jenkins", HireDate = new DateTime(2005,3,5)}
            };

            var query2 = from e in employees
                        where e.HireDate.Year == 2005
                        select e;

            foreach (var employee in query2)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
