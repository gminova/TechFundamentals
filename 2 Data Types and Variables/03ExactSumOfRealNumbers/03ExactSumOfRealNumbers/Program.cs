/*Write program to enter n numbers and calculate and print their
 exact sum (without rounding).
 ____________________________________________________________
 INPUT                                    OUTPUT
 3                                        1000000000000000015
 1000000000000000000
 5
 10
 ____________________________________________________________
 2                                        333333333333.30000000003
 0.00000000003
 333333333333.3
 ____________________________________________________________
 Hints: Use decimal to not lose precision.
 */
using System;

namespace _03ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < lines; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
