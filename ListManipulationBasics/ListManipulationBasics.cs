namespace ListManipulationBasics
{
    internal class ListManipulationBasics
    {
        static void Main(string[] args)
        {
            List<int> input = ReadList();

            string instruction = Console.ReadLine();
            int number;
            int index;
            do
            {
                if (instruction == "end")
                    break;

                string[] instructArr = instruction.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = instructArr[0];
                number = int.Parse(instructArr[1]);

                switch (command)
                {
                    case "Add":
                        number = int.Parse(instructArr[1]);
                        input = AddElement(input, number);
                        break;
                    case "Remove":
                        number = int.Parse(instructArr[1]);
                        input = RemoveElement(input, number);
                        break;
                    case "RemoveAt":
                        index = int.Parse(instructArr[1]);
                        input = RemoveAtIndex(input, index);
                        break;
                    case "Insert":
                        number = int.Parse(instructArr[1]);
                        index = int.Parse(instructArr[2]);
                        input = InsertElement(input, index, number);
                        break;
                }
                instruction = Console.ReadLine();
            } while (instruction != "end");

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
        static List<int> AddElement(List<int> input, int number)
        {
            input.Add(number);
            return input;
        }
        static List<int> RemoveElement(List<int> input, int number)
        {
            input.Remove(number);
            return input;
        }
        static List<int> RemoveAtIndex(List<int> input, int index)
        {
            input.RemoveAt(index);
            return input;
        }
        static List<int> InsertElement(List<int> input, int index, int number)
        {
            input.Insert(index, number);
            return input;
        }
        static void PrintResult(List<int> input)
        {
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

