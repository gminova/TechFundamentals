/*Create a method that prints the sign of an integer number n:
______________________________________
Input                          Output
2                   The number 2 is positive.
______________________________________
-5                  The number -5 is negative.
______________________________________
0                   The number 0 is zero.
*/
using System;

namespace _1SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            SignOfInteger(int.Parse(Console.ReadLine()));
        }
        static void SignOfInteger(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
        }
    }
}
