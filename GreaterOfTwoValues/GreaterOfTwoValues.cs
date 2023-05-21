using System.Collections.Specialized;
using System.Dynamic;

namespace GreaterOfTwoValues
{
    internal class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int num1 = GetInt();
                    int num2 = GetInt();
                    Console.WriteLine(GetMaxValue(num1, num2));
                    break;
                case "char":
                    char sym1 = GetChar();
                    char sym2 = GetChar();
                    Console.WriteLine(GetMaxValue(sym1, sym2));
                    break;
                default:
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    Console.WriteLine(GetMaxValue(str1, str2));
                    break;
            }

        }
        static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }
        static char GetChar()
        {
            return char.Parse(Console.ReadLine());
        }
        static string GetMaxValue(string input1, string input2)
        {
            if (input1.CompareTo(input2) > 0)
                return input1;
            else
                return input2;
        }
        static char GetMaxValue(char input1, char input2)
        {
            return (char)Math.Max(input1, input2);
        }
        static int GetMaxValue(int input1, int input2)
        {
            return Math.Max(input1, input2);
        }
    }
}
