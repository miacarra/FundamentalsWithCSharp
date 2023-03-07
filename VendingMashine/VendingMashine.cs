
using System;
 
namespace VendingMashine
 {

        class VendingMashine
        {

        // Write a program that accumulates coins.Until the "Start" command is given, you will receive coins, and only the valid ones
        // should be accumulated. Valid coins are:	0.1, 0.2, 0.5, 1 and 2 If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.
        //On the next lines, until the "End" command is given, you will start receiving products,
        //which a customer wants to buy. The vending machine has only:
        //•	"Nuts" with a price of 2.0
        //•	"Water" with a price of 0.7
        //•	"Crisps" with a price of 1.5
        //•	"Soda" with a price of 0.8
        //•	"Coke" with a price of 1.0
        //If the customer tries to purchase a not existing product, print "Invalid product".
        //When a customer has enough money to buy the selected product, print "Purchased {product name}",
        //otherwise print "Sorry, not enough money" and continue to the next line.
        //When the "End" command is given print the reminding balance, formatted to the second decimal point: "Change: {money left}".

        static void Main(string[] args)
            {
                string input = Console.ReadLine();
                double insertedMoney = 0;
                double inputCoins = 0;
                //double change;
                while (input != "Start")
                {
                    if (double.TryParse(input, out insertedMoney))
                    {
                        switch (insertedMoney)
                        {
                            case 0.1:
                            case 0.2:
                            case 0.5:
                            case 1.0:
                            case 2.0:
                                inputCoins += insertedMoney;
                                break;
                            default:
                                Console.WriteLine($"Cannot accept {insertedMoney}");
                                break;

                        }
                    }
                    else if (input == "Start")
                    {
                        break;
                    }
                    input = Console.ReadLine();
                }

                do
                {
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "Nuts":
                            inputCoins = PurchaseNuts(inputCoins);
                            break;
                        case "Water":
                            inputCoins = PurchaseWater(inputCoins);
                            break;
                        case "Crisps":
                            inputCoins = PurchaseCrisps(inputCoins);
                            break;
                        case "Soda":
                            inputCoins = PurchaseSoda(inputCoins);
                            break;
                        case "Coke":
                            inputCoins = PurchaseCoke(inputCoins);
                            break;
                        case "End":
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }

                } while (input != "End");



                Console.WriteLine($"Change: {inputCoins:f2}");

            }




            public static double PurchaseNuts(double input)
            {
                if (input < 2.0)
                {
                    Console.WriteLine($"Sorry, not enough money");

                }
                else
                {
                    Console.WriteLine($"Purchased nuts");
                    input -= 2;
                }
                return input;
            }


            public static double PurchaseCoke(double input)
            {
                if (input < 1.0)
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased coke");
                    input -= 1;
                }
                return input;

            }
            public static double PurchaseWater(double input)
            {

                if (input < 0.7)
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased water");

                    input -= 0.7;
                }
                return input;
            }
            public static double PurchaseSoda(double input)
            {

                if (input < 0.8)
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased soda");
                    input -= 0.8;
                }
                return input;
            }
            public static double PurchaseCrisps(double input)
            {
                if (input < 1.5)
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased crisps");
                    input -= 1.5;

                }
                return input;
            }
        }
    }

