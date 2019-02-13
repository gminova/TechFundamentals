/*Read an array of 4*k integers, fold it like shown below:
                      [12][3456][78]
                        |    |    |
                        v    v    v
                       [21][3456][87]                      
 and print the sum of the upper and lower two rows (each holding 2 * k integers)
 Hints
    • Create the first row after folding: the first k numbers reversed,
    followed by the last k numbers reversed.
    • Create the second row after folding: the middle 2*k numbers.
    • Sum the first and the second rows.
 __________________________________________
Input                            Output
5 2 3 6                           7 9
___________________________________________
1 2 3 4 5 6 7 8                   5 5 13 13
___________________________________________
4 3 -1 2 5 0 1 9 8 6 7 -2         1 8 4 -1 16 14
___________________________________________
*/
using System;
using System.Linq;

namespace _0_4FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            Array.Reverse(numbers);

            int[] result = new int[2 * k];
            for (int i = 0; i < k; i++)
            {
                result[i] += numbers[numbers.Length - k + i] + numbers[numbers.Length - k - i - 1];
                result[i + k] += numbers[i] + numbers[numbers.Length - (2 * k) - i - 1];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
