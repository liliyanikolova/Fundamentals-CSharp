namespace _8.LegoBlocks
{
    using System;
    using System.Linq;

    public class LegoBlocks
    {
        public static void Main(string[] args)
        {
            int rowsNumber = int.Parse(Console.ReadLine());

            int cellsCount = 0;
            int[][] firstJaggedArray = new int[rowsNumber][];
            for (int i = 0; i < rowsNumber; i++)
            {
                firstJaggedArray[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                cellsCount += firstJaggedArray[i].Length;
            }

            int[][] secondJaggedArray = new int[rowsNumber][];
            for (int i = 0; i < rowsNumber; i++)
            {
                secondJaggedArray[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                cellsCount += secondJaggedArray[i].Length;
            }

            int firstRowMatrixWidth = firstJaggedArray[0].Length + secondJaggedArray[0].Length;
            for (int i = 1; i < rowsNumber; i++)
            {
                int currentRowMatrixWidth = firstJaggedArray[i].Length + secondJaggedArray[i].Length;
                if (currentRowMatrixWidth != firstRowMatrixWidth)
                {
                    Console.WriteLine("The total number of cells is: {0}", cellsCount);
                    return;
                }
            }

            for (int i = 0; i < rowsNumber; i++)
            {
                Console.WriteLine("[{0}, {1}]", string.Join(", ", firstJaggedArray[i]), string.Join(", ", secondJaggedArray[i].Reverse()));
            }
        }
    }
}
