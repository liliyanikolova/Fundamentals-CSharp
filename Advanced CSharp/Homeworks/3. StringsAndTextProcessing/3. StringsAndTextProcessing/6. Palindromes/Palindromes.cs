namespace _6.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string[] splitText = inputText.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> palindromes = new SortedSet<string>();
            foreach (var word in splitText)
            {
                string reversedWord = new string(word.Reverse().ToArray());
                if (word == reversedWord)
                {
                    palindromes.Add(word);
                }
            }
            
            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
