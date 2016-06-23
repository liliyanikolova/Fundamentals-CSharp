namespace _2.TheSieveOfEratosthenes
{
    using System;
    using System.Collections.Generic;

    public class TheSieveOfEratosthenesMain
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] consecutiveNums = new int[number - 1];
            for (int i = 0; i < number - 1; i++)
            {
                consecutiveNums[i] = i + 2;
            }

            List<int> primeNumbers = new List<int>() { 2 };
            int prime = 2;
            int currentPossition = 0;
            while (prime < number)
            {
                for (int i = 2 * prime; i <= number; i += prime)
                {
                    consecutiveNums[i - 2] = 0;
                }

                while (prime >= consecutiveNums[currentPossition])
                {
                    currentPossition++;

                    if (currentPossition >= consecutiveNums.Length - 1)
                    {
                        currentPossition--;
                        break;
                    }
                }

                prime = consecutiveNums[currentPossition];

                if (prime == 0)
                {
                    break;
                }

                primeNumbers.Add(prime);
            }

            Console.WriteLine(string.Join(", ", primeNumbers));
        }
    }
}
