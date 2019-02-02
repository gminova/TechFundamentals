/*Write a program to check if a given number is a strong number or not. 
 * A number is strong if the sum of the Factorial of each digit is equal to
 * the number. For example 145 is a strong number, because 1! + 4! + 5! = 145. 
 * Print "yes" if the number is strong and “no” if the number is not strong.
 Examples
Input------------------------Output
  2                            yes
3451                           no
40585                          yes
-----------------------------------
  */

using System;

namespace _1_6StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int myNum = int.Parse(num);
            int myDigit = 0;
            int factorial = 1;
            int sum = 0;

            for (int j = 0; j < num.Length; j++)
            {
                char digit = num[j];
                myDigit = digit - '0';
                for (int i = 1; i <= myDigit; ++i)
                {
                    factorial *= i;
                }
                sum += factorial;
                factorial = 1;
            }
            if (sum == myNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }            }
        
    }
}
