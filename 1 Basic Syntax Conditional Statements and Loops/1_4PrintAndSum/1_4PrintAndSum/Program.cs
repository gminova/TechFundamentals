/*Write a program to display numbers from given start to given end and their sum.
 * All the numbers will be integers. On the first line you will receive the start,
 * on the second the end.
 * 
Examples

Input--------------------Output

5                        5 6 7 8 9 10
10                       Sum: 45
------------------------------------
0                        0 1 2 … 26
26                       Sum: 351
------------------------------------
50                       50 51 52 53 54 55 56 57 58 59 60
60                       Sum: 605

*/
using System;

namespace _1_4PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}