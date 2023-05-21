using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] inputArr = Console.ReadLine()
                                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();
            int index = int.Parse(Console.ReadLine());
            ExchangeMembersOfArray(inputArr, index);
        }
        static int[] ExchangeMembersOfArray(int[] input, int inputIndex)
        {
            int index=0;
            int length = input.Length;
            int[] current = new int[length - inputIndex];
            int[] result = new int[length];
            for (int i = inputIndex; i < length; i++)
            {
                result[index] = input[i];
                index++;
            }
            for (int j = inputIndex + 1; j < length; j++)
            {
                index = 0;
                result[j] = input[index];
                index++;
            }
            return result;
        }
        static int GetMaxEvenElement(int[] input, string definition)
        {
            int length = input.Length;
            int maxNumber = int.MinValue;
            int index = 0;
            for (int i = 0; i < length; i++)
            {
                if (input[i] % 2 == 0 && input[i] > maxNumber)
                {
                    maxNumber = input[i];
                    index = i;
                }
                else
                    continue;
            }
            return index;
        }
        static int GetMinEvenElement(int[] input, string definition)
        {
            int length = input.Length;
            int index = 0;
            int minNumber = int.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (input[i] % 2 == 0 && input[i] < minNumber)
                {
                    minNumber = input[i];
                    index = i;
                }
                else
                    continue;
            }
            return index;
        }
        static int GetMaxOddElement(int[] input, string definition)
        {
            int length=input.Length;
            int maxNumber = int.MinValue;
            int index = 0;
            for (int i=0; i<length;i++)
            {
                if (input[i] % 2 == 1 && input[i] > maxNumber)
                {
                    maxNumber = input[i];
                    index = i;
                }
                else
                    continue;
            }
            return index;
        }
        static int GetMinOddElement(int[] input, string definition)
        {
            int length = input.Length;
            int index = 0;
            int minNumber = int.MaxValue;
            for (int i=0;i<length;i++)
            {
                if (input[i] % 2 == 1 && input[i] < minNumber)
                {
                    minNumber = input[i];
                    index = i;
                }
                else
                    continue;
            }
            return index;
        }
        
    }
}