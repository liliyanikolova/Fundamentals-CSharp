namespace _3.ShmoogleCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ShmoogleCounter
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string pattern = @"(int|double)\s([a-z]\w*)";
            Regex regex = new Regex(pattern);

            List<string> intFields = new List<string>();
            List<string> doubleFields = new List<string>();
            while (!inputText.Equals("//END_OF_CODE"))
            {
                MatchCollection matches = regex.Matches(inputText);
                foreach (Match match in matches)
                {
                    if (match.Success && match.Groups[1].ToString() == "int")
                    {
                        intFields.Add(match.Groups[2].ToString());
                    }

                    if (match.Success && match.Groups[1].ToString() == "double")
                    {
                        doubleFields.Add(match.Groups[2].ToString());
                    }
                }

                inputText = Console.ReadLine();
            }

            if (doubleFields.Count != 0)
            {
                Console.WriteLine("Doubles: {0}", string.Join(", ", doubleFields.OrderBy(t => t)));
            }
            else
            {
                Console.WriteLine("Doubles: None");
            }

            if (intFields.Count != 0)
            {
                Console.WriteLine("Ints: {0}", string.Join(", ", intFields.OrderBy(t => t)));
            }
            else
            {
                Console.WriteLine("Ints: None");
            }
        }
    }
}
