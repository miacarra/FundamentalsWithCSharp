using System;
using System.ComponentModel.Design;
using System.Linq;
namespace PasswordValidator
{
    internal class PasswordValidator
    {
        //-----------------------------------------------------using string expression && LINQ methods
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (ValidateLength(password) == null &&
               (ValidateLetersDigits(password) == null) &&
               (ValidateNumberDigits(password) == null))
                Console.WriteLine("Password is valid");
            
            if (ValidateLength(password) != null)
                Console.WriteLine(ValidateLength(password));
            
            if (ValidateLetersDigits(password)!=null)
                Console.WriteLine(ValidateLetersDigits(password));

            if(ValidateNumberDigits(password)!=null)
                Console.WriteLine(ValidateNumberDigits(password));
            
        }
        static string ValidateLength(string input)
        {
            int length = input.Length;
            string result = null;
            if (length < 6 || length > 10)
                result = "Password must be between 6 and 10 characters";
            return result;

        }
        static string ValidateLetersDigits(string input)
        {
            string result = null;
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    result = "Password must consist only of letters and digits";
                    break;
                }
            }
            return result;
        }
          static string ValidateNumberDigits(string input)
        {
            string result = null;
            int digitsSum = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digitsSum++;
                    if (digitsSum >= 2)
                        break;
                }
            }
            if (digitsSum < 2)
                result = "Password must have at least 2 digits"; 
            return result;
        }

        //---------------------------------------------------------------------using Boolean expression && ASCII code
        //static void Main(string[] args)
        //{
        //    string password = Console.ReadLine();
        //    bool correctLength=CheckLength(password);
        //    bool correctContent=CheckContent(password);
        //    bool correctDigits=CheckDigits(password);
        //    if(correctLength&&correctContent&&correctDigits)
        //    Console.WriteLine($"Password is valid");

        //}
        //static bool CheckDigits(string input)
        //{

        //    int length = input.Length;
        //    int minDigits = 0;
        //    for (int i = 0; i < length; i++)
        //    {
        //        if ((int)input[i] >= 48 && (int)input[i] <= 57)
        //        {
        //            minDigits++;
        //        }
        //        if (minDigits >= 2)
        //            break;
        //    }
        //    if (minDigits >= 2)
        //        return true;
        //    else
        //    {
        //        Console.WriteLine($"Password must have at least 2 digits");
        //        return false;
        //    }
        //}
        //static bool CheckLength(string input)
        //{
        //    if (input.Length >= 6 && input.Length <= 10)
        //        return true;
        //    else
        //    {
        //        Console.WriteLine("Password must be between 6 and 10 characters");
        //        return false;
        //    }
        //}
        //static bool CheckContent(string input)
        //{
        //    bool correctContent = true;
        //    foreach (char c in input)
        //        if (((int)c <= 47) || ((int)c >= 58 && (int)c <= 64) || ((int)c >= 91 && (int)c <= 96) || ((int)c >= 123))
        //        {
        //            Console.WriteLine($"Password must consist only of letters and digits");
        //            correctContent = false;
        //            break;
        //        }
        //    return correctContent;
        //}



    }
}