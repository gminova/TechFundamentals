/*A number is special when its sum of digits is 5, 7 or 11.
Write a program to read an integer n and for all numbers in
the range 1…n to print the number and if it is special or 
not (True / False).
__________________________
INPUT          OUTPUT
15             1 -> False
               2 -> False
               3 -> False
               4 -> False
               5 -> True
               6 -> False
               7 -> True
               8 -> False
               9 -> False
               10 -> False
               11 -> False
               12 -> False
               13 -> False
               14 -> True
               15 -> False
*/
using System;

namespace _05SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool special = false;
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                string number = i.ToString();
                for (int k = 0; k < number.Length; k++)
                {
                    sum += number[k] - 48; //ASCII 0 = 48;
                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        special = true;
                    }
                    else
                    {
                        special = false;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }
    }
}
