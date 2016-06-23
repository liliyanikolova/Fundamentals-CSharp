using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstMultiplierArray = new double[,] { { 1, 3 }, { 5, 7 } };
            var secondMultiplierArray = new double[,] { { 4, 2 }, { 1, 5 } };
            var producutArray = MultiplyTwoArrays(firstMultiplierArray, secondMultiplierArray);

            for (int ii = 0; ii < producutArray.GetLength(0); ii++)
            {
                for (int jj = 0; jj < producutArray.GetLength(1); jj++)
                {
                    Console.Write(producutArray[ii, jj] + " ");
                }
                Console.WriteLine();
            }

        }

        static double[,] MultiplyMatrix(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new Exception("Error!");
            }

            var firstMatrixSecondElementLength = firstMatrixArray.GetLength(1);
            var producutArray = new double[firstMultiplierArray.GetLength(0), secondMatrix.GetLength(1)];
            for (int i = 0; i < producutArray.GetLength(0); i++)
                for (int j = 0; j < producutArray.GetLength(1); j++)
                    for (int k = 0; k < firstMultiplierSecondElementLength; k++)
                        producutArray[i, j] += firstMultiplierArray[i, k] * secondMatrix[k, j];
            return producutArray;
        }
    }
}