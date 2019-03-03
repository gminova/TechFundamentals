/*Write a program to calculate the winner of a car race. You will receive an
 * list of numbers. Each element of the list represents the time needed to
 * pass through that step (the index). There are going to be two cars. One of
 * them starts from the left side and the other one starts from the right side.
 * The middle index of the list is the finish line. The number of elements in
 * the list will always be odd. Calculate the total time for each racer to reach
 * the finish, which is the middle of the list, and print the winner with his 
 * total time (the racer with less time). If you have a zero in the list, you 
 * have to reduce the time of the racer that reached it by 20% (from his current time).
Print the result in the following format:
"The winner is {left/right} with total time: {total time}".
________________________________________________________
Input                               Output
29 13 9 0 13 0 21 0 14 82 12        The winner is left with total time: 53.8
________________________________________________________
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace _0_2CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

            List<int> firstRacerNums = new List<int>();
            List<int> secondRacerNums = new List<int>();

            double firstSum = 0;
            double secondSum = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                firstRacerNums.Add(numbers[i]);
            }
            for (int i = numbers.Count - 1; i >= numbers.Count / 2 + 1; i--)
            {
                secondRacerNums.Add(numbers[i]);
            }
            for (int i = 0; i < firstRacerNums.Count; i++)
            {
                int currNum = firstRacerNums[i];
                firstSum += currNum;
                if (currNum == 0)
                {
                    firstSum = firstSum * 0.8;
                }
            }
            for (int i = 0; i < secondRacerNums.Count; i++)
            {
                int currNum = secondRacerNums[i];
                secondSum += currNum;
                if (currNum == 0)
                {
                    secondSum = secondSum * 0.8;
                }
            }
            if (firstSum < secondSum)
            {
                Console.WriteLine("The winner is left with total time: {0}", firstSum);
            }
            else
            {
                Console.WriteLine("The winner is right with total time: {0}", secondSum);
            }
        }
    }
}
