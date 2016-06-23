namespace _4.SequencesOfEqualStrings
{
    using System;

    public class SequencesOfEqualStringsMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split();

            Console.Write("{0}", inputArray[0]);
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] == inputArray[i + 1])
                {
                    Console.Write(" {0}", inputArray[i + 1]);
                }
                else
                {
                    Console.WriteLine();
                    Console.Write(inputArray[i + 1]);
                }
            }

            Console.WriteLine();
        }
    }
}
