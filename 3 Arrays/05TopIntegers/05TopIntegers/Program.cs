/*Write a program to find all the top integers in an array. 
 A top integer is an integer which is bigger than all the elements
 to its right. 
________________________________________
Input                     Output
1 4 3 2                   4 3 2 
________________________________________
14 24 3 19 15 17          24 19 17
________________________________________
27 19 42 2 13 45 48       48
________________________________________
*/
using System;
using System.Linq;

namespace _05TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); 

            for (int i = 0; i < array.Length; i++)
            {
                bool topInt = true;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        topInt = false;
                    }
                }
                if (topInt)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
