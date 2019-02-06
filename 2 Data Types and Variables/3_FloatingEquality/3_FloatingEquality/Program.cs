/*Write a program that safely compares floating-point
 numbers (double) with precision eps = 0.000001. Note that 
 we cannot directly compare two floating-point numbers 
 a and b by a==b because of the nature of the floating-point
 arithmetic. Therefore, we assume two numbers are equal if 
 they are more closely to each other than some fixed 
 constant eps.
 
You will receive two lines, each containing a floating-point
number. Your task is to compare the values of the two numbers.
_____________________________________________________________
INPUT                                                OUTPUT
5.3                                                  False
6.01
_____________________________________________________________
5.00000001                                           True
5.00000003
_____________________________________________________________
5.00000005                                           True
5.00000001
_____________________________________________________________
-0.0000007                                           True
0.00000007
_____________________________________________________________
-4.999999                                            False
-4.999998
//COMMENT: This is a border case bacause the difference
is 0.0000001== eps.However, we consider the numbers as different.
_____________________________________________________________
4.999999                                             False
4.999998
_____________________________________________________________
*/
using System;

namespace _3_FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double difference = (numOne - numTwo);
            const double eps = 0.000001;
            bool areNumsRelativelyEqual = difference < eps;
            Console.WriteLine(areNumsRelativelyEqual);
        }
    }
}
