namespace _1.SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfLettersMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([a-zA-Z]{1})\1*";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            string result = string.Empty;

            foreach (var match in matches)
            {
                result += match.ToString()[0];
            }

            Console.WriteLine(result);
        }
    }
}
