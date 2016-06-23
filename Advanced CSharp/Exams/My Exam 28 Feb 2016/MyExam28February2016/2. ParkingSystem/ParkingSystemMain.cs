namespace _2.ParkingSystem
{
    using System;

    public class ParkingSystemMain
    {
        public static void Main(string[] args)
        {
            string[] parkingLotSize = Console.ReadLine().Split();
            int parkLotRows = int.Parse(parkingLotSize[0]);
            int parkLotCols = int.Parse(parkingLotSize[1]);
            int[,] parkingLot = new int[parkLotRows, parkLotCols];

            string input = Console.ReadLine();
            while (input != "stop")
            {
                string[] inputSplit = input.Split();
                int entryRow = int.Parse(inputSplit[0]);
                int row = int.Parse(inputSplit[1]);
                int column = int.Parse(inputSplit[2]);
                int distance = 0;
                if (parkingLot[row, column] == 0)
                {
                    parkingLot[row, column] = 1;
                    distance = Math.Abs(row - entryRow) + 1 + column;
                    Console.WriteLine(distance);
                }
                else
                {
                    int distanceLeft = 0;
                    int distanceRight = 0;
                    int colLeft = 0;
                    int colRight = 0;

                    for (int i = column - 1; i >= 1; i--)
                    {
                        if (parkingLot[row, i] == 0)
                        {
                            distanceLeft = Math.Abs(row - entryRow) + 1 + i;
                            colLeft = i;
                            break;
                        }
                    }

                    for (int i = column + 1; i < parkLotCols; i++)
                    {
                        if (parkingLot[row, i] == 0)
                        {
                            distanceRight = Math.Abs(row - entryRow) + 1 + i;
                            colRight = i;
                            break;
                        }
                    }

                    if (distanceLeft == 0 && distanceRight == 0)
                    {
                        Console.WriteLine("Row {0} full", row);
                        input = Console.ReadLine();
                        continue;
                    }

                    if (distanceLeft <= distanceRight && distanceLeft != 0)
                    {
                        parkingLot[row, colLeft] = 1;
                        Console.WriteLine(distanceLeft);
                    }
                    else
                    {
                        parkingLot[row, colRight] = 1;
                        Console.WriteLine(distanceRight);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
