namespace Exceptions_Homework
{
    using System;

    public class Number
    {
        public static void CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    Console.WriteLine("{0} is not prime!", number);
                    return;
                }
            }

            Console.WriteLine("{0} is prime!", number);
        }
    }
}
