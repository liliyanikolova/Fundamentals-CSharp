namespace _5.ReverseNumber
{
    using System;
    using System.Linq;

    public class ReverseNumber
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            double reversedNumber = GetReversedNumber(number);
            Console.WriteLine(reversedNumber);
        }

        public static double GetReversedNumber(double number)
        {
            string numberAsText = number.ToString();
            string reversedNumberAsText = null;
            for (int i = numberAsText.Length - 1; i >= 0; i--)
            {
                reversedNumberAsText += numberAsText[i];
            }

            return double.Parse(reversedNumberAsText);
        }
    }
}
