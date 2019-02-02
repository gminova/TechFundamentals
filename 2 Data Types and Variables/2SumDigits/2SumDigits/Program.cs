/*You will be given a single integer. Your task is to find the sum
 of its digits.
______________________
INPUT           OUTPUT
245678              32
97561               28
543                 12
______________________
*/
using System;

namespace _2SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string digits = num.ToString();
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                int digit = digits[i];
                sum += digit - 48; //ASCII 0 = 48;
            }
            Console.WriteLine(sum);
        }
    }
}
