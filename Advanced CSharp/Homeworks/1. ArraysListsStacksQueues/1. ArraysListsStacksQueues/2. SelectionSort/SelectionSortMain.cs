namespace _2.SelectionSort
{
    using System;
    using System.Linq;

    public class SelectionSortMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] inputArray = input.Split().Select(int.Parse).ToArray();

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int temp = inputArray[i];
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[i])
                    {
                        inputArray[i] = inputArray[j];
                        inputArray[j] = temp;
                        temp = inputArray[i];
                    }
                }
            }
            
            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
