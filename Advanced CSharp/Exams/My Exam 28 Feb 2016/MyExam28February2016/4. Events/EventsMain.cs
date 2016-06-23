namespace _4.Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class EventsMain
    {
        private static DateTime eventTime;

        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            //string pattern = @"^#([a-zA-z]+):\s*@([A-Za-z]+)\s*(([01][0-9]|[2][0-3]):([0-5][0-9]))$";
            string pattern = @"^#([a-zA-z]+):\s*@([A-Za-z]+)\s*(\d+:\d+)$";
            Regex regex = new Regex(pattern);
            
            SortedDictionary<string, SortedDictionary<string, List<DateTime>>> eventsByTimeByPersonByLocation = new SortedDictionary<string, SortedDictionary<string, List<DateTime>>>();
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                if (match.Success  && IsValidDate(match.Groups[3].Value))
                {
                    string person = match.Groups[1].Value;
                    string location = match.Groups[2].Value;
                    DateTime time = eventTime;

                    if (!eventsByTimeByPersonByLocation.ContainsKey(location))
                    {
                        eventsByTimeByPersonByLocation[location] = new SortedDictionary<string, List<DateTime>>();
                    }

                    if (!eventsByTimeByPersonByLocation[location].ContainsKey(person))
                    {
                        eventsByTimeByPersonByLocation[location][person] = new List<DateTime> { time };
                        continue;
                    }

                    if (!eventsByTimeByPersonByLocation[location][person].Contains(time))
                    {
                        eventsByTimeByPersonByLocation[location][person].Add(time);
                    }
                }
            }

            string[] reportCriterias = Console.ReadLine().Split(',');
            foreach (var location in eventsByTimeByPersonByLocation)
            {
                if (reportCriterias.Contains(location.Key))
                {
                    Console.WriteLine("{0}:", location.Key);

                    int currentNum = 1;
                    foreach (var person in location.Value)
                    {
                        Console.Write("{0}. {1} -> {2}", currentNum, person.Key, string.Join(", ", person.Value.OrderBy(t => t)));

                        Console.WriteLine();
                        currentNum++;
                    }
                }
            }
        }

        private static bool IsValidDate(string d)
        {
            return DateTime.TryParse(d, out eventTime);
        }
    }
}
