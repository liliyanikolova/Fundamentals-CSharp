namespace _2.ArraySlider
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class ArraySliderMain
    {
        public static void Main(string[] args)
        {
            BigInteger[] inputArray =
                Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => BigInteger.Parse(n))
                .ToArray();

            string command = Console.ReadLine();

            int currentIndex = 0;
            while (command != "stop")
            {
                string[] splitCommand = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int offset = int.Parse(splitCommand[0]) % inputArray.Length;
                string operation = splitCommand[1];
                long operand = long.Parse(splitCommand[2]);

                if (offset < 0)
                {
                    offset = inputArray.Length + offset;
                }

                currentIndex = (currentIndex + offset) % inputArray.Length;

                switch (operation)
                {
                    case "+":
                        inputArray[currentIndex] += operand;
                        break;
                    case "-":
                        inputArray[currentIndex] -= operand;
                        if (inputArray[currentIndex] < 0)
                        {
                            inputArray[currentIndex] = 0;
                        }
                        break;
                    case "*":
                        inputArray[currentIndex] *= operand;
                        break;
                    case "/":
                        inputArray[currentIndex] /= operand;
                        break;
                    case "&":
                        inputArray[currentIndex] &= operand;
                        break;
                    case "|":
                        inputArray[currentIndex] |= operand;
                        break;
                    case "^":
                        inputArray[currentIndex] ^= operand;
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", inputArray));
        }
    }
}
