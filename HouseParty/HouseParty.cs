using System.Xml.Linq;

namespace HouseParty

{
    internal class HouseParty
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            string guest;
            for (int i = 0; i < commands; i++)
            {
                string[] instructions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int length = instructions.Length;
                guest = instructions[0];                              //Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray().Take(1).ElementAt(0);
                if (instructions.Length == 3)
                    AddGuest(guestList, guest);
                else if (length == 4)
                    RemoveGuest(guestList, guest);
            }
            PrintResult(guestList);

            static List<string> AddGuest(List<string> input, string name)
            {
                if (input.Contains(name))
                    Console.WriteLine($"{name} is already in the list!");
                else
                    input.Add(name);
                return input;
            }
            static List<string> RemoveGuest(List<string> input, string name)
            {
                if (input.Contains(name))
                    input.Remove(name);
                else
                            Console.WriteLine($"{name} is not in the list!"); 
                return input;
            }
            static void PrintResult(List<string> input)
            {
                foreach (string element in input)
                    Console.WriteLine(element);
            }
        }
    }
}