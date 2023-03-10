using System;

namespace EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int lastDigit = int.Parse(input[input.Length - 1].ToString());
            //int input =int.Parse(Console.ReadLine());
            //int lastDigit=0;
            //if (Math.Abs(input) > 10)
            //{
            //    lastDigit = (input % 10);
            //}
            //else 
            //{
            //    lastDigit = input;
            //}

            switch (lastDigit)
            {
                case 1:
                    Console.WriteLine($"one");
                    break;
                case 2:
                    Console.WriteLine($"two");
                    break;
                case 3:
                    Console.WriteLine($"three");
                    break;
                case 4:

                    Console.WriteLine($"four");
                    break;
                case 5:
                    Console.WriteLine($"five");
                    break;
                case 6:
                    Console.WriteLine($"six");
                    break;
                case 7:
                    Console.WriteLine($"seven");
                    break;
                case 8:
                    Console.WriteLine($"eight");
                    break;
                case 9:
                    Console.WriteLine($"nine");
                    break;
                case 0:
                    Console.WriteLine($"zero");
                    break;
            }
       
        }

        
            
            
            
            }
}
