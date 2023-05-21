namespace ListOperations
{
    internal class ListOperations
    {
        static void Main(string[] args)
        {
            List<int> input = ReadList();
            string instruction = Console.ReadLine();

            do
            {
                if (instruction == "End")
                    break;

                string[] instructionArr = instruction.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string manipulation = instructionArr[0];
                int number;
                int index;

                switch (manipulation)
                {
                    case "Add":
                        number = int.Parse(instructionArr[1]);
                        AddElement(input, number);
                        break;
                    case "Insert":
                        number = int.Parse(instructionArr[1]);
                        index = int.Parse(instructionArr[2]);
                        if (!IsValid(input, index))
                            break;
                        InsertElement(input, index, number);
                        break;
                    case "Remove":
                        index = int.Parse(instructionArr[1]);
                        if (!IsValid(input, index))
                        break; ;
                        input.RemoveAt(index);
                        break;
                    case "Shift":
                        int count = int.Parse(instructionArr[2]); 
                        if (instructionArr[1]=="left")
                            ShiftLeft(input, count);                
                        else if (instructionArr[1]=="right")        
                            ShiftRight(input, count);
                        break; 
                }
                instruction = Console.ReadLine();   
            } while (instruction != "End");
            PrintResult(input);
        }
        static List<int> ReadList()
        {
            return Console.ReadLine().
                    Split(" ", StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).
                    ToList();
        }
        static List<int> AddElement(List<int> input, int element)
        {
            input.Add(element);
            return input;
        }
        static bool IsValid(List<int> input, int index)
        {

            if (index < 0 || index >= input.Count)
            {
                Console.WriteLine($"Invalid index");
                return false;
            }
            else
                return true;
        }
        static List<int> RemoveAt(List<int> input, int index)
        {
            input.RemoveAt(index);
            return input;
        }
        static List<int> InsertElement(List<int> input, int index, int element)
        {
                input.Insert(index, element);
            return input;
        }
        static List<int> ShiftRight(List<int> input, int count)
        {
            int length = input.Count;
            int cycle = count % length;

            if (cycle == 0)
                return input;

            for (int i = 0; i < cycle; i++)
            {
                int temp = input[length-1];
                input.RemoveAt(length-1);
                input.Insert(0,temp);
        }

            return input;
        }
        static List<int> ShiftLeft(List<int> input, int count)
        {
            int cycle= count % input.Count;

            if(cycle== 0)
                return input;
            for (int i = 0; i < cycle; i++)
            {
                int temp=input[0]; 
                input.RemoveAt(0);
                input.Add(temp);
            }
            return input;
        }
        static void PrintResult(List<int> input)
        {
            Console.WriteLine(String.Join(" ", input));
        }
    }
}