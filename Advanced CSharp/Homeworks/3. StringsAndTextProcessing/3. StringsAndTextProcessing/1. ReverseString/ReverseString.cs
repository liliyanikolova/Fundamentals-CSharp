namespace _1.ReverseString
{
    using System;
    using System.Text;

    public class ReverseString
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            StringBuilder reversedInput = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput.Append(input[i]);
            }

            Console.WriteLine(reversedInput.ToString());
        }
    }
}
