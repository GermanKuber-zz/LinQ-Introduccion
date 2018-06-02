using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var developers = new List<Employee>
            {
                new Employee { Id = 1, Name= "Dario" },
                new Employee { Id = 2, Name= "Federico" },
                new Employee { Id = 2, Name= "Valentina" },
                new Employee { Id = 2, Name= "Ailin" }
            };



            var query = developers.Where(e => e.Name.Length <= 5)
                                  .OrderBy(e => e.Name);



            var query2 = from developer in developers
                         where developer.Name.Length <= 5
                         orderby developer.Name
                         select developer;


            //query.ToList().ForEach(employee=> WriteLine(employee.Name));

            ReadKey();
        }
    }
}
