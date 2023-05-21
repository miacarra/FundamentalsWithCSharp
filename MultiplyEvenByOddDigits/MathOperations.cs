namespace MathOperations
{
    internal class MathOperations
    {
        static void Main(string[] args)
        {
            double input1 = double.Parse(Console.ReadLine());
            char Mathoperator = char.Parse(Console.ReadLine());
            double input2 = double.Parse(Console.ReadLine());
            switch (Mathoperator)
            {
                case '+':
                    AddNumbers(input1, input2);
                    break;
                case '-':
                    SubtractNumbers(input1, input2);
                    break;
                case '*':
                    MultiplyNumbers(input1, input2);
                    break;
                case '/':
                    DivideNumbers(input1, input2);
                    break;

            }
        }
        static void AddNumbers(double input1, double input2)
        {
            Console.WriteLine(input1 + input2);
        }
        static void SubtractNumbers(double input1, double input2)
        {
            Console.WriteLine(input1 - input2);
        }

        static void MultiplyNumbers(double input1, double input2)
        {
            Console.WriteLine(input1 * input2);
        }
        static void DivideNumbers(double input1, double input2)
        {
            Console.WriteLine(input1 / input2);
        }

    }
}
