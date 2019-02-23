/*A top number is an integer that holds the following properties:
    • Its sum of digits is divisible by 8, e.g. 8, 16, 88.
    • Holds at least one odd digit, e.g. 232, 707, 87578.
Write a program to print all master numbers in the range [1…n].
_____________________
Input         Output
50             17
               35
_____________________
100            17
               35
               53
               71
               79
               97
_____________________
*/
using System;

namespace _010TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TopNumber(num);
        }

        private static void TopNumber(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                bool oddDigit = false;
                int currentNum = i;
                while (true)
                {
                    if (currentNum == 0) break;
                    int lastDigit = currentNum % 10;
                    sum += lastDigit;
                    if (lastDigit % 2 != 0) oddDigit = true;
                    currentNum /= 10;
                }
                if (sum % 8 == 0 && oddDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
