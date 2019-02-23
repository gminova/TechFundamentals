/*You are given a number num1, num2 and num3. 
 Write a program that finds if num1 * num2 * num3 (the product) is
 negative, positive or zero. Try to do this WITHOUT multiplying the 3 numbers.
______________________
Input       Output
2           negative
3
-1
______________________
2           positive
3
1
______________________
*/
using System;

namespace _0_5MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            ResultSign(num1, num2, num3);
        }

        public static void ResultSign(double n1, double n2, double n3)
        {
            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                Console.WriteLine("zero");
            }

            else if ((n1 > 0 && n2 > 0 && n3 > 0) 
            || (n1 < 0 && n2 < 0 && n3 > 0) 
            || (n1 < 0 && n2 > 0 && n3 < 0) 
            || (n1 > 0 && n2 < 0 && n3 < 0))
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
