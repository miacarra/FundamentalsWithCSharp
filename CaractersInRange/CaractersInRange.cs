namespace CaractersInRange
{
    internal class CaractersInRange
    {
        //-------------------------------------------------option 1 - determine start and end separately and execute loop

        static void Main(string[] args)
        {
            char inputStart = char.Parse(Console.ReadLine());
            char inputEnd = char.Parse(Console.ReadLine());
            PrintCharactersInRange(inputStart, inputEnd);
        }
        static void PrintCharactersInRange(char start, char end)
        {

            if (!isBigger(start, end))
            {
                for (int i = 1 + (int)start; i < end; i++)
                    Console.Write($"{(char)i} ");
            }
            else
            {
                for (int j = 1 + (int)end; j < start; j++)
                    Console.Write($"{(char)j} ");
            }
        }
        static bool isBigger(char input1, char input2)
        {
            if ((int)input1 > (int)input2)
                return true;
            else
                return false;

        }
        //------------------------------------------------------------------------ use Math.Min
        //static void Main(string[] args)
        //{
        //    char input1 = char.Parse(Console.ReadLine());
        //    char input2 = char.Parse(Console.ReadLine());
        //    PrintCharactersInRange(input1, input2);
        //}

        //static void PrintCharactersInRange(char symbol1, char symbol2)
        //{
        //    int firstNum = Math.Min((int)symbol1, (int)symbol2) + 1;
        //    int secondNum = Math.Max((int)symbol1, (int)symbol2) - 1;

        //    for (int i = firstNum; i <= secondNum; i++)
        //    {
        //        Console.Write($"{(char)i} ");
        //    }


        
    }    
}