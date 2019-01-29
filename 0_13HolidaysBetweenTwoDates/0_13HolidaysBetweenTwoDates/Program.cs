/*You are assigned to find and fix the bugs in an existing piece of code, using
 the Visual Studio debugger. You should trace the program execution to find the 
 lines of code that produce incorrect or unexpected results. You are given 
 a program (existing source code) that aims to count the non-working days between
 two dates given in format day.month.year (e.g. between 1.05.2015 and 15.05.2015
 there are 5 non-working days – Saturday and Sunday).
 
 _________________________BROKEN CODE FOR REFACTORING___________________________

using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.m.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.m.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date.AddDays(1))
            if (date.DayOfWeek == DayOfWeek.Saturday &&
                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        Console.WriteLine(holidaysCount);
    }
}
_____________________________________END________________________________________
 */
using System;
using System.Globalization;

namespace _0_13HolidaysBetweenTwoDates
{
    class Program
    {
        static void Main(string[] args)
        {
            //BUG 1 and 2: 'dd.m.yyyy' was changed to 'd.M.yyyy' because otherwise  
            //'dd' adds an extra '0' if the date which was input has 2 digits. 
            //Also, m stands for minutes, whereas M is for months.

            var startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            //BUG 3: 'date.AddDays(1)' was changed to 'date = date.AddDays(1)'
            //otherwise the for-loop will not increment.
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            //NOTE: '{}' brackets have been added to the for-loop and the
            //if-statement to avoid poor-practice and errorrs if more 
            //if-statements are bing added in the future. Technically, in 
            //this case the code would run correctly even without the '{}' brackets.
            //However, it is advisible to add brackets to avoid confusion.
            {
                //BUG 4: The operator '&&' (logical AND) has been changed to 
                // '||' (logical OR), otherwise the if-statement makes no sense.

                if (date.DayOfWeek == DayOfWeek.Saturday ||
                        date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }
            Console.WriteLine(holidaysCount);
        }
    }
}
