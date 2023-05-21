using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> input = ReadList();
            string instructions = Console.ReadLine();
            string manipulation;
            int startIndex;
            int endIndex;
            int index;
            int partitions;
            int chunkSize = 0;
            string addStr = string.Empty;

            while (instructions != "3:1")
            {
                List<string> instructionArr = instructions.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                manipulation = instructionArr[0];
                List<string> range = new List<string>();
                switch (manipulation)
                {
                    case "merge":
                        startIndex = int.Parse(instructionArr[1]);
                        endIndex = int.Parse(instructionArr[2]);
                        //if (input.Count == 1)
                        //    continue;
                        input = MergeInput(input, startIndex, endIndex);
                        break;
                    case "divide":
                        index = int.Parse(instructionArr[1]);
                        partitions = int.Parse(instructionArr[2]);
                        int length = input[index].Length;
                        if (length % partitions == 0)
                        {
                            chunkSize = length / partitions;
                            range = input[index].Chunk(chunkSize).Select(x => new String(x)).ToList();
                            input.RemoveAt(index);
                            input.InsertRange(index, range);
                        }
                        else
                        {
                            chunkSize = length / partitions;
                            int difference = length % partitions;
                            for (int i = 0; i < partitions; i++)
                            {

                                if (i == partitions - 1)
                                    chunkSize += difference;

                                range.Add(input[index].Substring(0, chunkSize));
                                input[index] = input[index].Remove(0, chunkSize);

                            }
                            input.RemoveAt(index);
                            input.InsertRange(index, range);
                        }
                        break;
                }
                instructions = Console.ReadLine();
            }
            PrintResult(input);

        }
        static void PrintResult(List<string> input)
        {
            Console.WriteLine(string.Join(' ', input));
        }
        static List<string> MergeInput(List<string> input, int startIndex, int endIndex)
        {
            List<string> temp = new List<string>();
            if (startIndex < 0)
                startIndex = 0;

            else if (startIndex >= input.Count)
                startIndex = input.Count - 1;

            if (endIndex >= input.Count)
                endIndex = input.Count - 1;

            if (endIndex < 0)
                endIndex = 0;
            if (startIndex < 0 && endIndex < 0 && input.Count != 0)
            {
                startIndex = 0;
                endIndex = 1;
            }
            for (int i = startIndex; i <= endIndex; i++)
            {
                temp.Add(input[i]);
            }
            input[startIndex] = string.Join("", temp);

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                input.RemoveAt(startIndex + 1);
            }
            return input;
        }

        static List<String> ReadList()
        {
            List<String> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            return input;
        }
    }
}