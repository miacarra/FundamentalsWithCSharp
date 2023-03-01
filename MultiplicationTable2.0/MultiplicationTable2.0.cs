using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        
        {
            //  Rewrite the program from the previous task so it can receive the multiplier from the console.
            //  Print the table with the multiplier in the interval from the given number to 10.
            //  If the given multiplier is more than 10, print only one row with the integer, the given multiplier,
            //  and the product.See the examples below for more information.
            //Output
            //Print every row of the table in the following format:
            // { theInteger} X { times} = { product}
            // Constraints
            //•	The integer will be in the interval[1…100]

            int number =int.Parse(Console.ReadLine());
            int input = int.Parse(Console.ReadLine());
            for (int multiplier = input; multiplier <= 10; multiplier++)
            {
                Console.WriteLine($"{number} X {multiplier} = {number*multiplier}");
            }
            if (input > 10)
            {
                Console.WriteLine($"{number} X {input} = {number * input}");
            }
        }
    }
}
