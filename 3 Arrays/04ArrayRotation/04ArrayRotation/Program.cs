/*Write a program that receives an array and number of rotations
 you have to perform (first element goes at the end).
 Print the resulting array.
________________________________________
Input                    Output
51 47 32 61 21           32 61 21 51 47
2
________________________________________
32 21 61 1               32 21 61 1
4
________________________________________
2 4 15 31                4 15 31 2
5
________________________________________
*/
using System;
using System.Linq;

namespace _04ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] newArray = new int[array.Length];
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                newArray [(array.Length + (i - (rotations % array.Length)))% array.Length] = array[i];
            }
            foreach (var item in newArray)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
