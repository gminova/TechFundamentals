/*Create a program that multiplies the sum of all even digits of
 a number by the sum of all odd digits of the same number:
    • Create a method called GetMultipleOfEvenAndOdds()
    • Create a method GetSumOfEvenDigits()
    • Create GetSumOfOddDigits()
    • You may need to use Math.Abs() for negative numbers
______________________
Input           Output
-12345           54
______________________
*/
using System;

namespace _10MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            return result;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    sum += number % 10;
                }
                number /= 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                if (number % 2 != 0)
                {
                    sum += number % 10;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
