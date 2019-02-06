/*You will receive a number which represent how many lines we will
 get as an input. On the next N lines, you will receive a string
 with 2 numbers separated by single space. You need to compare them.
 If the left number is greater than the right number, you need to
 print the sum of all digits in the left number, otherwise print the
 sum of all digits in the right number.
 ___________________________________________________
 INPUT                                   OUTPUT
 2                                         2
1000 2000                                  2
2000 1000
____________________________________________________
4                                          46
123456 2147483647                          5
5000000 -500000                            49
97766554 97766554                          90
9999999999 8888888888
____________________________________________________
 */
using System;

namespace _2_FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                char delimiter = ' ';
                string[] splitNumbers = numbers.Split(delimiter);

                long leftNum = long.Parse(splitNumbers[0]);
                long rightNum = long.Parse(splitNumbers[1]);

                long biggerNumber = rightNum;
                if (leftNum > rightNum)
                {
                    biggerNumber = leftNum;
                }

                long sumOfDigits = 0;
                while (biggerNumber != 0)
                {
                    sumOfDigits += biggerNumber % 10;
                    biggerNumber /= 10;
                }
                Console.WriteLine(Math.Abs(sumOfDigits));
            }

        }
    }
}
