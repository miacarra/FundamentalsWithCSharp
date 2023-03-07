using System;

namespace PadawanEuipment
{
    class PadawanEquipment
    {
        //  Yoda is starting his newly created Jedi academy.So, he asked master John to buy the needed equipment.
        // The number of items depends on how many students will sign up. The equipment for each Padawan contains:
        //•	Lightsaber
        //   •	Belt
        //   •	Robe
        //   You will be given the amount of money John has, the number of students and the prices of each item. Calculate if John has enough money to buy equipment for each Padawan or how much more money he needs.
        //   There are some additional requirements: 
        //•	Lightsabres sometimes break, so John should buy 10% more (taken from the students' count), rounded up to the next integer.
        //•	Every sixth belt is free.
        static void Main(string[] args)
        {
           //double resultTruncate = Math.Truncate(7/ 1.5);
            //double resultRound = Math.Round(7/ 1.5);
            //double resultCeiling = Math.Ceiling(7/1.5);
            //double result = 7 / 1.5;

            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
           // double beltsNeeded=students - Math.Ceiling(students / 6.0);
            double lightSaberExp = lightsaberPrice * Math.Ceiling(students * 1.1);
            double robeExp = robePrice * students;
            double beltExp = beltPrice * (students - (students /6));
            double totalExp = lightSaberExp + beltExp + robeExp;
            if (budget >= totalExp)
            {
                Console.WriteLine($"The money is enough - it would cost {totalExp:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {(totalExp-budget):f2}lv more.");
            }
        }
    }
}
