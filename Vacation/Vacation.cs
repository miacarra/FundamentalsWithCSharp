using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
                                        //            You will receive three lines from the console:
                                        //•	A count of people who are going on vacation.
                                        //•	Type of the group(Students, Business or Regular).
                                        //•	The day of the week which the group will stay on(Friday, Saturday or Sunday).
                                        //Based on the given information calculate how much the group will pay for the entire vacation.
                                        //The price for a single person is as follows:
	                                                                    // Friday  Saturday    Sunday
                                                              //Students    8.45    9.80    10.46
                                                              //Business    10.90   15.60   16
                                                              //Regular      15     20      22.50
                                        //There are also discounts based on some conditions:
                                        //•	For Students – if the group is 30 or more people, you should reduce the total price by 15 %.
                                        //•	For Business – if the group is 100 or more people, 10 of the people stay for free.
                                        //•	For Regular – if the group is between 10 and 20  people(both inclusively), reduce the total price by 5 %.
            
                                            //Note: You should reduce the prices in that EXACT order!
                                        //As an output print the final price which the group is going to pay in the format: 
                                        //"Total price: {price}"
                                        //The price should be formatted to the second decimal point.



            // only IF-s -------------------------------------------------------
            int customersNumber = int.Parse(Console.ReadLine());
            string customersType = Console.ReadLine();
            string checkInDay = Console.ReadLine();
            double price = 0;
            double finalPrice = 0;
            if (customersType == "Students")
            {
                if (checkInDay == "Friday")
                {
                    price = customersNumber * 8.45;
                    finalPrice = price;
                }
                else if (checkInDay == "Saturday")
                {
                    price = customersNumber * 9.8;
                    finalPrice = price;
                }
                else if (checkInDay == "Sunday")
                {
                    price = customersNumber * 10.46;
                    finalPrice = price;
                }
                if (customersNumber >= 30)
                {
                    finalPrice = finalPrice * 0.85;
                }
            }
            else if (customersType == "Business")
            {
                if (checkInDay == "Friday")
                {
                    price = customersNumber * 10.9;
                    finalPrice = price;
                }
                else if (checkInDay == "Saturday")
                {
                    price = customersNumber * 15.6;
                    finalPrice = price;
                }
                else if (checkInDay == "Sunday")
                {
                    price = customersNumber * 16;
                        finalPrice = price;
                    
                }
                if (customersNumber >= 100)
                {
                    finalPrice -= (price / customersNumber) * 10;
                }
            }
            else if (customersType == "Regular")
            {
                if (checkInDay == "Friday")
                {
                    price = customersNumber * 15;
                    finalPrice = price;
                }
                if (checkInDay == "Saturday")
                {
                    price = customersNumber * 20;
                    finalPrice = price;

                }
                if (checkInDay == "Sunday")
                {
                    price = customersNumber * 22.5;
                        finalPrice = price;
                    
                }
                if (10 <= customersNumber && customersNumber <= 20)
                {
                    finalPrice = finalPrice * 0.95;
                }
            }

            Console.WriteLine($"Total price: {finalPrice:f2}");


            // 1st option - combining if and switch 
            //int customersNumber = int.Parse(Console.ReadLine());
            //string customersType = Console.ReadLine();
            //string checkInDay = Console.ReadLine();
            //double price = 0;
            //double finalPrice = 0;
            //if (customersType == "Students")
            //{
            //    switch (checkInDay)
            //    {
            //        case "Friday":
            //            price = customersNumber * 8.45;
            //            finalPrice = price;
            //            break;
            //        case "Saturday":
            //            price = customersNumber * 9.8;
            //            finalPrice = price;
            //            break;
            //        case "Sunday":
            //            price = customersNumber * 10.46;
            //            finalPrice = price; 
            //            break;
            //    }
            //    if (customersNumber >= 30)
            //    {
            //        finalPrice = finalPrice * 0.85;
            //    }
            //}
            //else if (customersType == "Business")
            //{
            //    switch (checkInDay)
            //    {
            //        case "Friday":
            //            price = customersNumber * 10.9;
            //            finalPrice = price;
            //            break;
            //        case "Saturday":
            //            price = customersNumber * 15.6;
            //            finalPrice = price;
            //            break;
            //        case "Sunday":
            //            price = customersNumber * 16;
            //            finalPrice = price;
            //            break;
            //    }
            //    if (customersNumber >= 100)
            //    {
            //        finalPrice -= (price /customersNumber)* 10;
            //    }
            //}
            //else if (customersType == "Regular")
            //{
            //    switch (checkInDay)
            //    {
            //        case "Friday":
            //            price = customersNumber * 15;
            //            finalPrice = price; 
            //            break;
            //        case "Saturday":
            //            price = customersNumber * 20;
            //            finalPrice = price; 
            //            break;
            //        case "Sunday":
            //            price = customersNumber * 22.5;
            //            finalPrice = price;
            //            break;
            //    }
            //    if (10 <= customersNumber && customersNumber <= 20)
            //    {
            //        finalPrice = finalPrice * 0.95;
            //    }
            //}

            //Console.WriteLine($"Total price: {finalPrice:f2}");
        }
    }
}
