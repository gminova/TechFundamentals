/*Read a list of integers, remove all negative numbers from
 it and print the remaining elements in reversed order. 
 In case there are no elements left in the list, print 
 "empty".
________________________________________
Input                   Output
10 -5 7 9 -33 50        50 9 7 10
________________________________________
7 -2 -10 1              1 7
________________________________________
-1 -2 -3                empty
________________________________________
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace _05RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> ls = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            RemoveNegativesAndReverse(ls);
        }

        private static List<double> RemoveNegativesAndReverse(List<double> ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i] < 0)
                {
                    ls.RemoveAt(i);
                    i -= 1;
                }
            }
            ls.Reverse();
            if (ls.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", ls));
            }

            return ls;
        }
    }
}
