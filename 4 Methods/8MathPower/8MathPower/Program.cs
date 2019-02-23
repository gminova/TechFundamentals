/*Create a method that calculates and returns
 the value of a number raised to a given power:
_________________
Input      Output
2           256
8
_________________
3           81
4
_________________
*/
using System;

namespace _8MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            double result = GetPow(number, pow);
            Console.WriteLine(result);
        }
        static double GetPow (double number, double pow)
        {
            double result = 1;
            if (pow > 0)
            {
                for (int i = 1; i <= pow; ++i)
                {
                    result *= number;
                }
            }
            else if (pow < 0)
            {
                for (int i = -1; i >= pow; --i)
                {
                    result /= number;
                }
            }
            return result;
        }
    }
}
