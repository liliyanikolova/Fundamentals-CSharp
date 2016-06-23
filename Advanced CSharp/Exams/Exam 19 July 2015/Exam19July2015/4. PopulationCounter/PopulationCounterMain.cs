namespace _4.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounterMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> populationByCitiesAndCountries = new Dictionary<string, Dictionary<string, long>>();
            while (input != "report")
            {
                string[] inputData = input.Split('|');
                string city = inputData[0];
                string country = inputData[1];
                int population = int.Parse(inputData[2]);
                if (!populationByCitiesAndCountries.ContainsKey(country))
                {
                    populationByCitiesAndCountries[country] = new Dictionary<string, long>();
                }

                if (!populationByCitiesAndCountries[country].ContainsKey(city))
                {
                    populationByCitiesAndCountries[country][city] = population;
                    input = Console.ReadLine();
                    continue;
                }

                populationByCitiesAndCountries[country][city] += population;

                input = Console.ReadLine();
            }

            foreach (var country in populationByCitiesAndCountries.OrderByDescending(k => k.Value.Values.Sum()))
            {
                long totalCountryPopulation = country.Value.Values.Sum();
                Console.WriteLine("{0} (total population: {1})", country.Key, totalCountryPopulation);
                foreach (var city in country.Value.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
