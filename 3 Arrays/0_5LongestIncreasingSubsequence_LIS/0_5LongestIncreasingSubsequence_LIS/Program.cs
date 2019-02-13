/*Read a list of integers and find the longest increasing subsequence (LIS).
 If several such exist, print the leftmost.
____________________________________________________________________
Input                                              Output
1                                                   1
____________________________________________________________________
7 3 5 8 -1 0 6 7                                    3 5 6 7
____________________________________________________________________
1 2 5 3 5 2 4 1                                     1 2 3 5
____________________________________________________________________
0 10 20 30 30 40 1 50 2 3 4 5 6                     0 1 2 3 4 5 6
____________________________________________________________________
11 12 13 3 14 4 15 5 6 7 8 7 16 9 8                 3 4 5 6 7 8 16
____________________________________________________________________
3 14 5 12 15 7 8 9 11 10 1                          3 5 7 8 9 11
____________________________________________________________________
Hints
    • Assume we have n numbers in an array nums[0…n-1].
    • Let len[p] holds the length of the longest increasing subsequence (LIS) 
    ending at position p.
    • In a for loop, we shall calculate len[p] for p = 0 … n-1 as follows:
        ◦ Let left is the leftmost position on the left of p (left < p), such that 
        len[left] is the largest possible.
        ◦ Then, len[p] = 1 + len[left]. If left does not exist, len[p] = 1.
        ◦ Also, save prev[p] = left (we hold if prev[] the previous position, used to
        obtain the best length for position p).
    • Once the values for len[0…n-1] are calculated, restore the LIS starting from
    position p such that len[p] is maximal and go back and back through p = prev[p].
    • The table below illustrates these computations:
______________________________________________________________________________________________________________________________________    
index  | 0   |    1   |   2   |     3    |      4      |    5    |     6     |      7      |        8       |         9       |  10  |
______________________________________________________________________________________________________________________________________
nums[] | 3   |   14   |   5   |    12    |      15     |    7    |     8     |      9      |       11       |        10       |   1  |
______________________________________________________________________________________________________________________________________
len[]  | 1   |    2   |   2   |     3    |       4     |    3    |     4     |      5      |        6       |         6       |   1  |
______________________________________________________________________________________________________________________________________
prev[] | -1  |    0   |   0   |     2    |       3     |    2    |     5     |      6      |        7       |         7       |  -1  |
______________________________________________________________________________________________________________________________________
LIS    | {3} | {3,14} | {3,5} | {3,5,12} | {3,5,12,15} | {3,5,7} | {3,5,7,8} | {3,5,7,8,9} | {3,5,7,8,9,11} | {3,5,7,8,9,10}  |  {1} |
______________________________________________________________________________________________________________________________________
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace _0_5LongestIncreasingSubsequence_LIS
{
    class Program
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            var longestSeq = FindLongestIncreasingSubsequence(sequence);
            Console.WriteLine(string.Join(" ", longestSeq));
        }

        public static int[] FindLongestIncreasingSubsequence(int[] sequence)
        {
            int[] length = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }

            var longestSeq = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestSeq.Reverse();
            return longestSeq.ToArray();
        }
    }
}
