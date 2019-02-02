/*Modify the previous program, so it will print "Failed!" if the grade is lower
 * than 3.00.
The input comes as a single double number.

The output is either "Passed!" if the grade is more than 2.99, 
otherwise you should print "Failed!".
____________________________________________
INPUT                   OUTPUT
5.32                    Passed!
2.36                    Failed!
____________________________________________*/
using System;

namespace _0_3PassedOrFailed
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
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
