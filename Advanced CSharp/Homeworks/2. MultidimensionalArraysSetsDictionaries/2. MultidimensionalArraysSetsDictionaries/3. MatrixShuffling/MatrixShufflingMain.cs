namespace _3.MatrixShuffling
{
    using System;

    public class MatrixShufflingMain
    {
        public static void Main(string[] args)
        {
            int matrixHight = int.Parse(Console.ReadLine());
            int matrixWidth = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixHight, matrixWidth];
            for (int i = 0; i < matrixHight; i++)
            {
                for (int j = 0; j < matrixWidth; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] splitComman = command.Split();

                int firstCellRow = int.Parse(splitComman[1]);
                int firstCellColumn = int.Parse(splitComman[2]);
                int secondCellRow = int.Parse(splitComman[3]);
                int secondCellColumn = int.Parse(splitComman[4]);

                if (splitComman[0] != "swap" ||
                    firstCellRow > matrixHight ||
                    firstCellColumn > matrixWidth ||
                    secondCellRow > matrixHight ||
                    secondCellColumn > matrixHight)
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                int firstCell = matrix[firstCellRow, firstCellColumn];
                int secondCell = matrix[secondCellRow, secondCellColumn];

                matrix[firstCellRow, firstCellColumn] = secondCell;
                matrix[secondCellRow, secondCellColumn] = firstCell;

                for (int i = 0; i < matrixHight; i++)
                {
                    for (int j = 0; j < matrixWidth; j++)
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }

                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }
        }
    }
}
