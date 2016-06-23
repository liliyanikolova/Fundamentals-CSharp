namespace _7.GenericArraySort
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices.ComTypes;

    public class GenericArraySortMain
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 6, 9, 1, 0, 5 };
            string[] strings = { "zaz", "cba", "baa", "azis" };
            DateTime[] dates = { new DateTime(2016, 2, 10), new DateTime(2016, 1, 19), new DateTime(2015, 2, 22) };

            SortArray(numbers);
            SortArray(strings);
            SortArray(dates);

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(string.Join(", ", strings));
            Console.WriteLine(string.Join(", ", dates));
        }

        public static T[] SortArray<T>(T[] array) 
            where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                T tempMin;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        tempMin = array[i];
                        array[i] = array[j];
                        array[j] = tempMin;
                    }
                }
            }

            return array;
        }
    }
}
