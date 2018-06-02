using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace ConcatQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfCountries = GetCountriesJson("Countries.json");

            var results = listOfCountries.OrderBy(x => x.Country)
                                           .ThenBy(x => x.Area)
                                            .Distinct()
                                            .GroupBy(x =>
                                                        x.Country.Substring(0, 1).ToUpper(),
                                                        (index, item) =>
                                                            new
                                                            {
                                                                Initial = index,
                                                                Results = item.OrderByDescending(o=> o.Area).Take(2)
                                                           });



            results.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Initial);
                x.Results.ToList().ForEach(country =>
                {
                    Console.WriteLine($"Country : {country.Country} - Area : {country.Area}");
                });
            });

            Console.ReadKey();
        }

        private static IEnumerable<CountrySelected> GetCountriesJson(string path)
        {
            using (StreamReader sr = new StreamReader(path))
                return JsonConvert.DeserializeObject<List<CountrySelected>>(sr.ReadToEnd());

        }

    }

}
