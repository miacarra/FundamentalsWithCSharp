using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
namespace SumAdjacentEqualNumbers
{
    internal class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {

            List<double> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => (double.Parse(x))).ToList();
            int length = input.Count;
            for (int i = 0; i < input.Count-1; i++)
            {
                if (input[i] == input[i+1])
                {
                    input[i] += input[i+1];
                    input.RemoveAt(i+1);
                    i=-1;
                }
                
            }

            PrintResult(input);
        } 

        static void PrintResult(List<double> input)
{
    Console.WriteLine(string.Join(" ", input));
}
    }
}