using System;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
                            // Create a program that receives an integer as an input.
                            // Print the 10 times table for this integer.See the examples below for more information.
                            // Output
                            // Print every row of the table in the following format:
                            // { theInteger} X { times} = { product}
                            //
            int input =int.Parse(Console.ReadLine());
            for (int times = 1; times <= 10; times++)
            {
                Console.WriteLine($"{input} X {times} = {input*times}");
            }

        }
    }
}
