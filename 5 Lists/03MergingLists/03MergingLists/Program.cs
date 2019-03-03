/*You are going to receive two lists with numbers. 
 Create a result list, which contains the numbers from
 both of the lists. The first element should be from 
 the first list, the second from the second list and so
 on. If the length of the two lists are not equal, 
 just add the remaining elements at the end of the 
 list.
__________________________________________________
INPUT                         OUTPUT
1 3 5                         1 2 3 4 5
2 4
__________________________________________________
76 5 34 2 4 12
3 5 2 43 12 3 54 10 23        76 3 5 5 34 2 2 43 4 12 12 3 54 10 23


*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lis1 = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToList();

            List<double> lis2 = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToList();

            MergedLists(lis1, lis2);
        }

        private static List<double> MergedLists(List<double> lis1, List<double> lis2)
        {
            List<double> lis3 = new List<double> ();
            for (int i = 0; i < Math.Max(lis1.Count, lis2.Count); i++)
            {
                if (i < lis1.Count)
                {
                    lis3.Add(lis1[i]);
                }
                if (i < lis2.Count)
                {
                    lis3.Add(lis2[i]);
                }
            }
            Console.Write(string.Join(" ", lis3));
            return lis3; 
        }
    }
}
