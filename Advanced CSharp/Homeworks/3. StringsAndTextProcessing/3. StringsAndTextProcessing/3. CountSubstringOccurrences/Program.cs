namespace _3.CountSubstringOccurrences
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string serachText = Console.ReadLine();

            string textToLower = text.ToLower();
            string searchTextToLower = serachText.ToLower();

            int matchCounter = 0;

            for (int i = 0; i < text.Length - serachText.Length + 1; i++)
            {
                if (textToLower.Substring(i).StartsWith(searchTextToLower))
                {
                    matchCounter++;
                }
            }

            Console.WriteLine(matchCounter);
        }
    }
}
