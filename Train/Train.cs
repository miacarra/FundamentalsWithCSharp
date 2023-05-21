using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Train


{
    internal class Train
    {
        static void Main(string[] args)
        {
            List<int> currentPassengersState = Console.ReadLine().Split(' ', StringSplitOptions.None).Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            //int traingLength = currentPassengersState.Count;
            int passengers;
            int freeSeats;
            string input = Console.ReadLine();
            do
            {
                if (input == "end")
                    break;

                List<string> inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (inputArr[0] == "Add")
                    currentPassengersState.Add(int.Parse(inputArr[1].ToString()));

                else if (int.TryParse(inputArr[0].ToString(), out passengers))
                {

                 //   if ((passengers <= maxCapacity) && currentPassengersState.FindIndex(x=>x==0)) 
                    //currentPassengersState(currentPassengersState.First(x => x==0), passengers);
       
                        for (int i = 0; i < currentPassengersState.Count; i++)
                        {
                            freeSeats = maxCapacity - currentPassengersState[i];

                        if (freeSeats <= 0)
                            continue;

                        else if (freeSeats > 0 && freeSeats >= passengers)
                        {
                            currentPassengersState[i] += passengers;
                            passengers -= freeSeats;
                            break;
                        }
                        //else
                        //{
                        //    passengers -= freeSeats;
                        //    currentPassengersState[i] += freeSeats;
                        //}
                        //if (passengers <= 0)
                        //    break;
                    }
            }
                
        input= Console.ReadLine();
            } while (input != "end");
            if (input == "end")
                PrintResult(currentPassengersState);
        }
        static void PrintResult(List<int> input)
        {
            Console.WriteLine(string.Join(" ",input));
        }
    }
}