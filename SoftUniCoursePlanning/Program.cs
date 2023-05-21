using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fundamentalsShedule = ReadList();
            string input = Console.ReadLine();

            string modify = string.Empty;

            while (input != "course start")
            {
                string[] instructions = GetInstructions(input);
                modify = instructions[0];
                switch (modify)
                {
                    case "Add":
                        AddLesson(fundamentalsShedule, instructions);
                        break;
                    case "Insert":
                        InsertLesson(fundamentalsShedule, instructions);
                        break;
                    case "Remove":
                        RemoveLesson(fundamentalsShedule, instructions);
                        break;
                    case "Swap":
                        SwapLesson(fundamentalsShedule, instructions);
                        break;
                    case "Exercise":
                        AddExercise(fundamentalsShedule, instructions);
                        break;
                }
                input = Console.ReadLine();
            }
            PrintResult(fundamentalsShedule, input);
        }
        static List<string> ReadList()
        {
            return Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

        }
        static string[] GetInstructions(string input)
        {
            return input.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

        }
        static void AddLesson(List<string> input, string[] inputArr)
        {
            string lessonToAdd = inputArr[1];
            if (!input.Contains(lessonToAdd))
                input.Add(lessonToAdd);
        }
        static void InsertLesson(List<string> input, string[] inputArr)
        {
            string lessonToAdd = inputArr[1];
            int index = int.Parse(inputArr[2]);
            bool isValid = 0 <= index && index < input.Count;
            if (!input.Contains(lessonToAdd) && isValid)
                input.Insert(index, lessonToAdd);
        }
        static void RemoveLesson(List<string> input, string[] inputArr)
        {
            string lessonToRemove = inputArr[1];
            string exerciseToRemove = $"{lessonToRemove}-Exercise";
            if (input.Contains(lessonToRemove) && input.Contains(exerciseToRemove))                                           
            {
                input.Remove(lessonToRemove);
                input.Remove(exerciseToRemove);
            }
            else if (input.Contains(lessonToRemove) && !input.Contains(exerciseToRemove))
                input.Remove(lessonToRemove);
        }
        static void AddExercise(List<string> input, string[] inputArr)
        {
            string lessonTitle = inputArr[1];
            string exercise = $"{lessonTitle}-Exercise";
            List<string> updatesToAdd = new List<string> { lessonTitle, exercise };
            if (input.Contains(lessonTitle) && !input.Contains(exercise) && input.IndexOf(lessonTitle) < input.Count - 1)
                input.Insert(input.IndexOf(lessonTitle) + 1, exercise);
            if (input.Contains(lessonTitle) && !input.Contains(exercise) && input.IndexOf(lessonTitle) == input.Count - 1)
                input.Add(exercise);
            else if (!input.Contains(lessonTitle) && !input.Contains(exercise))
                input.AddRange(updatesToAdd);

        }
        static void SwapLesson(List<string> input, string[] inputArr)
        {
            string lessonToRemove = inputArr[1];
            string exersiseToRemove = $"{lessonToRemove}-Exercise";
            string lessonToAdd = inputArr[2];
            string exersiseToAdd = $"{lessonToAdd}-Exercise";
            bool lesson1Exists = input.Contains(lessonToRemove);
            bool exercise1Exists = input.Contains(exersiseToRemove);
            bool exercise2Exists = input.Contains(exersiseToAdd);
            bool lesson2Exists = input.Contains(lessonToAdd);
            if (lesson1Exists && exercise1Exists && lesson2Exists && exercise2Exists)   //all are present
            {
                List<string> updatesToRemove = new List<string> { lessonToRemove, exersiseToRemove };
                List<string> updatesToAdd = new List<string> { lessonToAdd, exersiseToAdd };

                input.InsertRange(input.IndexOf(lessonToRemove), updatesToAdd);
                input.RemoveRange(input.IndexOf(lessonToRemove), 2);
                input.InsertRange(input.FindLastIndex(x => x == lessonToAdd), updatesToRemove);
                input.RemoveRange(input.FindLastIndex(x => x == lessonToAdd), 2);

            }
            else if (lesson1Exists && !exercise1Exists && lesson2Exists && !exercise2Exists)    //only lessons are present
            {
                string temp = lessonToRemove;
                int teMp = input.IndexOf(lessonToAdd);
                input.Insert(input.IndexOf(lessonToRemove), lessonToAdd);
                input.RemoveAt(input.IndexOf(lessonToRemove));
                input[teMp]=temp;
               
            }
            else if (lesson1Exists && exercise1Exists && lesson2Exists && !exercise2Exists)
            {
                string temp = lessonToAdd;
                List<string> updatesToRemove = new List<string> { lessonToRemove, exersiseToRemove };
                input.InsertRange(input.IndexOf(lessonToAdd), updatesToRemove);
                input.RemoveAt(input.IndexOf(lessonToAdd));
                input.Insert(input.FindLastIndex(x => x == lessonToRemove), temp);
                input.RemoveRange(input.FindLastIndex(x => x == exersiseToRemove), 2);
            }
            else if (lesson1Exists && !exercise1Exists && lesson2Exists && exercise2Exists)
            {
                string temp = lessonToRemove;
                List<string> updatesToAdd = new List<string> { lessonToAdd, exersiseToAdd };
                input.InsertRange(input.IndexOf(lessonToRemove), updatesToAdd);
                input.Remove(lessonToRemove);
                input.Insert(input.FindLastIndex(x => x == lessonToAdd), temp);
                input.RemoveRange(input.FindLastIndex(x => x == lessonToAdd), 2);
            }
        }
        static void PrintResult(List<string> inputList, string input)
        {
            if (input == "course start")
                for (int i = 0; i < inputList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{inputList[i]}");
                }
        }

    }
}