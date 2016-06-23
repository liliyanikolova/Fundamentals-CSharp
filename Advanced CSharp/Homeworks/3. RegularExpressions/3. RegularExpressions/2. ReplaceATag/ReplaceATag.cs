namespace _2.ReplaceATag
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ReplaceATag
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace("\"", string.Empty);

            string pattern = @"(\s*)(<a)\s+(href=http[s]{0,1}:\/\/[a-z\-]*(\.[a-z]+)+)(>)([\w]+)(<\/a>)";
            
            Regex regex = new Regex(pattern);

            StringBuilder text = new StringBuilder();
            while (!string.IsNullOrEmpty(input))
            {
                Match matches = regex.Match(input);
                if (matches.Success)
                {
                    string temp = string.Empty;
                    temp += matches.Groups[1] + "[URL " + matches.Groups[3] + "]" + matches.Groups[6] + "[/URL]";
                    input = temp;
                }

                text.AppendLine(input);
                input = Console.ReadLine().Replace("\"", string.Empty);
            }

            Console.WriteLine(text.ToString());
        }
    }
}
