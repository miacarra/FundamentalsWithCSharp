using System;

namespace PoundsToDollars
{
    class ConvertsPoundsToDollars
    {
        static void Main(string[] args)
        {
            //            Create a program that converts British pounds to US dollars formatted to the 3rd decimal point.
            //1 British Pound = 1.31 Dollars


            double pounds = double.Parse(Console.ReadLine());
            ConvertPounds(pounds);
        }

        public static void ConvertPounds(double input)
        {
            Console.WriteLine($"{(input * 1.31):f3}");
        }

    }
}

