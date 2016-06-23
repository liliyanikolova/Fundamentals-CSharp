namespace _4.FirstLargerThanNeighbours
{
    using System;

    public class FirstLargerThanNeighboursMain
    {
        public static void Main(string[] args)
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        }

        public static int GetIndexOfFirstElementLargerThanNeighbours(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                bool isLargerThanLeft = array[i] > array[i - 1];
                bool isLargerThanRight = array[i] > array[i + 1];

                if (isLargerThanLeft && isLargerThanRight)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
