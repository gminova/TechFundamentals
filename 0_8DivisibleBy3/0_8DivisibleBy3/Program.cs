/*Write a program, which prints all the numbers from 1 to 100, which are 
 * divisible by 3. You have to use a single for loop. The program should not
 * receive input.
*/
using System;

namespace _0_8DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 100; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
