/*You will be given a list of numbers and a string. For each element
 of the list you have to calculate the sum of its digits and take the
 element, corresponding to that index from the text. If the index is
 greater than the length of the text, start counting from the beginning
 (so that you always have a valid index). After you get that element from
 the text, you must remove the character you have taken from it (so for
 the next index, the text will be with one character less).
_________________________________________________________
Input                                 Output
9992 562 8933
This is some message for you           hey
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace _0_1Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string mssg = Console.ReadLine();

            GetElement(nums, mssg);
        }

        private static void GetElement(List<int> nums, string mssg)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                int element = nums[i];
                int sum = 0;
                int lastDigit = 0;
                while (nums[i] > 0)
                {
                    lastDigit = nums[i] % 10;
                    sum += lastDigit;
                    nums[i] /= 10;
                }

                int index = 0;
                for (int j = 0; j < mssg.Length; j++)
                {
                    if (sum > mssg.Length)
                    {
                        index = sum % mssg.Length;
                    }
                    else
                    {
                        index = sum;
                    }
                }
                Console.Write(mssg[index + i]);
            }
        }
    }
}
