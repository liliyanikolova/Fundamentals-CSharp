namespace _4.ChampionsLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ChampionsLeagueMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^(\w[\w\s]*)\s\|\s(\w[\w\s]*)\s\|\s(\d+:\d+)\s\|\s(\d+:\d+)$";
            Regex regex = new Regex(pattern);

            Dictionary<string, SortedSet<string>> teamsByOponents = new Dictionary<string, SortedSet<string>>();
            Dictionary<string, int> temsByScores = new Dictionary<string, int>();
            while (input != "stop")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string team1 = match.Groups[1].Value.Trim();
                    string team2 = match.Groups[2].Value.Trim();
                    int[] firstScores = match.Groups[3].Value.Trim().Split(':').Select(int.Parse).ToArray();
                    int[] secondScores = match.Groups[4].Value.Trim().Split(':').Select(int.Parse).ToArray();
                    if (!teamsByOponents.ContainsKey(team1))
                    {
                        teamsByOponents[team1] = new SortedSet<string>();
                    }

                    if (!teamsByOponents.ContainsKey(team2))
                    {
                        teamsByOponents[team2] = new SortedSet<string>();
                    }

                    if (!teamsByOponents[team1].Contains(team2))
                    {
                        teamsByOponents[team1].Add(team2);
                    }

                    if (!teamsByOponents[team2].Contains(team1))
                    {
                        teamsByOponents[team2].Add(team1);
                    }

                    if (!temsByScores.ContainsKey(team1))
                    {
                        temsByScores[team1] = 0;
                    }

                    if (!temsByScores.ContainsKey(team2))
                    {
                        temsByScores[team2] = 0;
                    }

                    int firstTeamtScore = firstScores[0] + secondScores[1];
                    int secondTeamScore = firstScores[1] + secondScores[0];
                    if (firstTeamtScore > secondTeamScore)
                    {
                        temsByScores[team1]++;
                    }
                    else if (secondTeamScore > firstTeamtScore)
                    {
                        temsByScores[team2]++;
                    }
                    else
                    {
                        if (firstScores[1] > secondScores[1])
                        {
                            temsByScores[team2]++;
                        }
                        else
                        {
                            temsByScores[team1]++;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var team in temsByScores.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine(team.Key);
                Console.WriteLine("- Wins: {0}", team.Value);
                Console.WriteLine("- Opponents: {0}", string.Join(", ", teamsByOponents[team.Key]));
            }
        }
    }
}
