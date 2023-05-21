using System.ComponentModel.Design;

namespace MultiplyEvensByOdds
{
    internal class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
                string input = Console.ReadLine();
                double sumEvens = GetSumOfEvenValues(input);
                double sumOdds = GetSumOfOddValues(input);
                PrintResult(sumEvens, sumOdds);
        }
        static bool isPositive(string input)
        { 
        if (int.Parse(input)>0)
                return true;
        else return false;  
        }
        static int GetSumOfEvenValues(string input)
        {
            int result = 0;
            int length = input.Length;
                if(isPositive(input))
            {
                foreach(char sym in input)
                {
                    if(int.Parse(sym.ToString())%2==0)
                            result += int.Parse(sym.ToString());
                }
            }
            else
            {
                for (int i = 1; i < length; i++)
                {
                    if (int.Parse(input[i].ToString()) % 2 == 0)
                        result += int.Parse(input[i].ToString());
                }
            }
            return result;
        }

            static int GetSumOfOddValues(string input)
        {
            int result = 0;
            int length = input.Length;
            if (isPositive(input))
            {
                foreach (char sym in input)
                {
                    if (int.Parse(sym.ToString()) % 2 != 0)
                        result += int.Parse(sym.ToString());
                }
            }
            else
            {
                for (int i = 1; i < length; i++)
                {
                    if (Math.Abs(int.Parse(input[i].ToString())) % 2 != 0)
                        result += Math.Abs(int.Parse(input[i].ToString()));
                }
            }
            return result;

        }
        static void PrintResult(double input1, double input2)
        {
            Console.WriteLine(input1 * input2);
        }
    }
}