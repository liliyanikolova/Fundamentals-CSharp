namespace _3.LargerThanNeighbours
{
    using System;

    public class LargerThanNeighboursMain
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }

        public static bool IsLargerThanNeighbours(int[] numbers, int possition)
        {
            bool isLargerThanLeft = true;
            if (possition > 0)
            {
                isLargerThanLeft = numbers[possition] > numbers[possition - 1];
            }

            bool isLargerThanRight = true;
            if (possition < numbers.Length - 1)
            {
                isLargerThanRight = numbers[possition] > numbers[possition + 1];
            }

            if (isLargerThanRight && isLargerThanLeft)
            {
                return true;
            }

            return false;
        }
    }
}
