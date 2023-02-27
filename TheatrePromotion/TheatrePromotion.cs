using System;

namespace TheatrePromotion
{
    class TheatrePromotion
    {
        static void Main(string[] args)
        {

                                    // A theatre sails tickets at discount and a program is needed to calculate the price of a single ticket.
                                    // If the given age does not fit one of the categories, you should print "Error!".
                                    //The prices of the tickets are as follows:
                                    //Day / Age    0 <= age <= 18  18 < age <= 64  64 < age <= 122
                                    //Weekday         12$	              18$	          12$
                                    //Weekend         15$	              20$             15$
                                    //Holiday          5$	              12$             10$
                                    //The input comes in two lines. On the first line you will receive the type of day.On the second – the age of the person.
                                    //Output
                                    //Print the price of the ticket according to the table or "Error!", if the age is not in the table.
                                    //Constraints
                                    //•	The age will be in the interval[-1000…1000].
                                    //•	The type of day will always be valid. 

            string day =Console.ReadLine();
            int age =int.Parse(Console.ReadLine());
            int price=0;
            string output = string.Empty;


            if (age < 0 || 122 < age)
            {
                output = "Error!";
            }

            else if (0 <= age && age <= 18)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 5;
                        break;
                }
                output = $"{price}$";
            }
            else if (18 < age && age <= 64)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 18;
                        break;
                    case "Weekend":
                        price = 20;
                        break;
                    case "Holiday":
                        price = 12;
                        break;
                }
                output = $"{price}$";
            }
            else if (64 < age && age <= 122)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 10;
                        break;
                }
                output = $"{price}$";
            }
           

            Console.WriteLine(output);

        }
    }
}
