using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppendLists
{
    internal class AppendLists
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> inputList = input.Split("|", StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            List<int> intList = new List<int>();
            List<string> outPut = new List<string>();
            
            for (int i = 0; i < inputList.Count; i++)
            {
               
                intList.AddRange(inputList[i].Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());             

            }

                Console.WriteLine(String.Join(" ",intList));            

        }
    }
}