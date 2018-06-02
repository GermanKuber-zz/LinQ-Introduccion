using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using static System.Console;

namespace MultiplesSources
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


            listOfCountries.ToList().ForEach(country => WriteLine($"{country.Country} - {country.Area}"));

            ReadKey();
        }

        private static IEnumerable<CountrySelected> GetCountriesJson(string path)
        {
            using (StreamReader sr = new StreamReader(path))
                return JsonConvert.DeserializeObject<List<CountrySelected>>(sr.ReadToEnd());

        }

    }
}
