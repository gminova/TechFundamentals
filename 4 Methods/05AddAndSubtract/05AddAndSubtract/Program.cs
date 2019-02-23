/*You will receive 3 integers. Write a method Sum to get
 the sum of the first two integers and Subtract method 
 that subtracts the third integer from the result from 
 the Sum method. 
_____________________________
Input                Output
23
6
10                     19
_____________________________
1
17
30                    -12
_____________________________
42 
58
100                    0
_____________________________
*/
using System;

namespace _05AddAndSubtract
{
    class Program
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Subtract(Sum(num1, num2), num3);
        }

        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public static int Subtract(int sum, int num3)
        {
            int result = sum - num3;
            Console.WriteLine(result);
            return result;
        }
    }
}
