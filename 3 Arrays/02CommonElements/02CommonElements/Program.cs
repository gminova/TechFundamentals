/*Write a program, which prints common elements in two arrays. 
 You have to compare the elements of the second array to the 
 elements of the first.
________________________________________
Input                         Output
Hey hello 2 4                4 hello
10 hey 4 hello
________________________________________
S of t un i                  of i un
of i 10 un
________________________________________
i love to code               code i love to
code i love to
________________________________________
*/
using System;
using System.Linq;

namespace _02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split().ToArray();
            string[] array2 = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] == array1[j])
                    {
                        Console.Write($"{array2[i]} ");
                    }
                }

            }
        }
    }
}
