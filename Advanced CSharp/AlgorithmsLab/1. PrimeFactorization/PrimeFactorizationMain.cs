namespace _1.PrimeFactorization
{
    using System;
    using System.Collections.Generic;

    public class PrimeFactorizationMain
    {
        public static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            uint divisor = 2;
            List<uint> divisors = new List<uint>();
            uint result = number;
            while (result != 1)
            {
                if (result % divisor == 0) 
                {
                    divisors.Add(divisor);
                    result = result / divisor;
                    continue;
                }

                divisor++;
            }

            Console.WriteLine("{0} = {1}", number, string.Join(" * ", divisors));
        }
    }
}
