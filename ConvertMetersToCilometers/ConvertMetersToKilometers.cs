using System;

namespace ConvertMetersToKilometers
{
    class ConvertMetersToKilometers
    {
        //You will be given an integer that will be a distance in meters.Create a program that converts meters to,
        // kilometers formatted to the second decimal point.
        static void Main(string[] args)
        {
            double meters =int.Parse(Console.ReadLine());
            ConvertMeters (meters);
        }
        public static void ConvertMeters (double input)
        {
            Console.WriteLine($"{(input / 1000):f2}");
        }
    }
}
