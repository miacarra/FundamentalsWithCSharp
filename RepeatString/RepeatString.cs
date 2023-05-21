using System.Text;
using System.Threading.Channels;

namespace RepeatString
{
    internal class RepeatString
    {

        static void Main()
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatStr(input, count));
            
        }
        static string RepeatStr(string input,int count)
            {
                StringBuilder text = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    text.Append(input);
                }
                return text.ToString();
            }
        //static void Main(string[] args)
        //{
          
        //    string inputString = Console.ReadLine();
        //    int count = int.Parse(Console.ReadLine());
        //    PrintString(count, inputString);
        //}
        //static void PrintString(int input, string input2)
        //{
        //    string result = string.Empty;
        //    for (int i = 0; i < input; i++)
        //    {
        //        result += input2;
        //    }
        //    Console.WriteLine(result);


        //}
    }
}