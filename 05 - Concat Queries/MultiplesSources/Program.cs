using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ConcatQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfCountries = GetCountriesJson("Countries.json");

            listOfCountries = listOfCountries.Where(country => country.Area > 200);

            listOfCountries = listOfCountries.Where(country => country.Country.StartsWith("A")
                                                               ||
                                                               country.Country.StartsWith("B"));

            //listOfCountries  = listOfCountries.GroupBy(x => x.Country);


            listOfCountries.ToList().ForEach(country => Console.WriteLine($"{country.Country} - {country.Area}"));

            Console.ReadKey();
        }

        private static IEnumerable<CountrySelected> GetCountriesJson(string path)
        {
            using (StreamReader sr = new StreamReader(path))
                return JsonConvert.DeserializeObject<List<CountrySelected>>(sr.ReadToEnd());

        }

    }
}
