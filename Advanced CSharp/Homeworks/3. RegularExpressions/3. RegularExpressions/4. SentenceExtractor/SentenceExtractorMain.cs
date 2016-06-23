namespace _4.SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractorMain
    {
        public static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string input = Console.ReadLine();

            string pattern = @"[A-Z][\w\,\'\-\;\:\s]+\s" + keyWord + @"\s?[a-z\,\'\-\;\:\s]*[\.\?\!]";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
