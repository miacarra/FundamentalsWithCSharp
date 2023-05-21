using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.Design;

namespace MergingLists
{
    internal class MergingLists
    {
        static void Main(string[] args)
        {
            List<int> input1 = ReadList();
            List<int> input2 = ReadList();
            List<int> result = input1;
            int index = 1;
            if (input1.Count > input2.Count)
            {
                for (int i = 0; i < input2.Count; i++)
                {
                    result.Insert(index, input2[i]);
                    index += 2;
                }
            }
            else
            {
                index = 0;
                for (int i = 1; i < input1.Count; i += 2)
                {
                    result.Insert(i, input2[index]);
                    //Console.Write(result[i]);
                    index++;
                }
                result.AddRange(input2.GetRange(index, input2.Count - index));

            }
            PrintList(result);
        }

        //static List<int> ReadList(int n)
        //{
        //    List<int> output = new List<int>();
        //    for (int i = 0; i < n; i++)
        //    {

        //        output.Add(int.Parse(Console.ReadLine()));
        //    }
        //    return output;
        //}
        //static List<int> CompareLength(List<int> input1, List<int> input2)
        //{
        //    if (input1.Count < input2.Count)
        //        return input1;
        //    else return input2;
        //}

        //static List<int> ReadList(string[] input)
        //{
        //    List<int> output = new List<int>();
        //    //for (int i = 0; i < input.Length; i++)
        //    //{
        //    //    output.Add(int.Parse(input[i]));
        //    //}
        //    foreach (string element in input)
        //    {
        //        output.Add(int.Parse(element));
        //    }
        //    return output;

        //}
        //static List<int> ReadList(string input)
        //{
        //    List<int> output = new List<int>();
        //    //for (int i = 0; i < input.Length; i++)
        //    //{
        //    //    output.Add(int.Parse(input[i].ToString()));
        //    //}
        //    foreach (char symbol in input)
        //    {
        //        output.Add(symbol);
        //    }
        //    return output;

        //}
        static List<int> ReadList()
        {
            List<int> output = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            return output;
        }
        static void PrintList(List<int> input)
        {
            //foreach (int i in input)
            //    Console.WriteLine(i);
            for (int i = 0; i < input.Count; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}