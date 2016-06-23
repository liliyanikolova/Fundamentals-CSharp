namespace _2.StringLength
{
    using System;
    using System.Text;

    public class StringLength
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder stringForPrint = new StringBuilder();
            if (input.Length >= 20)
            {
                stringForPrint.AppendLine(input.Substring(0, 20));
            }
            else
            {
                stringForPrint.Append(input);
                for (int i = input.Length; i < 20; i++)
                {
                    stringForPrint.Append("*");
                }

                stringForPrint.AppendLine();
            }

            Console.WriteLine(stringForPrint.ToString());
        }
    }
}
