namespace _3.InsertionSort
{
    using System;
    using System.Linq;

    public class InsertionSortMain
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] parsedNumbers = input.Select(int.Parse).ToArray();

            for (int i = 1; i < parsedNumbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (parsedNumbers[i] < parsedNumbers[j])
                    {
                        int temp = parsedNumbers[i];
                        parsedNumbers[i] = parsedNumbers[j];
                        parsedNumbers[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", parsedNumbers));
        }
    }
}
