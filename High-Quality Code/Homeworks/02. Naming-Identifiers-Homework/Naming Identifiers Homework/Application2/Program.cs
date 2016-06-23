using Mines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mines
{
    public class Minesweeper
    {
        private static void Main()
        {
            string command = string.Empty;
            char[,] field = CreatePlayground();
            char[,] bombs = SetBombs();
            int totalPoints = 0;
            bool explosion = false;
            List<Player> champions = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool flag = true;
            const int max = 35;
            bool hasMaxPoints = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine(
                        "Lets play 'Mines'. Try to find out fields without mine."
                        + " Use command 'Top' to see current rating, 'Restart' to start a new game, 'Exit' to exit the game!");
                    UpdatePlayground(field);
                    flag = false;
                }

                Console.Write("Enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column)
                        && row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "Turn";
                    }
                }

                switch (command)
                {
                    case "Top":
                        Rating(champions);
                        break;
                    case "Restart":
                        field = CreatePlayground();
                        bombs = SetBombs();
                        UpdatePlayground(field);
                        explosion = false;
                        flag = false;
                        break;
                    case "Exit":
                        Console.WriteLine("Bye Bye Bye!");
                        break;
                    case "Turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                Play(field, bombs, row, column);
                                totalPoints++;
                            }

                            if (max == totalPoints)
                            {
                                hasMaxPoints = true;
                            }
                            else
                            {
                                UpdatePlayground(field);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }

                if (explosion)
                {
                    UpdatePlayground(bombs);
                    Console.Write("\nYou die with {0} points. " + "Write your nickname: ", totalPoints);
                    string nickname = Console.ReadLine();
                    Player newPlayer = new Player(nickname, totalPoints);
                    if (champions.Count < 5)
                    {
                        champions.Add(newPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < newPlayer.Points)
                            {
                                champions.Insert(i, newPlayer);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    champions.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    Rating(champions);

                    field = CreatePlayground();
                    bombs = SetBombs();
                    totalPoints = 0;
                    explosion = false;
                    flag = true;
                }

                if (hasMaxPoints)
                {
                    Console.WriteLine("\nCongratulations! You open all 35 cells.");
                    UpdatePlayground(bombs);
                    Console.WriteLine("Write your name: ");
                    string name = Console.ReadLine();
                    Player newPlayer = new Player(name, totalPoints);
                    champions.Add(newPlayer);
                    Rating(champions);
                    field = CreatePlayground();
                    bombs = SetBombs();
                    totalPoints = 0;
                    hasMaxPoints = false;
                    flag = true;
                }
            }
            while (command != "Exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.Read();
        }

        private static void Rating(List<Player> player)
        {
            Console.WriteLine("\nRating:");
            if (player.Count > 0)
            {
                for (int i = 0; i < player.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, player[i].Name, player[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty rating!\n");
            }
        }

        private static void Play(char[,] field, char[,] bombs, int row, int column)
        {
            char explosionCounter = ExplosionCount(bombs, row, column);
            bombs[row, column] = explosionCounter;
            field[row, column] = explosionCounter;
        }

        private static void UpdatePlayground(char[,] board)
        {
            int boardRowsCount = board.GetLength(0);
            int boardColumnssCount = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRowsCount; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardColumnssCount; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayground()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] SetBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] playground = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playground[i, j] = '-';
                }
            }

            List<int> allBombsPossitions = new List<int>();
            while (allBombsPossitions.Count < 15)
            {
                Random random = new Random();
                int bombPossition = random.Next(50);
                if (!allBombsPossitions.Contains(bombPossition))
                {
                    allBombsPossitions.Add(bombPossition);
                }
            }

            foreach (int bombPossition in allBombsPossitions)
            {
                int column = bombPossition / columns;
                int row = bombPossition % columns;
                if (row == 0 && bombPossition != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playground[column, row - 1] = '*';
            }

            return playground;
        }

        private static void smetki(char[,] field)
        {
            int column = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char kolkoo = ExplosionCount(field, i, j);
                        field[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char ExplosionCount(char[,] bombsPossitions, int row, int column)
        {
            int count = 0;
            int rows = bombsPossitions.GetLength(0);
            int columns = bombsPossitions.GetLength(1);

            if (row - 1 >= 0)
            {
                if (bombsPossitions[row - 1, column] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (bombsPossitions[row + 1, column] == '*')
                {
                    count++;
                }
            }

            if (column - 1 >= 0)
            {
                if (bombsPossitions[row, column - 1] == '*')
                {
                    count++;
                }
            }

            if (column + 1 < columns)
            {
                if (bombsPossitions[row, column + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (bombsPossitions[row - 1, column - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (bombsPossitions[row - 1, column + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (bombsPossitions[row + 1, column - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (bombsPossitions[row + 1, column + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}