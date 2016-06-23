namespace _6.NumberCalculations
{
    using System;

    public class NumberCalculationsMain
    {
        public static void Main(string[] args)
        {
            int[] numbersInt = { 1, 3, 77, 13, 31 };
            decimal[] numbersDec = { 1.44M, 3.9M, 77.12M, 13, 31 };
            double[] numbersDouble = { 1.22, 3.62, 77.123, 13, 31.41 };

            Console.WriteLine(GetAverage(numbersInt));
            Console.WriteLine(GetMaximum(numbersDec));
            Console.WriteLine(GetMinimum(numbersInt));
            Console.WriteLine(GetProduct(numbersDouble));
            Console.WriteLine(GetSum(numbersDouble));
            Console.WriteLine(GetMinimum(numbersDec));
        }

        // Given set of integer numbers
        public static int GetMinimum(int[] array)
        {
            int min = array[0];
            foreach (var num in array)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }

        public static int GetMaximum(int[] array)
        {
            int max = array[0];
            foreach (var num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }

        public static double GetAverage(int[] array)
        {
            int count = 0;
            long sum = 0;
            foreach (var num in array)
            {
                sum += num;
                count++;
            }

            return sum / (double)count;
        }

        public static long GetSum(int[] array)
        {
            long sum = 0;
            foreach (var num in array)
            {
                sum += num;
            }

            return sum;
        }

        public static long GetProduct(int[] array)
        {
            long product = 1;
            foreach (var num in array)
            {
                product *= num;
            }

            return product;
        }

        // Given set of decimal numbers
        public static decimal GetMinimum(decimal[] array)
        {
            decimal min = array[0];
            foreach (var num in array)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }

        public static decimal GetMaximum(decimal[] array)
        {
            decimal max = array[0];
            foreach (var num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }

        public static decimal GetAverage(decimal[] array)
        {
            int count = 0;
            decimal sum = 0;
            foreach (var num in array)
            {
                sum += num;
                count++;
            }

            return sum / count;
        }

        public static decimal GetSum(decimal[] array)
        {
            decimal sum = 0;
            foreach (var num in array)
            {
                sum += num;
            }

            return sum;
        }

        public static decimal GetProduct(decimal[] array)
        {
            decimal product = 1;
            foreach (var num in array)
            {
                product *= num;
            }

            return product;
        }

        // Given set of double numbers
        public static double GetMinimum(double[] array)
        {
            double min = array[0];
            foreach (var num in array)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }

        public static double GetMaximum(double[] array)
        {
            double max = array[0];
            foreach (var num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }

        public static double GetAverage(double[] array)
        {
            int count = 0;
            double sum = 0;
            foreach (var num in array)
            {
                sum += num;
                count++;
            }

            return sum / count;
        }

        public static double GetSum(double[] array)
        {
            double sum = 0;
            foreach (var num in array)
            {
                sum += num;
            }

            return sum;
        }

        public static double GetProduct(double[] array)
        {
            double product = 1;
            foreach (var num in array)
            {
                product *= num;
            }

            return product;
        }
    }
}
