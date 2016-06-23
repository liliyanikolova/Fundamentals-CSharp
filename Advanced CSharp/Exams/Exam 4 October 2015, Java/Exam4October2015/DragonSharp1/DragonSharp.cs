namespace DragonSharp1
{
    using System;
    using System.Text.RegularExpressions;

    public class DragonSharp
    {
        private static bool isConditionTrue = true;

        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            string pattern = @".*\s"".+"";";

            Regex regex = new Regex(pattern);

            for (int i = 0; i < numberOfLines; i++)
            {
                string line = Console.ReadLine();

                Match match = regex.Match(line);

                if (match.Success)
                {
                    string validInput = match.Value;
                    string statement = validInput.Substring(0, validInput.IndexOf(' '));
                    if (statement == "if")
                    {
                        ProceedInput(validInput);
                        continue;
                    }

                    if (isConditionTrue)
                    {
                        continue;
                    }

                    ProceedInput(validInput);
                }
                else
                {
                    Console.WriteLine("Compile time error @ line {0}", i + 1);
                }
            }
        }

        private static void ProceedInput(string input)
        {
            string message = input.Substring(input.IndexOf('"')).Trim(';', '"');
            string statement = input.Substring(0, input.IndexOf(' '));
            if (statement == "if")
            {
                string expression = input.Substring(input.IndexOf('(') + 1, input.IndexOf(')') - input.IndexOf('(') - 1);
                if (expression.Contains("=="))
                {
                    int firstNumber = int.Parse(expression.Substring(0, expression.IndexOf("==")));
                    int secondNumber = int.Parse(expression.Substring(expression.IndexOf("==") + 2));
                    if (firstNumber != secondNumber)
                    {
                        isConditionTrue = false;
                        return;
                    }
                }

                if (expression.Contains("<"))
                {
                    int firstNumber = int.Parse(expression.Substring(0, expression.IndexOf("<")));
                    int secondNumber = int.Parse(expression.Substring(expression.IndexOf("<") + 1));
                    if (!(firstNumber < secondNumber))
                    {
                        isConditionTrue = false;
                        return;
                    }
                }

                if (expression.Contains(">"))
                {
                    int firstNumber = int.Parse(expression.Substring(0, expression.IndexOf(">")));
                    int secondNumber = int.Parse(expression.Substring(expression.IndexOf(">") + 1));
                    if (!(firstNumber > secondNumber))
                    {
                        isConditionTrue = false;
                        return;
                    }
                }

                if (isConditionTrue)
                {
                    string action = input.Split(' ')[2];
                    if (action == "loop")
                    {
                        int loopCount = int.Parse(input.Split(' ')[3]);
                        for (int i = 0; i < loopCount; i++)
                        {
                            Console.WriteLine(message);
                        }
                    }
                    else
                    {
                        Console.WriteLine(message);
                    }
                }
            }
            else
            {
                string action = input.Split(' ')[1];
                if (action == "loop")
                {
                    int loopCount = int.Parse(input.Split(' ')[2]);
                    for (int i = 0; i < loopCount; i++)
                    {
                        Console.WriteLine(message);
                    }
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
