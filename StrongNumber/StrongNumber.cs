using System;

namespace StrongNumber
{
    class StrongNumber
    {
                                    //        Write a program that receives a single integer and calculates if it's strong or not.
                                    //        A number is strong, if the sum of the factorials of each digit is equal to the number itself.
                                    //        Example: 145 is a strong number, because 1! + 4! + 5! = 145. 
                                    //        Print "yes", if the number is strong and "no", if the number is not strong.

        static void Main(string[] args)
        
        {
            string input =Console.ReadLine();

            int initialInput =int.Parse(input);
            int number;
            int productFactoriel = 1;
            int sumFactoriel = 0;
            bool isStrong = false;
            for (int index = input.Length - 1; index >= 0; index--)
            {
                number = int.Parse(input[index].ToString());
                //===================================Calculate number!
                for (int i = number; i >= 1; i--)
                {
                    productFactoriel = productFactoriel*i;
                    
                }
                sumFactoriel += productFactoriel;
                productFactoriel =1;
            }
            
                if (sumFactoriel == initialInput)
                {
                    isStrong = true;
                  
                }
            
            
            if (isStrong)
            {
                Console.WriteLine($"Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
