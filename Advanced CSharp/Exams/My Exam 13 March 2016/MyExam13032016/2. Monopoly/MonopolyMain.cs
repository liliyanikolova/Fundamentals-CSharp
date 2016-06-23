namespace _2.Monopoly
{
    using System;
    using System.Linq;

    public class MonopolyMain
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int turnsCount = 0;
            int totalMoney = 50;
            int totalHotels = 0;

            for (int row = 0; row < input[0]; row++)
            {
                string inputLine = Console.ReadLine();
                if (row % 2 == 0)
                {
                    for (int column = 0; column < input[1]; column++)
                    {
                        switch (inputLine[column])
                        {
                            case 'H':
                                totalHotels++;
                                Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", totalMoney, totalHotels);
                                totalMoney = 10 * totalHotels;
                                turnsCount++;
                                break;
                            case 'J':
                                totalMoney += 30 * totalHotels;
                                Console.WriteLine("Gone to jail at turn {0}.", turnsCount);
                                turnsCount += 3;
                                break;
                            case 'F':
                                totalMoney += 10 * totalHotels;
                                turnsCount++;
                                break;
                            case 'S':
                                int moneyToSpent = (row + 1) * (column + 1);
                                if (moneyToSpent < totalMoney)
                                {
                                    totalMoney -= (row + 1) * (column + 1);
                                }
                                else
                                {
                                    moneyToSpent = totalMoney;
                                    totalMoney = 0;
                                }

                                Console.WriteLine("Spent {0} money at the shop.", moneyToSpent);
                                totalMoney += 10 * totalHotels;
                                turnsCount++;
                                break;
                        }
                    }
                }
                else
                {
                    for (int column = input[1] - 1; column >= 0; column--)
                    {
                        switch (inputLine[column])
                        {
                            case 'H':
                                totalHotels++;
                                Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", totalMoney, totalHotels);
                                totalMoney = 10 * totalHotels;
                                turnsCount++;
                                break;
                            case 'J':
                                totalMoney += 30 * totalHotels;
                                Console.WriteLine("Gone to jail at turn {0}.", turnsCount);
                                turnsCount += 3;
                                break;
                            case 'F':
                                totalMoney += 10 * totalHotels;
                                turnsCount++;
                                break;
                            case 'S':
                                int moneyToSpent = (row + 1) * (column + 1);
                                if (moneyToSpent < totalMoney)
                                {
                                    totalMoney -= (row + 1) * (column + 1);
                                }
                                else
                                {
                                    moneyToSpent = totalMoney;
                                    totalMoney = 0;
                                }

                                Console.WriteLine("Spent {0} money at the shop.", moneyToSpent);
                                totalMoney += 10 * totalHotels;
                                turnsCount++;
                                break;
                        }
                    }
                }
            }

            Console.WriteLine("Turns {0}", turnsCount);
            Console.WriteLine("Money {0}", totalMoney);
        }
    }
}
