using System;

namespace MonthPrinter
{
    class MonthPrinter
    {
        static void Main(string[] args)
        {
            // Create a program that receives an integer and prints the matching month. If the number is more
            // than 12 or less than 1, print "Error!".
            //Input
            //You will receive a single integer on a single line.
            //Output
            //If the number is within the boundaries, print the corresponding month, otherwise print "Error!".

            int input = int.Parse(Console.ReadLine());
            string message = string.Empty;
            switch (input)
            {
                case 1:
                    message = "January";
                    break;
                case 2:
                    message = "February";
                    break;
                case 3:
                    message = "March";
                    break;
                case 4:
                    message = "April";
                    break;
                case 5:
                    message = "May";
                    break;
                case 6:
                    message = "June";
                    break;
                case 7:
                    message = "July";
                    break;
                case 8:
                    message = "August";
                    break;
                case 9:
                    message = "September";
                    break;
                case 10:
                    message = "October";
                    break; 
                case 11:
                    message = "November";
                    break; 
                case 12:
                    message = "December";
                    break;
                default:
                    message = "Error!";
            break;
            }
            Console.WriteLine(message);
        }
    }
}
