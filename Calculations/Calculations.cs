using System.Diagnostics.CodeAnalysis;

namespace Calculations
{
    internal class Calculations
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine()); 
            switch (operation)
            {
                case "add":
                    SumNumbers(input1,input2);
                    break;
                case "subtract":
                    SubtractNumbers(input1, input2);
                    break;
                case "divide":
                    DivideNumbers(input1, input2);
                    break;
                case "multiply":
                    MultiplyNumbers(input1, input2);
                    break;
            }
        }

        static void SumNumbers(int input1, int input2)
        {
            Console.WriteLine(input1 + input2);
        }
        static void SubtractNumbers(int input1, int input2)
        {
            Console.WriteLine(input1 - input2);
        }
        static void DivideNumbers(int input1, int input2)
        {
            Console.WriteLine(input1/input2);
        }
        static void MultiplyNumbers(int input1, int input2)
        {
            Console.WriteLine(input1*input2);
        }

    }
}