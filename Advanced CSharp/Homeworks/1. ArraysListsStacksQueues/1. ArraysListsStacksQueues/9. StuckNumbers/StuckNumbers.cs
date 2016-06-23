namespace _9.StuckNumbers
{
    using System;
    using System.Linq;

    public class StuckNumbers
    {
        public static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            string[] inputArray = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            int count = 0;
            foreach (string a in inputArray)
            {
                foreach (string b in inputArray)
                {
                    foreach (string c in inputArray)
                    {
                        foreach (string d in inputArray)
                        {
                            if (a != b &&
                                a != c &&
                                a != d && 
                                b != c &&
                                b != d && 
                                c != d)
                            {
                                string firstAppendedNumber = string.Concat(a, b);
                                string secondAppendedString = string.Concat(c, d);
                                if (firstAppendedNumber == secondAppendedString)
                                {
                                    Console.WriteLine("{0}|{1}=={2}|{3}", a, b, c, d);
                                    count++;
                                }
                            }
                        }
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
