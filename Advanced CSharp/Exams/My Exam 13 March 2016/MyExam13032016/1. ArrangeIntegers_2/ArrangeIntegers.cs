namespace _1.ArrangeIntegers_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ArrangeIntegers
    {
        public static void Main(string[] args)
        {
            List<string> inputNumbers =
                Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            List<string> wordNums = new List<string>();
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

                wordNums.Add(currentNum.ToString());
            }

            wordNums.Sort();
            List<string> output = new List<string>();
            foreach (var num in wordNums)
            {
                List<string> currentNum = num.Trim('-').Split('-').ToList();
                StringBuilder resultNum = new StringBuilder();
                foreach (var s in currentNum)
                {
                    switch (s)
                    {
                        case "zero":
                            resultNum.Append(0);
                            break;
                        case "one":
                            resultNum.Append(1);
                            break;
                        case "two":
                            resultNum.Append(2);
                            break;
                        case "three":
                            resultNum.Append(3);
                            break;
                        case "four":
                            resultNum.Append(4);
                            break;
                        case "five":
                            resultNum.Append(5);
                            break;
                        case "six":
                            resultNum.Append(6);
                            break;
                        case "seven":
                            resultNum.Append(7);
                            break;
                        case "eight":
                            resultNum.Append(8);
                            break;
                        case "nine":
                            resultNum.Append(9);
                            break;
                    }
                }

                output.Add(resultNum.ToString());
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
