namespace _4.TextFilter
{
    using System;

    public class TextFilterMain
    {
        public static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(',');
            string inputText = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                int wordLength = word.Length;
                string asterisks = new string('*', wordLength);
                inputText = inputText.Replace(word, asterisks);
            }

            Console.WriteLine(inputText);
        }
    }
}
