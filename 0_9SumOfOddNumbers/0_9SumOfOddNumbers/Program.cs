﻿/*Write a program that prints the next n odd numbers (starting from 1) and on 
 * the last row prints the sum of them.

On the first line, you will receive a number – n. This number shows how many odd
numbers you should print.

Print the next n odd numbers, starting from 1, separated by new lines. On the 
last line, print the sum of these numbers.
Constraints:
    • n will be in the interval [1…100]
________________________________________________________________  
INPUT                 OUTPUT
5                     1
                      3
                      5
                      7
                      9
                      Sum: 25
________________________________________________________________
3                     1
                      3
                      5
                      Sum: 9
________________________________________________________________
*/
using System;

namespace _0_9SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= 2 * n; i += 2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
