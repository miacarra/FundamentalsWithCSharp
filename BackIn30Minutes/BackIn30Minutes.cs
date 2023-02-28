using System;

namespace BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            //            Every time John tries to pay the bills he sees on the cash desk the sign: "I will be back in 30 minutes".
            //            One day John was tired of waiting and decided he needed a program, which prints the time after 30 minutes,
            //            so he could come back after exactly 30 minutes.He is not able to write the program by himself, so he asks for help.
            //Input
            //Two numbers are read from the console:
            //•	The first number is hours and will be between 0 and 23.
            //•	The second number is minutes and will be between 0 and 59.
            //Output
            //Print on the console the time after 30 minutes.The result should be in format hh:mm.The hours may contain one or two numbers and the minutes always have two numbers(with leading zero).



            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int updatedHour;
            int updatedMin = minutes + 30;
            string message=string.Empty;

            if (minutes < 30)
            {
                //updatedMin = minutes + 30;
                updatedHour = hour;
                message = $"{updatedHour}:{updatedMin:D2}";
            }
            else if (minutes >= 30)
            {
                updatedHour = hour + 1;
                updatedMin -= 60;

                if (updatedHour == 24)
                {
                    updatedHour = 0;

                }
                message = $"{updatedHour}:{updatedMin:D2}";
            }

            Console.WriteLine(message);
        }
     }
}
