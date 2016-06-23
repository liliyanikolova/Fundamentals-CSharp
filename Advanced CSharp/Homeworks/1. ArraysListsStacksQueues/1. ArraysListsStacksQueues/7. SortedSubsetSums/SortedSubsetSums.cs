namespace _7.SortedSubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortedSubsetSums
    {
        public static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int[] inputArray = input.Split().Select(int.Parse).ToArray();
            List<int> inputNums = new List<int>();
            foreach (var num in inputArray)
            {
                if (!inputNums.Contains(num))
                {
                    inputNums.Add(num);
                }
            }

            int targetSubsetsCount = 0;
            int combinations = (int)Math.Pow(2, inputNums.Count);
            List<string> subsets = new List<string>();

            for (int i = 0; i < combinations; i++)
            {
                int sum = 0;
                List<int> subset = new List<int>();
                for (int j = 0; j < inputNums.Count; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = mask & i;
                    int bit = iAndMask >> j;

                    if (bit == 1)
                    {
                        subset.Add(inputArray[j]);
                        sum += inputArray[j];
                    }
                }

                if (sum == targetSum && subset.Count != 0)
                {

                    string subsetString = string.Join(" + ", subset.OrderBy(num => num)) + string.Format(" = {0}", targetSum);
                    subsets.Add(subsetString);
                    targetSubsetsCount++;
                }
            }

            if (targetSubsetsCount == 0)
            {
                Console.WriteLine("No matching subsets.");
                return;
            }

            Console.WriteLine(string.Join("\n", subsets.OrderBy(s => s.Length).ThenBy(s => s)));
        }
    }
}
