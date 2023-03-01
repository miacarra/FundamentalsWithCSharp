using System;

namespace EvenNumber
{
    class EvenNumber
    {
        static void Main(string[] args)
        {
            //Create a program that reads a sequence of numbers.If the number is even, print 
            //its absolute value in the following format: "The number is: {number}"
            //and terminate the program. If the number is odd, print "Please write an even number." and continue reading numbers.


                                                                                        // 1st optiom
             int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(input)}");

            }
            else
            {
                while (input % 2 != 0)
                {
                    Console.WriteLine($"Please write an even number.");
                    input = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"The number is: {Math.Abs(input)}");
            }


            //                                                                              //2nd option
            //int input = int.Parse(Console.ReadLine());
            //while (true)
            //{
            //    if (input % 2 == 0)
            //    {
            //        Console.WriteLine($"The number is: {Math.Abs(input)}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Please write an even number.");
            //        input = int.Parse(Console.ReadLine());
            //    }
            //}
        }

    }
}


