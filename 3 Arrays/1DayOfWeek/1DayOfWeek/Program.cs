/*Enter a day number [1…7] and print the name (in English)
 or "Invalid day!"
______________________________
Input                   Output
1                       Monday
2                      Tuesday
10                    Invalid day!
*/
using System;

namespace _1DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Invalid day!", "Monday", "Tuesday", "Wednesday",
             "Thursday", "Friday", "Saturday", "Sunday" };
                try
                {
                    int day = int.Parse(Console.ReadLine());
                    Console.WriteLine(arr[day]);
                }
                catch (Exception InvalidDay)
                {
                    Console.WriteLine("Invalid day!");
                    return;
                }
        }
    }
}
