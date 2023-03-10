using System;

namespace Messages
{
    class Messages
    {

        // using mathematical formula
        //static void Main(string[] args)
        //{

        //    int number = int.Parse(Console.ReadLine());
        //    string input;
        //    int digit;
        //    int offset;
        //    int index;
        //    string result = string.Empty;
        //    for (int i = 0; i < number; i++)
        //    {
        //        input = Console.ReadLine();
        //        digit = int.Parse(input[0].ToString());
        //        offset = (digit - 2) * 3;
        //        index = (offset + (input.Length - 1));
        //        if (digit == 8 || digit == 9)
        //        {
        //            index = offset + input.Length ;
        //            result += (char)(index + 97);
        //        }
        //        else if (digit == 0)
        //        {
        //            result += " ";
        //        }
        //        else
        //        {
        //            result += (char)(index + 97);
        //        }
        //    }
        //    Console.WriteLine(result);

        //}



        // using Switch function
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                int input = int.Parse(Console.ReadLine());
                result += GenerateLetter(input);
            }

            Console.WriteLine(result);
        }
        static string GenerateLetter(int input)
        {
            //input =int.Parse(Console.ReadLine()); 
            string text = string.Empty;
            //for (int j = 0; j < 1; j++)
            //{
            switch (input)
            {
                case 2:
                    text += 'a';
                    break;
                case 22:
                    text += 'b';
                    break;
                case 222:
                    text += 'c';
                    break;
                case 3:
                    text += 'd';
                    break;
                case 33:
                    text += 'e';
                    break;
                case 333:
                    text += 'f';
                    break;
                case 4:
                    text += 'g';
                    break;
                case 44:
                    text += 'h';
                    break;
                case 444:
                    text += 'i';
                    break;
                case 5:
                    text += 'j';
                    break;
                case 55:
                    text += 'k';
                    break;
                case 555:
                    text += 'l';
                    break;
                case 6:
                    text += 'm';
                    break;
                case 66:
                    text += 'n';
                    break;
                case 666:
                    text += 'o';
                    break;
                case 7:
                    text += 'p';
                    break;
                case 77:
                    text += 'q';
                    break;
                case 777:
                    text += 'r';
                    break;
                case 7777:
                    text += 's';
                    break;
                case 8:
                    text += 't';
                    break;
                case 88:
                    text += 'u';
                    break;
                case 888:
                    text += 'v';
                    break;
                case 9:
                    text += 'w';
                    break;
                case 99:
                    text += 'x';
                    break;
                case 999:
                    text += 'y';
                    break;
                case 9999:
                    text += 'z';
                    break;
                case 0:
                    text += ' ';
                    break;
                default:
                    break;
            }
            return text;
        }
    }
}
