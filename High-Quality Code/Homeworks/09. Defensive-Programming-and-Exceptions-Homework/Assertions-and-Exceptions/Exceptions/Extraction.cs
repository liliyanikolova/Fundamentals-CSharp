namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Extraction
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Cannot return a subsequence from null or empty array.");
            }

            if (startIndex < 0)
            {
                throw new ArgumentException("Start index cannot be negative number.");
            }

            if (startIndex > arr.Length)
            {
                throw new ArgumentException("Start index cannot be greater than array lengt.");
            }

            if (count < 0)
            {
                throw new ArgumentException("Count cannot be negative number.");
            }

            if (startIndex + count > arr.Length)
            {
                throw new ArgumentException("There are not so much elements after start index.");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("String cannot be null or empty.");
            }

            if (count < 0)
            {
                throw new ArgumentException("Count cannot be negative number.");
            }

            if (count > str.Length)
            {
                throw new ArgumentException("Count cannot be greater than string length.");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }
    }
}
