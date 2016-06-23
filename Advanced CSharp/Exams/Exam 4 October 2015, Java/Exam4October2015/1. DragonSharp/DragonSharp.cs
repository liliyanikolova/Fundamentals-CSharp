namespace _1.DragonSharp
{
    using System;
    using System.Text.RegularExpressions;

    public class DragonSharp
    {
        public static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            string pattern1 = @"if\s\(([\d=<>!]+)\)\sout\s\""([\w+\s]+)+\"";";
            string pattern2 = @"if\s([\d=<>!\(\)]+)\sloop\s(\d)\sout\s\""([\w+\s]+)+\"";";
            string pattern3 = @"else\sloop\s(\d)\sout\s\""([\w+\s]+)+\"";";
            string pattern4 = @"else\sout\s\""([\w+\s]+)+\"";";

            Regex regexIf1 = new Regex(pattern1);
            Regex regexIf2 = new Regex(pattern2);
            Regex regexElse1 = new Regex(pattern3);
            Regex regexElse2 = new Regex(pattern4);

            string lastStatementValueForPrint = String.Empty;
            for (int i = 0; i < commandsCount; i++)
            {
                string inputStatement = Console.ReadLine();
                //if (!(inputStatement.Substring(inputStatement.Length - 2, 1) == ";" && inputStatement.Contains("\"")))
                //{
                //    Console.WriteLine("Compile time error @ line {0}", i + 1);
                //    continue;
                //}

                Match matchesIf1 = regexIf1.Match(inputStatement);
                Match matchesIf2 = regexIf2.Match(inputStatement);
                Match matchesElse1 = regexElse1.Match(inputStatement);
                Match matchesElse2 = regexElse2.Match(inputStatement);

                if (matchesIf1.Success)
                {
                    if (bool.Parse(matchesIf1.Groups[1].Value))
                    {
                        
                    }
                    //Console.WriteLine(matchesIf1.Groups[2].Value);
                    //lastStatementValueForPrint = 
                    //continue;
                }
            }
        }
    }
}
