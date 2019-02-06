/*Write a program that prints whether a given character
 is upper-case or lower case.
 ________________
 INPUT   OUTPUT
 L       upper-case
 f       lower-case
 ________________
*/
using System;

namespace _010LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string lower = input.ToLower();
            if (input == lower)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
