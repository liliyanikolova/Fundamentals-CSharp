namespace _6.CountSymbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSymbolsMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> occurrencesByChar = new SortedDictionary<char, int>();
            foreach (char symbol in input)
            {
                if (!occurrencesByChar.ContainsKey(symbol))
                {
                    occurrencesByChar.Add(symbol, 1);
                    continue;
                }

                occurrencesByChar[symbol]++;
            } 

            foreach (var symbol in occurrencesByChar)
            {
                Console.WriteLine("{0}: {1} time/s", symbol.Key, symbol.Value);
            }
        }
    }
}
