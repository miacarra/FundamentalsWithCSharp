namespace SmallestOfThreeIntegers
{
    internal class SmallestOfThreeIntegers
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            
            PrintResult(GetSmallest(number1,number2,number3));
        
        }
        static int GetSmallest(int input1, int input2,int input3)
        {
            int[] inputArr = { input1, input2, input3 };

            return inputArr.Min(); 

        }
        static void PrintResult(int input)
        {
            Console.WriteLine(input);
        }
    }
}