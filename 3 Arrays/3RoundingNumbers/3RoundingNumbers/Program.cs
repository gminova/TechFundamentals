/*Read an array of real numbers (space separated),
 round them in "away from 0" style and print the 
 output as in the examples:
_______________________________________
Input                      Output
0.9                        0.9 => 1 
1.5                        1.5 => 2
2.4                        2.4 => 2
2.5                        2.5 => 3
3.14                       3.14 => 3
________________________________________
-5.01                      -5.01 => -5
-1.599                     -1.599 => -2
-2.5                       -2.5 => -3
-1.50                      -1.50 => -2
0                          0 => 0
_________________________________________
*/
using System;
using System.Linq;

namespace _3RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNums = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            }
            for (int j= 0; j < roundedNums.Length; j++)
            {
                Console.WriteLine($"{numbers[j]} => {roundedNums[j]}");
            }
        }
    }
}
