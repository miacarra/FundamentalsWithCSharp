namespace MathPow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double baseI = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            CalculateMathPower(baseI,power);   
          //  PrintResult(CalculateMathPower(baseI, power));
        }
        static void CalculateMathPower(double input1, int input2)
        {
            double result = input1;   
            for (int i = 1; i < input2; i++)
            {
                result*=input1;
            }
            Console.WriteLine(result);
        } 
        
    }
}