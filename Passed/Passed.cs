using System;

namespace Passed
{
    class Passed
    {
        static void Main(string[] args)
        {
            //  Create a program that receives a single number as an input representing a grade.
            //Print in the console:
            //•	"Passed!" if the grade is equal or more than 3.00.
            double grade = double.Parse(Console.ReadLine());


            if (grade >= 3)

            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
