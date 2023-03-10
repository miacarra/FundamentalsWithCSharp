using System;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            string result=string.Empty;
            for (int index = (input.Length - 1); index >= 0; index--)
            {
                result += input[index].ToString();
            }
            Console.WriteLine(result);
        }
    }
}
