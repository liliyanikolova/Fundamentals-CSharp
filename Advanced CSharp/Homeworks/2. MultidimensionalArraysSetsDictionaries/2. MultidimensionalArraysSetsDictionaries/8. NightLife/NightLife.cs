namespace _8.NightLife
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NightLife
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, SortedDictionary<string, HashSet<string>>> performerByVenueByCity = 
                new Dictionary<string, SortedDictionary<string, HashSet<string>>>();

            while (input != "END")
            {
                string[] splitInput = input.Split(';');
                string city = splitInput[0];
                string venue = splitInput[1];
                string performer = splitInput[2];

                if (!performerByVenueByCity.ContainsKey(city))
                {
                    HashSet<string> performers = new HashSet<string> { performer };
                    SortedDictionary<string, HashSet<string>> performerByVenue =
                        new SortedDictionary<string, HashSet<string>> { { venue, performers } };
                    performerByVenueByCity.Add(city, performerByVenue);

                    input = Console.ReadLine();
                    continue;
                }

                if (!performerByVenueByCity[city].ContainsKey(venue))
                {
                    HashSet<string> performers = new HashSet<string> { performer };
                    performerByVenueByCity[city].Add(venue, performers);

                    input = Console.ReadLine();
                    continue;
                }

                performerByVenueByCity[city][venue].Add(performer);

                input = Console.ReadLine();
            }

            foreach (var city in performerByVenueByCity)
            {
                Console.WriteLine(city.Key);
                foreach (var venue in city.Value)
                {
                    string[] sortedPerformers = venue.Value.OrderBy(p => p).ToArray();
                    Console.WriteLine("->{0}: {1}", venue.Key, string.Join(", ", sortedPerformers));
                }
            }
        }
    }
}
