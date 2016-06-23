namespace test
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Company Name: ");
            string companyName = Console.ReadLine();

            Console.Write("Company Address: ");
            string companyAddress = Console.ReadLine();

            Console.WriteLine("Company Name: {0}", companyName);
            Console.WriteLine("Company Address: {0}", companyName);
        }
    }
}
