using System.Globalization;

namespace PrintTriangle
{
    internal class PrintTriangle
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= input; i++)
            {
                PrintLine(1, i);
                Console.WriteLine();
            }
            for (int i = input-1; i>0; i--)
            {
                PrintLine(1, i);
                Console.WriteLine();
            }
        } 
static void PrintLine(int start,int end)
        {
            for (int j = start;j<=end;j++)
            {
                Console.Write(j + " ");
            }
        }

    }
}