namespace _3.RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuitMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\D+)(\d+)";

            string inputText = input.ToUpper();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputText);
            
            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
                for (int i = 0; i < int.Parse(match.Groups[2].ToString()); i++)
                {
                    result.Append(match.Groups[1]);
                }
            }

            Console.WriteLine("Unique symbols used: {0}", result.ToString().Distinct().Count());
            Console.WriteLine(result.ToString());
        }
    }
}
