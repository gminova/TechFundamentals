/*Write a program, which prints all unique pairs in an array
 of integers whose sum is equal to a given number. 
_______________________________________
Input                         Output
1 7 6 2 19 23                   1 7
8                               6 2
_______________________________________
14 20 60 13 7 19 8              14 13
27                              20 7
                                19 8
_______________________________________
*/
using System;
using System.Linq;

namespace _08MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == magicSum)
                    {
                        Console.WriteLine($"{input[i]} {input[j]}");
                    }
                }
            }
        }
    }
}
