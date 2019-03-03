/*Write a program that reads a sequence of numbers and a special bomb number with a certain power.
 *Your task is to detonate every occurrence of the special bomb number and according to its
 *power - his neighbors from left and right. Detonations are performed from left to right and all 
 *detonated numbers disappear. Finally print the sum of the remaining elements in the sequence.
_______________________________________
Input                       Output
1 2 2 4 2 2 2 9             12
4 2
_______________________________________
1 4 4 2 8 9 1               5
9 3
_______________________________________
1 7 7 1 2 3                 6
7 1
_______________________________________
1 1 2 1 1 1 2 1 1 1         2 1
_______________________________________
4*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace _5BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> commands = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == commands[0])
                {
                    int start = i - commands[1];
                    if (start < 0)
                    {
                        start = 0;
                    }

                    int finish = i + commands[1] + 1;
                    if (finish > numbers.Count)
                    {
                        finish = numbers.Count;
                    }

                    for (int j = start; j < finish; j++)
                    {
                        numbers[j] = 0;
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
