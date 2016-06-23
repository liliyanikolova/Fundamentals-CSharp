namespace _10.PythagoreanNumbers
{
    using System;
    using System.Collections.Generic;

    public class PythagoreanNumbers
    {
        public static void Main(string[] args)
        {
            int inputNumsCount = int.Parse(Console.ReadLine());

            List<int> inputNums = new List<int>();
            for (int i = 0; i < inputNumsCount; i++)
            {
                inputNums.Add(int.Parse(Console.ReadLine()));
            }

            inputNums.Sort();
            int printCombinationsCount = 0;
            for (int i = 0; i < inputNums.Count; i++)
            {
                for (int j = i; j < inputNums.Count; j++)
                {
                    for (int k = 0; k < inputNums.Count; k++)
                    {
                        if (inputNums[i] * inputNums[i] + inputNums[j] * inputNums[j] == inputNums[k] * inputNums[k])
                        {
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", inputNums[i], inputNums[j], inputNums[k]);
                            printCombinationsCount++;
                        }
                    }
                }
            }

            if (printCombinationsCount == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
