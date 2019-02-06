/*Write program to enter an integer number of centuries and 
 convert it to years, days, hours and minutes. 
 Output must be on one line.
 Hints
    • Use appropriate data type to fit the result
    after each data conversion.
    • Assume that a year has 365.2422 days at
    average (the Tropical year).
 __________________________________________________
 INPUT                                     OUTPUT
 1                           1 centuries = 100 years
                             = 36524 days = 876576 hours
                             = 52594560 minutes
 __________________________________________________
 5                           5 centuries = 500 years
                             = 182621 days = 4382904 hours
                             = 262974240 minutes          
____________________________________________________________
*/
using System;
using System.Numerics;

namespace _04CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);
        }
    }
}
