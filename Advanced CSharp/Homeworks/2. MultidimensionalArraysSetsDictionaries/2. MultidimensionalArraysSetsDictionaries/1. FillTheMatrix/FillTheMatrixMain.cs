namespace _1.FillTheMatrix
{
    using System;

    public class FillTheMatrixMain
    {
        private static int n = 0;

        public static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            MatrixPatternA();
            Console.WriteLine();
            MatrixPatternB();
        }

        public static void MatrixPatternA()
        {
            int[,] matrixA = new int[n, n];
            int counter = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrixA[row, col] = counter;
                    counter++;
                }
            }

            PrintMatrix(matrixA);
        }

        public static void MatrixPatternB()
        {
            int[,] matrixB = new int[n, n];
            int counter = 1;
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrixB[row, col] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrixB[row, col] = counter;
                        counter++;
                    }
                }
            }

            PrintMatrix(matrixB);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int a = 0; a < matrix.GetLength(0); a++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    Console.Write("|{0,2}|", matrix[a, b]);
                }

                Console.WriteLine();
            }
        }
    }
}