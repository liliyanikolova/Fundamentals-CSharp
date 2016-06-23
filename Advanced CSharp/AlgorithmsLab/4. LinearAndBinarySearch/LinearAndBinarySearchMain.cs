namespace _4.LinearAndBinarySearch
{
    using System;
    using System.Linq;

    public class LinearAndBinarySearchMain
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] parsedNumbers = input.Select(int.Parse).ToArray();

            int element = int.Parse(Console.ReadLine());

            //Console.WriteLine(LinearSearch(parsedNumbers, element));

            Console.WriteLine(BinarySearch(parsedNumbers, element));
        }

        public static int LinearSearch(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int BinarySearch(int[] array, int element)
        {
            int min = 0;
            int max = array.Length - 1;
            int mid = (max - min) / 2;
            while (min != max)
            {                
                if (element == array[mid])
                {
                    int i = 1;
                    if (element != array[mid - i])
                    {
                        return mid;
                    }

                    while (element == array[mid - i])
                    {
                        i++;
                        if (mid - i < 0)
                        {
                            break;
                        }
                    }

                    return mid - i + 1;
                }
                
                if (element < array[mid])
                {
                    max = mid;
                    mid = (max - min) / 2;
                }
                else
                {
                    min = mid;
                    mid += (max - min) / 2;
                }
            }

            return -1;
        }
    }
}
