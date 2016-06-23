namespace _3.SoftuniNumerals
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Numerics;

    public class SoftuniNumeralsMain
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string pattern = @"(aa|aba|bcc|cc|cdc)";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputText);

            StringBuilder convertedText = new StringBuilder();
            foreach (Match match in matches)
            {
                switch (match.Value)
                {
                    case "aa":
                        convertedText.Append("0");
                        break;
                    case "aba":
                        convertedText.Append("1");
                        break;
                    case "bcc":
                        convertedText.Append("2");
                        break;
                    case "cc":
                        convertedText.Append("3");
                        break;
                    case "cdc":
                        convertedText.Append("4");
                        break;
                }
            }

            string numsIn5Dim = convertedText.ToString();

            BigInteger result = 0;
            int pow = 0;
            for (int i = numsIn5Dim.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(numsIn5Dim.Substring(i, 1));
                result += (BigInteger)digit * BigInteger.Pow(5, pow);
                pow++;
            }

            Console.WriteLine(result);
        }
    }
}
