namespace _5.UnicodeCharacters
{
    using System;
    using System.Linq;
    using System.Text;

    using Microsoft.SqlServer.Server;

    public class UnicodeCharactersMain
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < inputText.Length; i++)
            {
                int asNumber = Convert.ToInt32(inputText[i]);
                result.Append(string.Format("\\u00{0:x}", asNumber));
            }

            Console.WriteLine(result.ToString());
        }
    }
}
