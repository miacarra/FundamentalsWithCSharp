namespace AddAndSubtract
{
    internal class AddAndSubtract
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int sum = AddNumbers(number1, number2);
            int result=subtractNumbers(sum, number3);
            PrintResult(result);
        }
        static int AddNumbers(int input1, int input2)
        { 
        return input1+ input2;
        }
        static int subtractNumbers(int input1, int input2)
        {
            return input1 - input2;
        }
        static void PrintResult(int input)
        {
            Console.WriteLine(input);
        }
    }
}