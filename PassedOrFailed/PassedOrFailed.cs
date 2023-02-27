using System;

namespace PassedOrFailed
{
    class PassedOrFailed
    {
        static void Main(string[] args)
        {
                                            //            3.Passed or Failed
                                            //Modify the program from the previous problem, so it will print "Failed!", if the grade is lower than 3.00.
                                            //Input
                                            //The input comes as a single double number.



            double grade=double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {

                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
