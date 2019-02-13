/*Write a program that calculates the difference between the
 sum of the even and the sum of the odd numbers in an array.
________________________________________________________
Input                              Output
1 2 3 4 5 6                        3
________________________________________________________
3 5 7 9                            -24
________________________________________________________
2 4 6 8 10                         30
________________________________________________________
*/
using System;
using System.Linq;

namespace _6EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    difference += nums[i];

                }
                else
                {
                    difference -= nums[i];
                }
            }
            Console.WriteLine(difference);
        }
    }
}
