/*Write a program which creates 2 arrays. You will be given an integer n.
 On the next n lines you get 2 integers. Form 2 arrays as shown below.
_________________________________________
Input                       Output
4                           1 10 31 20
1 5                         5 9 81 41
9 10
31 81
41 20
_________________________________________
2                           80 19
80 23                       23 31
31 19
_________________________________________
*/
using System;
using System.Linq;

namespace _03ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (i % 2 == 0)
                {
                    arr1[i] = input[0];
                    arr2[i] = input[1];
                }
                else
                {
                    arr2[i] = input[0];
                    arr1[i] = input[1];
                }
            }
            Console.WriteLine(string.Join(' ', arr1));
            Console.WriteLine(string.Join(' ', arr2));
        }
    }
}
