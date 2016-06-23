namespace _2.LastDigitOfNumber
{
    using System;

    public class LastDigitOfNumberMain
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string lastDigitAsWord = GetLastDigitAsWord(number);
            Console.WriteLine(lastDigitAsWord);
        }

        public static string GetLastDigitAsWord(int number)
        {
            int lastDigit = number % 10;

            switch (lastDigit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "zero";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
            }

            return "No such a digit";
        }
    }
}
