namespace _1.SortArrayOfNumbers
{
    using System;
    using System.Linq;

    public class SortArrayOfNumbersMain
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int[] inputArray = input.Split().Select(int.Parse).ToArray();

            Array.Sort(inputArray);

            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
