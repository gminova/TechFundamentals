/*Write a program, which receives a number – n, 
 * and prints a triangle from 1 to n as in the examples.
Constraints: n will be in the interval [1...20].

 EXAMPLE
____________________________
_INPUT________________OUTPUT
   3                  1
                      2 2
                      3 3 3
_____________________________
   5                  1
                      2 2
                      3 3 3
                      4 4 4 4
                      5 5 5 5 5
 _____________________________
   6                  1
                      2 2
                      3 3 3
                      4 4 4 4
                      5 5 5 5 5
                      6 6 6 6 6 6
_______________________________                                          
 */
using System;

namespace _1_8TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
