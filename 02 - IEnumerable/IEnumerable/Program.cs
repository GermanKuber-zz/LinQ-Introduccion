using System;
using System.Collections.Generic;

namespace IEnumerable.Core
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

            Employee[] developersArray = new Employee[]
            {
                new Employee { Id = 1, Name= "Dario" },
                new Employee { Id = 2, Name= "Valentina" },
                new Employee { Id = 2, Name= "Ailin" }
            };




            //foreach (var employee in developersList)
            //    Console.WriteLine(employee.Name);


            //IEnumerator<Employee> enumerator = developersArray.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Name);
            //}

            Console.ReadKey();
        }
    }
}
