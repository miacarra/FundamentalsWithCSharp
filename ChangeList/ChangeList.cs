using System.Runtime.Intrinsics.Arm;

namespace ChangeList
{
    internal class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> input = ReadList();
            string instruction = Console.ReadLine();
            int inputNum;
            int index;
            do
            {
                if (instruction == "end")
                    break;
                string[] instructionArray = instruction.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string manipulation = instructionArray[0];
                switch (manipulation)
                {
                    case "Insert":
                        inputNum = int.Parse(instructionArray[1]);
                        index = int.Parse(instructionArray[2]);
                        input = InsertElement(input, index, inputNum);
                        break;
                    case "Delete":
                        inputNum = int.Parse(instructionArray[1]);
                        input = RemoveAllItems(input, inputNum);
                        break;
                }
                instruction = Console.ReadLine();
            } while(instruction != "end");
            PrintResult(input);
        
        }
        static List<int> ReadList()
        {
            List<int> output = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();
            return output;
        }
        static List<int> RemoveAllItems(List<int> input, int inputNum)
        {

            List<int> output = input.Where(x => x != inputNum).ToList();
            return output;

        }
        static void DeleteElement(List<int> input, int inputNum)
        {
            List<int> output = new List<int>();
            input = input.FindAll(x => x != inputNum);
        }
        static List<int> InsertElement(List<int> input, int index, int inputNum)
        {
            input.Insert(index,inputNum);
            return input;
        }
        static void PrintResult(List<int> input)
        {
            Console.WriteLine(string.Join(" ", input));
        }
    }
}