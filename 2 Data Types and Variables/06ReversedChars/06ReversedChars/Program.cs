/*Write a program that takes 3 lines of characters and
 prints them in reversed order with a space between them.
 ______________________________
 INPUT           OUTPUT
 A               C B A 
 B
 C
 ______________________________
 */
using System;

namespace _06ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string charOne = Console.ReadLine();
            string charTwo = Console.ReadLine();
            string charThree = Console.ReadLine();
            string reversed = charThree + " " + charTwo + " " + charOne;
            Console.WriteLine(reversed);
        }
    }
}
