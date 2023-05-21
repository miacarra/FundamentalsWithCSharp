namespace MiddleCharacters
{
    internal class MiddleCharacters
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToArray();
            double length = input.Length;
            double middleIndex = GetIndex(length);
            if (length % 2 == 0)
            {
                Console.WriteLine($"{input[(int)(middleIndex - 1)]}{input[(int)middleIndex]}");
            }
            else
                Console.WriteLine(input[(int)middleIndex]);
            
            
    }
    static double GetIndex(double input)
    {
            return input / 2;
    }

}



    
}