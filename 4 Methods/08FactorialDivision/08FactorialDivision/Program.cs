/*Read two integer numbers. Calculate factorial of each number.
 Divide the first result by the second and print the division 
 formatted to the second decimal point.
____________________________________
Input                  Output
5
2                      60.00
____________________________________
6
2                      360.00
____________________________________
*/
using System;

namespace _08FactorialDivision
{
    class Program
    {
        public static void Main()
        {
            double i = double.Parse(Console.ReadLine());
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(Factorial(i) / Factorial(num)):F2}");
        }

        private static double Factorial(double i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
    }
}

