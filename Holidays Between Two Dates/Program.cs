using System;
using System.Globalization;
class HolidaysBetweenTwoDates
{

    // You are assigned to find and fix all bugs in the existing code. By using the Visual Studio debugger, place a breakpoint and 
    // find the lines of code that produce incorrect or unexpected results.
    // You are given a program (existing source code) that aims to count the non-working days
    //between two dates in format day.month.year (e.g. between 1.05.2015 and 15.05.2015 
    //there are 5 non-working days – Saturday and Sunday).



    static void Main()
    { 
        string inputstart = Console.ReadLine();
        string inputlast = Console.ReadLine();
        string format = "d.M.yyyy";
        var startdate = DateTime.ParseExact(inputstart, format, CultureInfo.InvariantCulture);
        var enddate = DateTime.ParseExact(inputlast, format, CultureInfo.InvariantCulture,DateTimeStyles.None);
        var holidayscount = 0;
        for (var date = startdate; date <= enddate; date=date.AddDays(1))
        {
            string currentDay = date.DayOfWeek.ToString();
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                holidayscount++;
            
        }
            Console.WriteLine(holidayscount);

















        //string data = Console.ReadLine();
        //string format = "D";

        //DateTime birthday = DateTime.ParseExact(data, "d.M.yyyy", CultureInfo.InvariantCulture);
        //string myNptFormattedBirthday = birthday.ToString();
        //string myFormattedBirthday = birthday.ToLongDateString();




        //string date = Console.ReadLine();
        //DateTime convertedate = DateTime.ParseExact(date, "d.M.yyyy", CultureInfo.InvariantCulture);
        //DateTime convertedateL = DateTime.ParseExact(date, "d.M.yyyy", CultureInfo.CreateSpecificCulture("bg-Bg"));
        //string convDate = convertedate.ToString();
        //string convDate2 = convertedate.ToLocalTime().ToString();
        //string convDate3 = convertedate.ToLongDateString();
        //string convDate4 = convertedate.ToShortDateString();

        //DateTime dateNow = DateTime.Now;
        //DateTime tommorow = DateTime.Now.AddDays(1);
        //DateTime yesterday = DateTime.Now.AddDays(-1);
        //string dateTrue = dateNow.ToShortDateString();
        //string tommorowTrue = tommorow.ToString();

    }
}