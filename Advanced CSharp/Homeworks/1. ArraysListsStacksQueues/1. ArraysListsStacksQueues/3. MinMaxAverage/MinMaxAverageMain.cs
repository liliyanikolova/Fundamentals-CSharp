namespace _3.MinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinMaxAverageMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double[] inputArray = input.Split().Select(double.Parse).ToArray();

            List<double> floatedNumbers = new List<double>();
            List<double> roundedNumbers = new List<double>();
            foreach (var num in inputArray)
            {
                if (num == Math.Floor(num))
                {
                    floatedNumbers.Add(num);
                }
                else
                {
                    roundedNumbers.Add(num);
                }
            }

            double minFloatedNumber = floatedNumbers.Min();
            double minRoundedNumber = roundedNumbers.Min();

            double maxFloatedNumber = floatedNumbers.Max();
            double maxRoundedNumber = roundedNumbers.Max();

            double sumFloatedNumber = floatedNumbers.Sum();
            double sumRoundedNumber = roundedNumbers.Sum();

            double averageFloatedNumber = floatedNumbers.Average();
            double averageRoundedNumber = roundedNumbers.Average();

            string floatedCategory = string.Join(", ", floatedNumbers);
            string roundedCategory = string.Join(", ", roundedNumbers);

            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, average: {4:F2}",
                floatedCategory,
                minFloatedNumber,
                maxFloatedNumber,
                sumFloatedNumber,
                averageFloatedNumber);
            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, average: {4:F2}",
                roundedCategory,
                minRoundedNumber,
                maxRoundedNumber,
                sumRoundedNumber,
                averageRoundedNumber);

        }
    }
}
