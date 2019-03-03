/*Write a program that sums all of the numbers in a 
 list in the following order: 
first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.
_____________________________
        ____________
       |   ______   |
       |  |      |  |
       v  v      v  v
       1  2   3  4  5
     (1+5)=6; (2+4)=6; 3;
_____________________________
INPUT               OUTPUT
1 2 3 4 5            6 6 3
_____________________________
1 2 3 4              5 5
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lis = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToList();

            int max = lis.Count / 2;

            for (int i = 0; i < max; i++)
            {
                lis[i] += lis[lis.Count - 1];
                lis.RemoveAt(lis.Count - 1);
            }
            Console.WriteLine(string.Join (" ", lis));
        }
    }
}
