/*Write a program to sum all adjacent equal numbers in a list of numbers,
 starting from left to right.
    • After two numbers are summed, the obtained result could be equal to some of
    its neighbors and should be summed as well (see the examples below).
    • Always sum the leftmost two equal neighbors (if several couples of equal 
    neighbors are available).
_____________________________
INPUT               OUTPUT
3 3 6 1             12 1
_____________________________
8 2 2 4 8 16        16 8 16
_____________________________
5 4 2 1 1 4         5 8 4
______________________________
*/
using System;
using System.Linq;

namespace _01SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    nums[i - 1] += nums[i];
                    nums.RemoveAt(i);
                    i = i - 2;
                    if (i < 0) i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
