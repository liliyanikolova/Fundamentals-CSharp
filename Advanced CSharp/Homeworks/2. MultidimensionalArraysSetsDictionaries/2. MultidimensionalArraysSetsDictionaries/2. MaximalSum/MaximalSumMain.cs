namespace _2.MaximalSum
{
    using System;

    public class MaximalSumMain
    {
        public static void Main(string[] args)
        {
            string[] matrixSizes = Console.ReadLine().Split();
            int matrixHight = int.Parse(matrixSizes[0]);
            int matrixWidth = int.Parse(matrixSizes[1]);

            int[,] matrix = new int[matrixHight, matrixWidth];

            for (int i = 0; i < matrixHight; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < matrixWidth; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }

            int maxSum = 0;
            int[,] maxSumMatrix = new int[3, 3];
            for (int i = 0; i < matrixHight - 2; i++)
            {
                for (int j = 0; j < matrixWidth - 2; j++)
                {
                    int tempSum = 0;
                    int[,] tempMaxSumMatrix = new int[3, 3];
                    for (int k = i; k < i + 3; k++)
                    {
                        for (int l = j; l < j + 3; l++)
                        {
                            tempSum += matrix[k, l];
                            tempMaxSumMatrix[k - i, l - j] = matrix[k, l];
                        }
                    }

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        maxSumMatrix = tempMaxSumMatrix;
                    }
                }
            }

            Console.WriteLine("Sum = {0}", maxSum);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", maxSumMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
