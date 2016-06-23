namespace _7.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class PhonebookMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> phoneByName = new Dictionary<string, List<string>>();
            while (input != "search")
            {
                string[] currentContact = input.Split('-');
                if (!phoneByName.ContainsKey(currentContact[0]))
                {
                    List<string> personNumbers = new List<string> { currentContact[1] };
                    phoneByName.Add(currentContact[0], personNumbers);
                }
                else
                {
                    List<string> currentPhones = phoneByName[currentContact[0]];
                    currentPhones.Add(currentContact[1]);
                    phoneByName[currentContact[0]] = currentPhones;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                if (!phoneByName.ContainsKey(input))
                {
                    Console.WriteLine("Contact {0} does not exist.", input);
                    input = Console.ReadLine();
                    continue;
                }

                Console.Write("{0} -> {1}", input, phoneByName[input][0]);
                if (phoneByName[input].Count > 1)
                {
                    for (int i = 1; i < phoneByName[input].Count; i++)
                    {
                        Console.Write(", {0}", phoneByName[input][i]);
                    }
                }

                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
