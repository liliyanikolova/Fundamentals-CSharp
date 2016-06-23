namespace _5.LongestIncreasingSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestIncreasingSequenceMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] inputArray = input.Split().Select(int.Parse).ToArray();
            
            List<int> longestSequence = new List<int> { inputArray[0] };
            List<int> currentSequence = new List<int> { inputArray[0] };
            Console.Write("{0}", inputArray[0]);
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] < inputArray[i + 1])
                {
                    Console.Write(" {0}", inputArray[i + 1]);
                    currentSequence.Add(inputArray[i + 1]);
                }
                else
                {
                    Console.WriteLine();
                    Console.Write(inputArray[i + 1]);
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence.Clear();
                        longestSequence.AddRange(currentSequence);
                    }

                    currentSequence.Clear();
                    currentSequence.Add(inputArray[i + 1]);
                }
            }

            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence.Clear();
                longestSequence.AddRange(currentSequence);
            }

            Console.WriteLine();
            Console.WriteLine("Longest: {0}", string.Join(" ", longestSequence));
        }
    }
}
