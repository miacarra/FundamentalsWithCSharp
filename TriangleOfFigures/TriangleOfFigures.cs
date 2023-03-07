using System;

namespace TriangleOfFigures
{
    class TriangleOfFigures
    {

        //        Write a program, which receives a number – n and prints a triangle from 1 to n.
        //Constraints
        //•	n will be in the interval [1...20].

        static void Main(string[] args)

        
        {
            int input = int.Parse(Console.ReadLine());
            // int counter = 0;
            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " "); 
                }

                Console.WriteLine();
            }
        }
    }
}
