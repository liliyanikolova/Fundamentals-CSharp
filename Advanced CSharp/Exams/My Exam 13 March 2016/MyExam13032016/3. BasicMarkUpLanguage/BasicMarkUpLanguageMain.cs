namespace _3.BasicMarkUpLanguage
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class BasicMarkUpLanguageMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"^\s*<\s*([a-z]+)\s+([a-z]+\s*=\s*\""\s*(\d+)\s*\"")*\s*([a-z]+\s*=\s*)\""(.*)\""\s*\/\s*>\s*$";
            Regex regex = new Regex(pattern);

            int currentRow = 1;
            while (!input.Contains("stop"))
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    char[] chars;
                    switch (match.Groups[1].Value)
                    {
                        case "inverse":
                            StringBuilder inversedText = new StringBuilder();
                            chars = match.Groups[5].Value.ToCharArray();
                            foreach (char c in chars)
                            {
                                if (char.IsLetter(c))
                                {
                                    if (char.IsLower(c))
                                    {
                                        inversedText.Append(char.ToUpper(c));
                                    }
                                    else
                                    {
                                        inversedText.Append(char.ToLower(c));
                                    }
                                }
                                else
                                {
                                    inversedText.Append(c);
                                }
                            }

                            Console.WriteLine("{0}. {1}", currentRow, inversedText);
                            break;
                        case "reverse":
                            StringBuilder reversedText = new StringBuilder();
                            chars = match.Groups[5].Value.ToCharArray();
                            for (int i = chars.Length - 1; i >= 0; i--)
                            {
                                reversedText.Append(chars[i]);
                            }

                            Console.WriteLine("{0}. {1}", currentRow, reversedText);
                            break;
                        case "repeat":
                            int repeaterCount = int.Parse(match.Groups[3].Value);
                            for (int i = 0; i < repeaterCount; i++)
                            {
                                Console.WriteLine("{0}. {1}", currentRow, match.Groups[5].Value);
                                currentRow++;
                            }
                            currentRow--;
                            break;
                    }

                }

                currentRow++;
                input = Console.ReadLine();
            }
        }
    }
}
