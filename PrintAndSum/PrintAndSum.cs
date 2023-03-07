using System;

namespace PrintAndSum
{
    class PrintAndSum
    {


                                    ////You will receive two whole numbers from the console representing the start and the end of a sequence of numbers.
                                    ////    Your task is to print two lines:
                                    ////    •	On the first line, print all numbers from the start of the sequence to the end inclusive
                                    ////    •	On the second line, print the sum of the sequence in the format: "Sum: {sum}"

        static void Main(string[] args)
      {
            int start =int.Parse(Console.ReadLine());
            int end =int.Parse(Console.ReadLine());
            int sum = 0;
            for (int number = start; number <= end; number++)
            {
                Console.Write($"{number} ");
                sum += number;
            }
            Console.WriteLine($"\n Sum: {sum}");
        }
    }
}
