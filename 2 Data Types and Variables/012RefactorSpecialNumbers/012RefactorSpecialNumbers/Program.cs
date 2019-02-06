﻿/*You are given a working code that is a solution to Problem 9.
 Special Numbers. However, the variables are improperly named,
 declared before they are needed and some of them are used for multiple things.
 Without using your previous solution, modify the code so that it is easy to read
 and understand.

Sample Code:

 int kolkko = int.Parse(Console.ReadLine());
 int obshto = 0;
 int takova = 0;
 bool toe = false;
 for (int ch = 1; ch <= kolkko; ch++)
 {
        takova = ch;
         while (ch > 0)
         {
             obshto += ch % 10;
             ch = ch / 10;
         }
     toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
     Console.WriteLine("{0} -> {1}", takova, toe);
     obshto = 0;
     ch = takova;
 }

Hints
    • Reduce the span of the variables by declaring them in the moment they receive a value, not before
    • Rename your variables to represent their real purpose (example: "toe" should become isSpecialNum, etc.)
    • Search for variables that have multiple purpose. If you find any, introduce a new variable
*/
using System;

namespace _012RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int numChecked = 0;
            bool isSpecial = false;
            for (int i = 1; i <= num; i++)
            {
                numChecked = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", numChecked, isSpecial);
                sum = 0;
                i = numChecked;
            }
        }
    }
}
