namespace CalculateRectangleArea
{
    internal class CalculateRectangleArea
    {
        static void Main(string[] args)
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double result = CalculateArea(side1,side2);
            PrintResult(result);
        }
        static double CalculateArea(double input1,double input2)
        {
            double area = input1 * input2;
            return area;        
        }
        static void PrintResult(double input)
        {
            Console.WriteLine(input);
        }

    }
}