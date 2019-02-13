/*Read two arrays and print on the console whether they are identical or not.
 Arrays are identical if their elements are equal. If the arrays are identical
 find the sum of the first one and print on the console following message:
 "Arrays are identical. Sum: {sum}",
 otherwise find the first index where the arrays differ and print on the console the 
 following message: "Arrays are not identical. Found difference at {index} index".
_____________________________________________________________________
Input                                                 Output
10 20 30                                Arrays are identical. Sum: 60
10 20 30
_____________________________________________________________________
1 2 3 4 5                               Arrays are not identical. Found difference at 2 index
1 2 4 3 5
_____________________________________________________________________
1                                       Arrays are not identical. Found difference at 0 index
10
_____________________________________________________________________
*/
using System;
using System.Linq;

namespace _7EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            bool identical = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    identical = false;
                    break;
                }
            }
            if (identical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
