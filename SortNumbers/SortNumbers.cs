using System;

namespace SortNumbers
{
    class SortNUmbers
    {

        //Create a program that receives three real numbers and sorts them in descending order.
        //Print each number on a new line.
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            if (number > number2 && number > number3)
            {
                if (number2 > number3)
                {
                    Console.WriteLine(number);
                    Console.WriteLine(number2);
                    Console.WriteLine(number3);
                }
                else
                {
                    Console.WriteLine(number);
                    Console.WriteLine(number3);
                    Console.WriteLine(number2);
                }
            }
            else if (number2 > number && number2 > number3)
            {
                if (number > number3)
                {
                    Console.WriteLine(number2);
                    Console.WriteLine(number);
                    Console.WriteLine(number3);
                }
                else
                {
                    Console.WriteLine(number2);
                    Console.WriteLine(number3);
                    Console.WriteLine(number);
                }
            }
            else
            {
                if (number > number2)
                {
                    Console.WriteLine(number3);
                    Console.WriteLine(number);
                    Console.WriteLine(number2);
                }
                else
                {
                    Console.WriteLine(number3);
                    Console.WriteLine(number2);
                    Console.WriteLine(number);
                }

            }
        }
    }
}
