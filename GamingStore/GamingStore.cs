using System;

namespace GamingStore
{
    class GamingStore
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string input;
            double spentMoney = 0;
            bool isOutOfMoney = false;
            do
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "OutFall 4":
                        if (budget < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                            
                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                            spentMoney += 39.99;
                            budget -= 39.99;
                            if (budget <= 0)
                            {
                                isOutOfMoney = true;
                                break; 
                            }
                        }
                        break;
                    case "CS: OG":
                        if (budget < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                            spentMoney += 15.99;
                            budget -= 15.99;
                            if (budget <= 0)
                            {
                                isOutOfMoney = true;
                                break;
                            }
                        }
                        break;
                    case "Zplinter Zell":
                
                    if (budget < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                            spentMoney += 19.99;
                            budget -= 19.99;
                            if (budget <= 0)
                            {
                                isOutOfMoney = true;
                                break;
                            }
                        }
                        break;
                    case "Honored 2":
                        if (budget < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                            spentMoney += 59.99;
                            budget -= 59.99;
                            if (budget <= 0)
                            {
                                isOutOfMoney = true;
                                break;
                            }
                        }
                        break;
                    case "RoverWatch":

                        if (budget < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                 
                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                            spentMoney += 29.99;
                            budget -= 29.99;
                            if (budget <= 0)
                            {
                                isOutOfMoney = true;
                                break;
                            }
                        }
                        break;
                    case "Udge":

                        if (budget < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        else
                        {
                            Console.WriteLine($"Bought {input}");
                            spentMoney += 39.99;
                            budget -= 39.99;
                            if (budget <= 0)
                            {
                                isOutOfMoney = true;
                                break;
                            }
                        }
                        break;
                    case "RoverWatch Origins Edition":

                        if (budget < 39.99)
                        {
                            Console.WriteLine("Too Expensive");

                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                            spentMoney += 39.99;
                            budget -= 39.99;
                            if (budget <= 0)
                            {
                                isOutOfMoney = true;
                                break;
                            }
                        }
                        break;
                    case "Game Time":
                        break;
                    default:
                        Console.WriteLine($"Not Found");
                        break;
                }
                if (isOutOfMoney)
                {
                    break;
                }
            } while (input != "Game Time");
            if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${budget:f2}");
            }
            else if (isOutOfMoney)
                Console.WriteLine("Out of money!");
        }

    }
}
