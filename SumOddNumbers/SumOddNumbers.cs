using System;

namespace SumOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints on a new line the next n odd numbers(starting from 1).
            //On the last row print the sum of all n odd numbers.
            //Input
            //A single number n is read from the console, indicating how many odd numbers need to be printed.
            //Output
            //Print the next n odd numbers, starting from 1, separated by new lines.On the last line, print the sum of these numbers.
            //Constraints
            //•	n will be in the interval[1…100]


            //using do while loop     
            //int input = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int counter = 0;
            //int number = 1;
            //do
            //{
            //    if (number % 2 != 0)
            //    {
            //        Console.WriteLine(number);
            //        sum += number;
            //        counter++;
            //        number++;
            //    }
            //    else
            //    {
            //        number++;
            //    }
            //} while (counter < input);
            //Console.WriteLine($"Sum: {sum}");

            //usinf for loop
            
            int input =int.Parse(Console.ReadLine());
            int sum = 0;
            int number=1;

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(number);
                sum += number;
                number+=2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
