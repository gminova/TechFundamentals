/*Rewrite you program so it can receive the multiplier from the console. 
 * Print the table from the given multiplier to 10. If the given multiplier is 
 * more than 10 - print only one row with the integer, the given multiplier and 
 * the product. See the examples below for more information.

Print every row of the table in the following format:
{integer} X {times} = {result}

Constraints:
    • The integer will be in the interval [1…100]
________________________________________________________________
INPUT                                OUTPUT
5                                    5 X 1 = 5
1                                    5 X 2 = 10
                                     5 X 3 = 15
                                     5 X 4 = 20
                                     5 X 5 = 25
                                     5 X 6 = 30
                                     5 X 7 = 35
                                     5 X 8 = 40
                                     5 X 9 = 45
                                     5 X 10 = 50
_________________________________________________________________                                                                       
2                                    2 X 1 = 2
5                                    2 X 2 = 4
                                     2 X 3 = 6
                                     2 X 4 = 8
                                     2 X 5 = 10
                                     2 X 6 = 12
                                     2 X 7 = 14
                                     2 X 8 = 16
                                     2 X 9 = 18
                                     2 X 10 = 20
_________________________________________________________________
2                                    2 X 14 = 28
14
_________________________________________________________________
*/

using System;

namespace _0_11MiltiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            for (int i = multiplier; i <= 10; i++)
            {
                int equals = n * i;
                Console.WriteLine("{0} X {1} = {2}", n, i, equals);
            }

            if (multiplier > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", n, multiplier, (n * multiplier));
            }
        }
    }
}
