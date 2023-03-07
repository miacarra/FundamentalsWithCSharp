using System;

namespace RageExpences
{
    class RageExpences
    {
        static void Main(string[] args)
        {
            int lostGames =int.Parse(Console.ReadLine());
            double headsetPrice =double.Parse(Console.ReadLine());
            double mousePrice =double.Parse(Console.ReadLine());
            double keyboardPrice =double.Parse(Console.ReadLine());
            double displayPrice =double.Parse(Console.ReadLine());
            double rageExpences = 0;
            int counter = 0;
           
            for (int i =1 ; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    rageExpences += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    rageExpences += mousePrice;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    rageExpences += keyboardPrice;
                     counter++;
                }
                if (counter == 2)
                {
                    rageExpences += displayPrice;
                    counter = 0;
                }
            }

            Console.WriteLine($"Rage expenses: {rageExpences:f2} lv.");

        }
    }
}
