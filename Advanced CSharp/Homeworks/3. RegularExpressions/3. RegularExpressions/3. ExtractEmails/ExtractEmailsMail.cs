namespace _3.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmailsMail
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"[\w]+[\.\-]*[\w]+\@[a-z\-]+(\.[a-z]+)+";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
