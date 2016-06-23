namespace RotatingWalkInMatrix
{
    using System;

    internal class Matrix
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int number;

            while (!int.TryParse(input, out number) || number < 0 || number > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            int[,] matrix = new int[number, number];
            int cellNumber = 1, matrixRow = 0, matrixCol = 0;
            const int DirectionX = 1, DirectionY = 1;

            FillMatrix(matrix, ref cellNumber, matrixRow, matrixCol, DirectionX, DirectionY);

            CellFind(matrix, out matrixRow, out matrixCol);

            if (matrixRow != 0 && matrixCol != 0)
            {
                FillMatrix(matrix, ref cellNumber, matrixRow, matrixCol, DirectionX, DirectionY);
            }

            PrintMatrix(matrix);
        }

        private static void DirectionChange(ref int directionX, ref int directionY)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int cd = 0;
            
            for (int count = 0; count < 8; count++)
            {
                if (directionsX[count] != directionX || directionsY[count] != directionY)
                {
                    continue;
                }

                cd = count;
                break;
            }

            if (cd == 7)
            {
                directionX = directionsX[0];
                directionY = directionsY[0];
                return;
            }

            directionX = directionsX[cd + 1];
            directionY = directionsY[cd + 1];
        }

        private static bool CellCheck(int[,] matrix, int matrixRow, int matrixCol)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (matrixRow + directionsX[i] >= matrix.GetLength(0) || matrixRow + directionsX[i] < 0)
                {
                    directionsX[i] = 0;
                }

                if (matrixCol + directionsY[i] >= matrix.GetLength(0) || matrixCol + directionsY[i] < 0)
                {
                    directionsY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[matrixRow + directionsX[i], matrixCol + directionsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void CellFind(int[,] matrix, out int matrixRow, out int matrixCol)
        {
            matrixRow = 0;
            matrixCol = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrixRow = i;
                        matrixCol = j;
                        return;
                    }
                }
            }
        }

       private static void PrintMatrix(int[,] matrix)
        {
            for (int matrixRow = 0; matrixRow < matrix.GetLength(0); matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < matrix.GetLength(1); matrixCol++)
                {
                    Console.Write("{0,3}", matrix[matrixRow, matrixCol]);
                }

                Console.WriteLine();
            }
        }

        private static void FillMatrix(int[,] matrix, ref int cellNumber, int matrixRow, int matrixCol, int directionX, int directionY)
        {
            while (true)
            {
                // THE CONDITION MIGHT NOT BE THE BEST BUT IT IS NECESSARY
                // THE BREAK IS 100 % EFFECTIVE , AS COMPENSATION
                matrix[matrixRow, matrixCol] = cellNumber;

                if (!CellCheck(matrix, matrixRow, matrixCol))
                {
                    break;
                } // THE LOOP STOPS IF THE CHECK IS FALSE
                
                if (matrixRow + directionX >= matrix.GetLength(0) || matrixRow + directionX < 0 || matrixCol + directionY >= matrix.GetLength(0) || matrixCol + directionY < 0 || matrix[matrixRow + directionX, matrixCol + directionY] != 0)
                {
                    while (matrixRow + directionX >= matrix.GetLength(0) || matrixRow + directionX < 0 || matrixCol + directionY >= matrix.GetLength(0) || matrixCol + directionY < 0 || matrix[matrixRow + directionX, matrixCol + directionY] != 0)
                    {
                        DirectionChange(ref directionX, ref directionY);
                    }
                }
                
                matrixRow += directionX;
                matrixCol += directionY;
                cellNumber++;
            }

            cellNumber++;
        }
    }
}
