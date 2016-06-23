namespace _2.RadioactiveMutantVampireBunnies
{
    using System;

    public class RadioactiveMutantVampireBunniesMain
    {
        private static bool stillPlay;

        public static void Main(string[] args)
        {
            string[] lairSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int lairHight = int.Parse(lairSize[0]);
            int lairWidth = int.Parse(lairSize[1]);

            char[][] inputLair = new char[lairHight][];

            int playerCurrentRow = 0;
            int playerCurrentColumn = 0;
            for (int i = 0; i < lairHight; i++)
            {
                inputLair[i] = new char[lairWidth];
                char[] inputLine = Console.ReadLine().ToCharArray();
                for (int j = 0; j < inputLine.Length; j++)
                {
                    inputLair[i][j] = inputLine[j];
                    if (inputLair[i][j].Equals('P'))
                    {
                        playerCurrentRow = i;
                        playerCurrentColumn = j;
                    }
                }
            }

            string commands = Console.ReadLine();

            char[][] resultLair = new char[lairHight][];
            bool isAlive = true;
            stillPlay = true;
            for (int i = 0; i < commands.Length; i++)
            {
                if (!stillPlay)
                {
                    break;
                }

                resultLair = inputLair;

                switch (commands[i])
                {
                    case 'U':
                        if (playerCurrentRow - 1 < 0)
                        {
                            resultLair[playerCurrentRow][playerCurrentColumn] = '.';
                            stillPlay = false;
                            break;
                        }

                        playerCurrentRow -= 1;
                        if (resultLair[playerCurrentRow][playerCurrentColumn] == 'B')
                        {
                            isAlive = false;
                            stillPlay = false;
                        }

                        break;

                    case 'D':
                        if (playerCurrentRow + 1 >= resultLair.GetLength(0))
                        {
                            resultLair[playerCurrentRow][playerCurrentColumn] = '.';
                            stillPlay = false;
                            break;
                        }

                        playerCurrentRow += 1;
                        if (resultLair[playerCurrentRow][playerCurrentColumn] == 'B')
                        {
                            isAlive = false;
                            stillPlay = false;
                        }

                        break;

                    case 'L':
                        if (playerCurrentColumn - 1 < 0)
                        {
                            resultLair[playerCurrentRow][playerCurrentColumn] = '.';
                            stillPlay = false;
                            break;
                        }

                        playerCurrentColumn -= 1;
                        if (resultLair[playerCurrentRow][playerCurrentColumn] == 'B')
                        {
                            isAlive = false;
                            stillPlay = false;
                        }

                        break;

                    case 'R':
                        if (playerCurrentColumn + 1 >= resultLair[0].Length)
                        {
                            resultLair[playerCurrentRow][playerCurrentColumn] = '.';
                            stillPlay = false;
                            break;
                        }

                        playerCurrentColumn += 1;
                        if (resultLair[playerCurrentRow][playerCurrentColumn] == 'B')
                        {
                            isAlive = false;
                            stillPlay = false;
                        }

                        break;
                }

                inputLair = SpreadBunnies(resultLair);
            }

            for (int i = 0; i < resultLair.Length; i++)
            {
                for (int j = 0; j < inputLair[0].Length; j++)
                {
                    Console.Write(inputLair[i][j]);
                }
                Console.WriteLine();
            }

            if (isAlive)
            {
                Console.WriteLine("won: {0} {1}", playerCurrentRow, playerCurrentColumn);
            }
            else
            {
                Console.WriteLine("dead: {0} {1}", playerCurrentRow, playerCurrentColumn);
            }
        }

        public static char[][] SpreadBunnies(char[][] inputMatrix)
        {
            char[][] resultMatrix = new char[inputMatrix.Length][];
            
            for (int i = 0; i < inputMatrix.Length; i++)
            {
                resultMatrix[i] = new char[inputMatrix[0].Length];
                for (int j = 0; j < inputMatrix[0].Length; j++)
                {
                    resultMatrix[i][j] = '.';
                }
            }

            for (int row = 0; row < inputMatrix.Length; row++)
            {
                for (int column = 0; column < inputMatrix[row].Length; column++)
                {
                    if (inputMatrix[row][column] == 'B')
                    {
                        resultMatrix[row][column] = 'B';
                        if (RowExists(inputMatrix, row - 1))
                        {
                            if (resultMatrix[row - 1][column] == 'P')
                            {
                                stillPlay = false;
                            }

                            resultMatrix[row - 1][column] = 'B';
                        }

                        if (RowExists(inputMatrix, row + 1))
                        {
                            if (resultMatrix[row + 1][column] == 'P')
                            {
                                stillPlay = false;
                            }

                            resultMatrix[row + 1][column] = 'B';
                        }

                        if (ColExists(inputMatrix, column - 1))
                        {
                            if (resultMatrix[row][column - 1] == 'P')
                            {
                                stillPlay = false;
                            }

                            resultMatrix[row][column - 1] = 'B';
                        }

                        if (ColExists(inputMatrix, column + 1))
                        {
                            if (resultMatrix[row][column + 1] == 'P')
                            {
                                stillPlay = false;
                            }

                            resultMatrix[row][column + 1] = 'B';
                        }
                    }
                }
            }

            return resultMatrix;
        }


        private static bool ColExists(char[][] matrix, int column)
        {
            if (column >= 0 && column < matrix[0].Length)
            {
                return true;
            }

            return false;
        }

        private static bool RowExists(char[][] matrix, int row)
        {
            if (row >= 0 && row < matrix.GetLength(0))
            {
                return true;
            }

            return false;
        }
    }
}
