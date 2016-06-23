namespace _4.Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class UnleashedMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"((\w+\s){1,3})@((\w+\s){1,3})(\d+)\s(\d+)";
            Regex regex = new Regex(pattern);

            Dictionary<string, Dictionary<string, ulong>> ticketsPriceBySingerByVenue = new Dictionary<string, Dictionary<string, ulong>>();
            while (input != "End")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string singer = match.Groups[1].ToString().Trim();
                    string venue = match.Groups[3].ToString().Trim();
                    int ticketPrice = int.Parse(match.Groups[5].ToString());
                    int ticketsCount = int.Parse(match.Groups[6].ToString());

                    if (!ticketsPriceBySingerByVenue.ContainsKey(venue))
                    {
                        ticketsPriceBySingerByVenue[venue] = new Dictionary<string, ulong>();
                    }

                    if (!ticketsPriceBySingerByVenue[venue].ContainsKey(singer))
                    {
                        ticketsPriceBySingerByVenue[venue][singer] = (ulong)(ticketPrice * ticketsCount);
                        input = Console.ReadLine();
                        continue;
                    }

                    ticketsPriceBySingerByVenue[venue][singer] += (ulong)(ticketPrice * ticketsCount);
                }

                input = Console.ReadLine();
            }

            foreach (var venue in ticketsPriceBySingerByVenue)
            {
                Console.WriteLine(venue.Key);
                foreach (var singer in venue.Value.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", singer.Key, singer.Value);
                }
            }
        }
    }
}
