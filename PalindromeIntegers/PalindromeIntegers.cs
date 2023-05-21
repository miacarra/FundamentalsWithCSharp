namespace PalindromeIntegers
{
    internal class PalindromeIntegers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            do
            {
                Console.WriteLine(CheckPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();
            } while (input != "End".ToUpper());
        }
        static bool CheckPalindrome(string input)
        {
            int length = input.Length;
            int lastIndex = length - 1;
   
            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[lastIndex])
                {
                  return false;
                    
                }
                lastIndex--;
            }
            return true;

        }
    }
}