/*Write a method that receives a single integer n
 and prints nxn matrix with that number.
___________________________________
Input                 Output
3                     3 3 3
                      3 3 3
                      3 3 3
___________________________________
7                   7 7 7 7 7 7 7
                    7 7 7 7 7 7 7
                    7 7 7 7 7 7 7
                    7 7 7 7 7 7 7
                    7 7 7 7 7 7 7
                    7 7 7 7 7 7 7
___________________________________                                      
2                    2 2
                     2 2
___________________________________                                      
*/
using System;

namespace _07NxNMatrix
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Print(n);
        }

        public static void Print(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
            return;
        }
    }
}
