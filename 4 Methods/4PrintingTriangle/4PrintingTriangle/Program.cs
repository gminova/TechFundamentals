/*Create a method for printing triangles as shown below:
___________________________
Output            Input
1                   3
1 2
1 2 3
1 2
1
___________________________
1                   4
1 2
1 2 3 
1 2 3 4
1 2 3
1 2
1
___________________________
*/
using System;

namespace _4PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());
            PrintTriangle(max);
        }
        static void PrintLine(int max)
        {
            for (int i = 1; i <= max; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
        static void PrintTriangle(int max)
        {
            for (int i = 1; i <= max; i++)
            {
                PrintLine(i);
            }
            for (int j = max - 1; j >= 1; j--)
            {
                PrintLine(j);
            }
        }
    }
}
