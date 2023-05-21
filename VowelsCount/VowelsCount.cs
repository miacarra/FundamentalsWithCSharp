namespace VowelsCount
{
    internal class VowelsCount
    {
        //Create a method that receives a single string and prints out the number of vowels contained in it.
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintResult( VowelCount(input)); 
        }
        static int VowelCount(string input)
        {
            int count = 0;
            foreach (char sym in input) 
            { 
            if (
                   sym== 'a'
                || sym == 'A'
                ||sym == 'o'
                || sym == 'O'
                || sym == 'e'
                || sym == 'E' 
                || sym == 'i' 
                || sym == 'I'
                || sym == 'u' 
                || sym == 'U')
                count ++;
             }
            return count;
        }
        static void PrintResult(int input)
        {
            Console.WriteLine(input);
        }
    }


}