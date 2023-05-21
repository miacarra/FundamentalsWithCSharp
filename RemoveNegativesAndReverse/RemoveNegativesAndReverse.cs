using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace RemoveNegativesAndReverse
{
    internal class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            List<int> output = input.Where(x => x > 0).Reverse().ToList();
            if (output.Count == 0)
                Console.WriteLine($"empty");
            else
            {
             Console.WriteLine(string.Join(' ', output.ToList()));
            }

        }
    }
}