/*Write a program, which takes as an input a grade and prints “Passed!” if the 
 * grade is equal or more than 3.00.
 * 
The input comes as a single floating-point number.

The output is either "Passed!" if the grade is equal or more than 3.00, 
otherwise you should print nothing.
______________________________________
INPUT       OUTPUT
5.32        Passed!
______________________________________
2.34        /*no output*/

using System;

namespace _0_2Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
