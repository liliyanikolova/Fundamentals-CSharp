namespace MyExam13032016
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ArrangeIntegersMain
    {
        public static void Main(string[] args)
        {
            List<string> inputNumbers =
                Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            Dictionary<string, string> wordNums = new Dictionary<string, string>();
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                StringBuilder currentNum = new StringBuilder();
                for (int j = 0; j < inputNumbers[i].Length; j++)
                {
                    switch (inputNumbers[i][j])
                    {
                        case '0':
                            currentNum.Append("zero-");
                            break;
                        case '1':
                            currentNum.Append("one-");
                            break;
                        case '2':
                            currentNum.Append("two-");
                            break;
                        case '3':
                            currentNum.Append("three-");
                            break;
                        case '4':
                            currentNum.Append("four-");
                            break;
                        case '5':
                            currentNum.Append("five-");
                            break;
                        case '6':
                            currentNum.Append("six-");
                            break;
                        case '7':
                            currentNum.Append("seven-");
                            break;
                        case '8':
                            currentNum.Append("eight-");
                            break;
                        case '9':
                            currentNum.Append("nine-");
                            break;
                    }
                }

                wordNums[inputNumbers[i]] = currentNum.ToString();
            }



            List<string> output = wordNums.OrderBy(s => s.Value).Select(num => num.Key).ToList();
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
