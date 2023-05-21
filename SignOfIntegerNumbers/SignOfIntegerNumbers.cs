using System.ComponentModel.Design;

namespace SignOfIntegerNumbers
{

    class SignOfIntegerNumbers
    {
        static void Main()
        {

        //-----------------------------------------------------------------------------option 1
            PrintResult(int.Parse(Console.ReadLine()));
        }
        static void PrintResult(int input)
        {
            if (input > 0)
                Console.WriteLine($"The number {input} is positive.");
            else if (input == 0)
                Console.WriteLine($"The number {input} is zero.");
            else
                Console.WriteLine($"The number {input} is negative.");
        }

        //------------------------------------------------------------------------------option 2
        //static void Main()
        //{
        //int number = int.Parse(Console.ReadLine());
        //string resultNum = CheckSign(number);
        //Printresult(number, resultNum);

        //}
        //static string CheckSign(int number)
        //{
        //    string result;
        //    if (number > 0)
        //    {
        //        result = "positive";
        //    }
        //    else if (number == 0)
        //    {
        //        result = "zero";
        //    }
        //    else
        //    {
        //        result = "negative";
        //    }
        //    return result;
        //}
        //static void Printresult(int input, string input2)
        //{
        //    Console.WriteLine($"The number {input} is {input2}.");
        //}

    }
}