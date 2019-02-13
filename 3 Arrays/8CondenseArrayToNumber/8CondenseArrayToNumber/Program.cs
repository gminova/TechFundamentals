/*Write a program to read an array of integers and condense them by summing adjacent
 couples of elements until a single integer is obtained. For example, if we have 
 3 elements {2, 10, 3}, we sum the first two and the second two elements and 
 obtain {2+10, 10+3} = {12, 13}, then we sum again all adjacent elements and obtain {12+13} = {25}.
__________________________
Input               Output
2 10 3                 25
__________________________
5 0 4 1 2              35
__________________________
1                       1
__________________________
*/
using System;
using System.Linq;

namespace _8CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while (nums.Length > 1)
            {
                int[] condensed = new int[nums.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                nums = condensed;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
