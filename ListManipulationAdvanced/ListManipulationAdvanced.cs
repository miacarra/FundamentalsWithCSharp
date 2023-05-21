namespace ListManipulationAdvanced
{
    internal class ListManipulationAdvanced
    {
        static void Main(string[] args)
        {
            List<int> input = ReadList();
            string instruction = Console.ReadLine();
            string manipulation;
            int number;
            int index;
            bool Ismodified = false;
            do
            {
                if (instruction == "end")
                    break;
                string[] instructionArr = instruction.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                manipulation = instructionArr[0];
                switch (manipulation)
                {
                    case "Add":
                        number = int.Parse(instructionArr[1]);
                        input = AddElement(input, number);
                        Ismodified = true;
                        break;
                    case "Remove":
                        number = int.Parse(instructionArr[1]);
                        input = RemoveElement(input, number);
                        Ismodified = true;
                        break;
                    case "RemoveAt":
                        index = int.Parse(instructionArr[1]);
                        input = RemoveAtIndex(input, index);
                        Ismodified = true;
                        break;
                    case "Insert":
                        number = int.Parse(instructionArr[1]);
                        index = int.Parse(instructionArr[2]);
                        input = InsertElement(input, index, number);
                        Ismodified = true;
                        break;
                    case "Contains":
                        number = int.Parse(instructionArr[1]);
                        CheckContains(input, number);
                        break;
                    case "PrintEven":
                        PrintEvenNumbers(input);
                        break;
                    case "PrintOdd":
                        PrintOddNumbers(input);
                        break;
                    case "GetSum":
                        PrintListSum(input);
                        break;
                    case "Filter":
                        string definer = instructionArr[1];
                        number = int.Parse(instructionArr[2]);
                        FilterList(input, definer, number);
                        break;
                }
                instruction = Console.ReadLine();
            } while (instruction != "end");
            if (Ismodified)
                PrintResult(input);
        }
        static List<int> ReadList()
        {
            List<int> input = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                ToArray().
                Select(int.Parse).
                ToList();
            return input;
        }
        static void PrintResult(List<int> input)
        {
            Console.WriteLine(string.Join(" ", input));
        }

        static void CheckContains(List<int> input, int number)
        {
            if (input.Contains(number))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No such number");
        }

        static void PrintEvenNumbers(List<int> input)
        {
            Console.WriteLine(string.Join(" ", input.FindAll(x => x % 2 == 0)));//FindAll(x=x%2==1)
        }
        static void PrintOddNumbers(List<int> input)
        {
            Console.WriteLine(string.Join(" ", input.FindAll(x => x % 2 == 1)));
        }
        static void PrintListSum(List<int> input)
        {
            Console.WriteLine(input.Sum());
        }
        static void FilterList(List<int> input, string definer, int number)
        {
            switch (definer)
            {
                case "<":
                    Console.WriteLine(string.Join(" ", input.FindAll(x => x < number)));
                    break;
                case ">":
                    Console.WriteLine(string.Join(" ", input.FindAll(x => x > number)));
                    break;
                case ">=":
                    Console.WriteLine(string.Join(" ", input.FindAll(x => x >= number)));
                    break;
                case "<=":
                    Console.WriteLine(string.Join(" ", input.FindAll(x => x <= number)));
                    break;
            }

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

    }
}
