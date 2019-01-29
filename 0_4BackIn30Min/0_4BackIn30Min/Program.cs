/*Every time Stamat tries to pay his bills he sees on the cash desk the sign:
 * "I will be back in 30 minutes". One day Stamat was sick of waiting and decided
 * he needs a program, which prints the time after 30 minutes. That way he won’t 
 * have to wait on the desk and come at the appropriate time. He gave the 
 * assignment to you, so you have to do it. 
  
The input will be on two lines. On the first line, you will receive the hours and on the second you will receive the minutes. 

Print on the console the time after 30 minutes. The result should be in format hh:mm. The hours have one or two numbers and the minutes have always two numbers (with leading zero).

Constraints
    • The hours will be between 0 and 23.
    • The minutes will be between 0 and 59.
    ____________________________________________
    INPUT                    OUTPUT
    1                         2:16
    46
    ____________________________________________
    11                        12:05
    32 
    ____________________________________________
*/
using System;

namespace _0_4BackIn30Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int hoursMin = hours * 60;
            int minutes = int.Parse(Console.ReadLine());
            int totalMins = hoursMin + minutes + 30;
            int newMins = totalMins % 60;
            int newHours = totalMins / 60;
            if (newMins >= 60)
            {
                newHours += 1;
                newMins -= 60;
            }

            if (newHours >= 24)
            {
                newHours = Math.Abs(24 - newHours);
            }

            if (newMins >= 10)
            {
                Console.WriteLine("{0}:{1}", newHours, newMins);
            }
            else
            {
                Console.WriteLine("{0}:0{1}", newHours, newMins);
            }
        }
    }
}
