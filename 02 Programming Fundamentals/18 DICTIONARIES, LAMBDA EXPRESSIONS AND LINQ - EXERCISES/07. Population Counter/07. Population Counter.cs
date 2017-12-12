using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, double>> result = new Dictionary<string, SortedDictionary<string,double>>();

            string command = Console.ReadLine();

            while (command != "report")
            {
                AddToResult(command, result);

                command = Console.ReadLine();
            }

            var orderedCountries = result.OrderByDescending(c => c.Value.Values.Sum());
            foreach (var country in orderedCountries)
            {
                var orderedCities = country.Value.OrderByDescending(c => c.Value);
                Console.WriteLine("{0} (total population: {1})",country.Key,country.Value.Sum(x => x.Value));
                foreach (var city in orderedCities)
                {
                    Console.WriteLine("=>" + city.Key + ": " + city.Value);
                }
            }
        }

        private static void AddToResult(string command, Dictionary<string, SortedDictionary<string, double>> result)
        {
            List<string> lineData = command.Split('|').ToList();
            string city = lineData[0];
            string country = lineData[1];
            double populatuin = double.Parse(lineData[2]);

            if (result.ContainsKey(country))
            {
                if (result[country].ContainsKey(city))
                {
                    result[country][city] += populatuin;
                }
                else
                {
                    result[country].Add(city, populatuin);
                }
            }
            else
            {
                result.Add(country, new SortedDictionary<string, double> { { city, populatuin } });
            }
        }
    }
}
