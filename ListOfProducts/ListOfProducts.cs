using System.Security.Cryptography.X509Certificates;

namespace ListOfProducts
{
    internal class ListOfProducts
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> products = ReadList(count);
            products.Sort();
            
            PrintResult(products);

        }
        static List<string> ReadList(int count)
        {
            List<string> output = new List<string>();
            for (int i = 0; i < count; i++)
            {
                output.Add(Console.ReadLine());
            }
            return output;

        }
        static void PrintResult(List<string> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i+1}.{input[i]}");
            }
        }
    }
}