namespace FactorialDivision
{
    internal class FactorialDivision
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            decimal result = GetFactoriel(number1)/GetFactoriel(number2);
            PrintResult(result);

        }

        static decimal GetFactoriel(double input)
        {
            
            if (input == 1 || input == 0)
                return 1;
            decimal result = 1;
            for (int i = (int)input; i >0; i--)
            {
                result *= i;
            }
            
           return result;
        }
        static void PrintResult(decimal input)
        {
            Console.WriteLine($"{input:f2}");
        }
    }
}