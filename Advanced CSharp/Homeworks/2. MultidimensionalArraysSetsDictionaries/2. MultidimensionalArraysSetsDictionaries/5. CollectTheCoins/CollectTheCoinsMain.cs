namespace _5.CollectTheCoins
{
    using System;

    public class CollectTheCoinsMain
    {
        public static void Main(string[] args)
        {
            string[] boardMatrix = new string[4];
            for (int i = 0; i < 4; i++)
            {
                boardMatrix[i] = Console.ReadLine();
            }

            string commands = Console.ReadLine();
            int coinsCount = 0;
            int wallsHitCount = 0;
            int currentRow = 0;
            int currentCharPossition = 0;
            foreach (char command in commands)
            {
                switch (command)
                {
                    case '>':
                        if (currentCharPossition + 1 > boardMatrix[currentRow].Length)
                        {
                            wallsHitCount++;
                        }
                        else
                        {
                            currentCharPossition++;
                        }

                        break;

                    case '<':
                        if (currentCharPossition - 1 < 0)
                        {
                            wallsHitCount++;
                        }
                        else
                        {
                            currentCharPossition--;
                        }

                        break;

                    case 'V':
                        if (currentRow + 1 > 3 || boardMatrix[currentRow + 1].Length < currentCharPossition)
                        {
                            wallsHitCount++;
                        }
                        else
                        {
                            currentRow++;
                        }

                        break;

                    case '^':
                        if (currentRow - 1 < 0 || boardMatrix[currentRow - 1].Length < currentCharPossition)
                        {
                            wallsHitCount++;
                        }
                        else
                        {
                            currentRow--;
                        }

                        break;
                }

                if (boardMatrix[currentRow][currentCharPossition] == '$')
                {
                    coinsCount++;
                }
            }

            Console.WriteLine("Coins collected: {0}", coinsCount);
            Console.WriteLine("Walls hit: {0}", wallsHitCount);
        }
    }
}
