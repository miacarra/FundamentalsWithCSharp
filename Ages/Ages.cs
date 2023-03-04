using System;

namespace Ages
{
    class Ages
    {

        //Write a program that determines if a person is baby, child, teenager, adult or elder 
        //based on the given age.The boundaries are:
        //•	0-2 – baby
        //•	3-13 – child
        //•	14-19 – teenager
        //•	20-65 – adult
        //•	>= 66 – elder
        //•	All the values are inclusive.

        //1-st  option invoke PrintAge(input) method-----------------------------------------------------
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            PrintAge(age);


        }
        public static void PrintAge(int input)
        {
            string message = string.Empty;
            if (0 <= input && input < 3)

            {
                Console.WriteLine("baby");
            }
            else if (3 <= input && input < 14)

            {
                Console.WriteLine("child");
            }
            else if (14 <= input && input < 20)

            {
                Console.WriteLine("teenager");
            }
            else if (20 <= input && input < 66)

            {
                Console.WriteLine("adult");
            }
            else if (66 <= input)

            {
                Console.WriteLine("elder");

            }




            // 2-nd option - single Main method ----------------------------------------------------------------------

            /// static void Main(string[] args)
            //        {
            //            int age = int.Parse(Console.ReadLine());

            //            if (0 <= age && age< 3)

            //            {
            //                Console.WriteLine("baby");
            //            }
            //            else if (3 <= age && age< 14)

            //            {
            //                Console.WriteLine("child");
            //            }
            //            else if (14 <= age && age < 20)
            //            {
            //                Console.WriteLine("teenager");
            //            }
            //            else if (20 <= age && age < 66)
            //            {
            //                Console.WriteLine("adult");
            //            }
            //            else if (66 <= age)
            //            {
            //                Console.WriteLine("elder");
        }
        //}
    }
}
