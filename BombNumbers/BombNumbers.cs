using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    internal class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> inputList = ReadList();
            int[] bombParameters = ReadArray();
            int bombInfo = bombParameters[0];
            while (CheckBomb(inputList, bombInfo))
            {
                int bombIndex = inputList.FindIndex(x => x == bombInfo);
                int bombPower = bombParameters[1];
            DetonateBomb(inputList, bombIndex, bombPower);
            }
                
            //inputList.RemoveRange(bombIndex, bombPower);
            //inputList.RemoveRange(bombIndex-bombPower,bombPower*2);
            PrintResult(inputList);

        }
        static bool CheckBomb(List<int> input, int number)
        {
            if (input.Contains(number))
                    return true;
            return false;
        }
        static List<int> DetonateBomb(List<int> inputList, int bombIndex, int bombPower)
        {
            int length=inputList.Count;
            int startIndex = bombIndex - bombPower;
            int detonationRange = bombPower*2+1;
            if (startIndex < 0)
                {
                detonationRange+= startIndex;
                startIndex = 0;
                }
               else if(bombPower>length-bombIndex)
                      detonationRange+= length- bombIndex;
            //    inputList.RemoveRange(bombIndex - bombPower, bombPower * 2 + 1);
            inputList.RemoveRange(startIndex, detonationRange);
            return inputList;
        }

        static int[] ReadArray()
        {
            return (Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            
        }

        static List<int> ReadList()
        {
         return Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();
        
        }
        static void PrintResult(List<int> input)
        {
            Console.WriteLine(input.Sum());
        }

    }
}