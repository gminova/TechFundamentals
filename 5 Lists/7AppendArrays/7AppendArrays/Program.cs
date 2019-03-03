/*Write a program to append several arrays of numbers.
    • Arrays are separated by ‘|’.
    • Values are separated by spaces (‘ ’, one or several).
    • Order the arrays from the last to the first, and their values from left to right.
__________________________________________________________
Input                            Output
1 2 3 |4 5 6 |  7  8             7 8 4 5 6 1 2 3
__________________________________________________________
7 | 4  5|1 0| 2 5 |3             3 2 5 1 0 4 5 7
__________________________________________________________
1| 4 5 6 7  |  8 9               8 9 4 5 6 7 1
__________________________________________________________
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace _7AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();


            for (int i = 0; i < numbers.Count; i++)
            {
                List<string> work = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();


                for (int j = 0; j < work.Count; j++)
                {

                    Console.Write($"{work[j]} ");


                }

            }
        }
    }
}