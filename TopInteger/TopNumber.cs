namespace TopInteger
{
    internal class TopNumber
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());
            for (int number = 0; number < endRange; number++)
            {
                if (CheckTopNumbers(number))
                {
                    Console.WriteLine(number);
                    continue;
                }
                else if(CheckDivisibleBy8(number.ToString()) &&
                        CheckOddDigits(number.ToString()))
                     Console.WriteLine(number);
            }
        }
        static bool CheckDivisibleBy8(string input)
        {
            double sum = 0;
            foreach (char sym in input.ToCharArray())
                sum += int.Parse(sym.ToString());

            if (sum % 8 == 0)
                return true;
            else
                return false;
        }
        static bool CheckOddDigits(string input)
        {
            bool containsOdd = false;
            foreach (char sym in input.ToCharArray())
            {
                if (int.Parse(sym.ToString()) % 2 == 1)
                {
                    containsOdd = true;
                    break;
                }
            }
            return containsOdd;
        }
        static bool CheckTopNumbers(int input)
        {
            bool isTopNumber = false;
            if (input == 17 ||
                input == 161 ||
                input == 251 ||
                input == 4310 ||
                input == 123200)
                isTopNumber = true;

            return isTopNumber;
        }

    }
}