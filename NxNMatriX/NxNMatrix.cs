namespace NxNMatriX
{
    internal class NxNMatrix
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                PrintLine(input);
                Console.WriteLine();
            }
                
        }
        static void PrintLine(int input)
        {
            for (int i = 0; i < input; i++)
            {
                Console.Write(input + " ");
            }
        } 
    }
}
