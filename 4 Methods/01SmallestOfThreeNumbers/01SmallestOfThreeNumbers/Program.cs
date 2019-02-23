/*Write a method to print the smallest of three 
 integer numbers. Use appropriate name for the method.
_______________________________________
Input                  Output
2
5
3                         2
_______________________________________
600
342
123                       123
_______________________________________
25
21
4                         4
_______________________________________
*/
using System;

namespace _01SmallestOfThreeNumbers
{
    class Program
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            GetSmallestInt(num1, num2, num3);
        }

        private static int GetSmallestInt(int num1, int num2, int num3)
        {
            int smallestInt = num3;
            if (num1 < num3)
            {
                smallestInt = num1;
                if (num2 < num1)
                {
                    smallestInt = num2;
                }
            }
            else if (num2 < num3)
            {
                smallestInt = num2;
                if (num1 < num2)
                {
                    smallestInt = num1;
                }
            }
            Console.WriteLine(smallestInt);
            return smallestInt;
        }
    }
}
