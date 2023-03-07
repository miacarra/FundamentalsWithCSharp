using System;
using System.Globalization;

namespace Login
{





    class Login
    {
        //On the first line, you will be given a username and your task is to try to log in the user.
        //The user's password is the username reversed. On the next lines, you will receive passwords:
        //•	If the password is incorrect, print "Incorrect password. Try again.".
        //•	If the password is correct, print "User {username} logged in." and stop the program.
        //Keep in mind that if the password is still incorrect on the fourth attempt, you should print: "User {username} blocked!".
        //Then the program stops.

        // Option 1 - Single method (Main) solution-----------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;
            int length = userName.Length;

            string input = Console.ReadLine();
            int attempts = 0;
            bool isBlocked = false;


            for (int index = length - 1; index >= 0; index--)
            {
                //char current = userName[index];
                password += userName[index].ToString();
            }

            while (input != password)
            {
                attempts++;
                if (attempts > 3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    isBlocked = true;
                    break;
                }
                Console.WriteLine($"Incorrect password. Try again.");
                input = Console.ReadLine();
            }
            if (!isBlocked)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
 
        
        //  Option 2 - invoke public static string CreatePassword(input)-----------------------------------------------------------------------------        
        //static void Main(string[] args)
        //{
        //    string userName = Console.ReadLine();
        //    string input = Console.ReadLine();
        //    string password = CreatePassword(userName);
        //    int attempts = 0;
        //    bool isBlocked = false;

        //    while (input != password)
        //    {
        //        attempts++;
        //        if (attempts > 3)
        //        {
        //            Console.WriteLine($"User {userName} blocked!");
        //            isBlocked = true;
        //            break;
        //        }
        //        Console.WriteLine($"Incorrect password. Try again.");
        //        input = Console.ReadLine();
        //    }
        //    if (!isBlocked)
        //    {
        //        Console.WriteLine($"User {userName} logged in.");
        //    }
        //}

        //public static string CreatePassword(string input)         // reverse string using for loop(int)input[index] ????????????????????
        //{
        //    string result = string.Empty;      
        //    for (int index = input.Length - 1; index >= 0; index--)
        //    {
        //        result += input[index];
        //    }
        //    return result;
        //}
    
    
    
    }
}

