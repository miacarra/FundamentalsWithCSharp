using System;

namespace DivisibleBy3
{
    class NumbersDivisibleBy3
    {
        static void Main(string[] args)
        {
            //Create a program, which prints all the numbers from 1 to 100,
            //  that are divisible by 3.You have to use a single for loop.The program should not receive input.


            for (int number = 3; number < 100; number+=3)
            {
                Console.WriteLine(number);
            }
        }
    }
}
