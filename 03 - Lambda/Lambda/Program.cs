using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda.Core
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Employee> developersList = new List<Employee>
            {
                new Employee { Id = 1, Name= "Dario" },
                new Employee { Id = 2, Name= "Valentina" },
                new Employee { Id = 2, Name= "Ailin" }
            };


            foreach (var item in developersList.Where(FilterEmployee))
            {

            }

            foreach (var item in developersList.Where(delegate (Employee employee)
            {
                return employee.Name.StartsWith("A");
            }))
            {

            }


            foreach (var item in developersList.Where(employee => employee.Name.StartsWith("A")))
            {

            }

            Console.ReadKey();
        }

        private static bool FilterEmployee(Employee employee)
        {
            return employee.Name.StartsWith("A");
        }
    }
}
