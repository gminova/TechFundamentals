/*Read an array from the console and sum only the even numbers.
________________________________
Input                     Output
1 2 3 4 5 6                12
________________________________
3 5 7 9                    0
________________________________
2 4 6 8 10                 30
________________________________
*/
using System;
using System.Linq;

namespace _5SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
