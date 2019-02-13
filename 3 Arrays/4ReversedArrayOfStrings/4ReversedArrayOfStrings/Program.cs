/*Read an array of strings (space separated values),
 reverse it and print its elements:
______________________________________
Input                         Output
a b c d e                    e d c b a
______________________________________
-1 hi ho w                   w ho hi -1
_______________________________________
*/
using System;
using System.Linq;

namespace _4ReversedArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ').ToArray();

            for (int i = elements.Length - 1; i >= 0; i--)
            {
                Console.Write(elements[i] + " ");
            }
        }
    }
}
