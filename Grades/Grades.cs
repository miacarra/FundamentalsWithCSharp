namespace Grades
{
    internal class Program
    {
        //-----------------------------------------------------------------------option 1
        static void Main(string[] args)
        {
            PrintGrade(double.Parse(Console.ReadLine()));
        }

        static void PrintGrade(double input)
        {
            if (input >= 2 && input <= 2.99)
            {
                Console.WriteLine($"Fail");
            }
            if (input >= 3 && input <= 3.49)
            {
                Console.WriteLine($"Poor");
            }
            if (input >= 3.5 && input <= 4.49)
            {
                Console.WriteLine($"Good");
            }
            if (input >= 4.5 && input <= 5.49)
            {
                Console.WriteLine($"Very good");
            }
            if (input >= 5.5 && input <= 6)
            {
                Console.WriteLine($"Excellent");
            }
        }
            //--------------------------------------------------------------------------------option 2
            //static void Main(string[] args)
            //{
            //    PrintGrade();
            //}
            //static void PrintGrade()
            //{
            //    double grade = double.Parse(Console.ReadLine());

            //    if (grade >= 2.00 && grade <= 2.99)
            //    {
            //        Console.WriteLine("Fail");
            //    }
            //    else if (grade >= 3.00 && grade <= 3.49)
            //    {
            //        Console.WriteLine("Poor");
            //    }
            //    else if (grade >= 3.50 && grade <= 4.49)
            //    {
            //        Console.WriteLine("Good");
            //    }
            //    else if (grade >= 4.50 && grade <= 5.49)
            //    {
            //        Console.WriteLine("Very good");
            //    }
            //    if (grade >= 5.50 && grade <= 6.00)
            //    {
            //        Console.WriteLine("Excellent");
            //    }
            //}

            //-------------------------------------------------------------------option 3
            //static void Main(string[] args)
            //{
            //    double grade = double.Parse(Console.ReadLine());
            //    PrintGrade(grade);

            //}
            //static void PrintGrade(double grade)
            //{
            //    //double grade =double.Parse(Console.ReadLine());

            //    if (grade >= 2.00 && grade <= 2.99)
            //    {
            //        Console.WriteLine("Fail");
            //    }
            //    else if (grade >= 3.00 && grade <= 3.49)
            //    {
            //        Console.WriteLine("Poor");
            //    }
            //    else if (grade >= 3.50 && grade <= 4.49)
            //    {
            //        Console.WriteLine("Good");
            //    }
            //    else if (grade >= 4.50 && grade <= 5.49)
            //    {
            //        Console.WriteLine("Very good");
            //    }
            //    else if (grade >= 5.50 && grade <= 6.00)
            //    {
            //        Console.WriteLine("Excellent");
            //    }
        }
}