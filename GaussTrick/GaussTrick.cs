namespace GaussTrick
{
    internal class GaussTrick
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            for (int i = 0; i < input.Count - 1; i++)
            {
                input[i] += input.Last();
                input.Remove(input.Last());
            }
            PrintResult(input);
        }
            //--------------------------------------------------------------------------------------------------
            //    List<int> input = Console.ReadLine().
            //        Split(' ', StringSplitOptions.RemoveEmptyEntries).
            //        Select(int.Parse).
            //        ToList();
            //    for (int i = 0; i < input.Count/ 2; i++)
            //    {
            //        Console.Write(input[i] + input.Count - 1 - i);
            //    }
            //    if (input.Count % 2 == 1)
            //        Console.Write(input[input.Count / 2]);



            //}
            static void PrintResult(List<int> input)
        {
            Console.WriteLine(string.Join(' ', input.ToArray()));
        }
    }
}