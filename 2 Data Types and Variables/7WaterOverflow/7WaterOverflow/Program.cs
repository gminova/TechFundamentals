/*You have a water tank with capacity of 255 liters. On the
 next n lines, you will receive liters of water, which you
 have to pour in your tank. If the capacity is not enough,
 print “Insufficient capacity!” and continue reading the next
 line. On the last line, print the liters in the tank.
Input:
The input will be on two lines:
    • On the first line, you will receive n – the number of
    lines, which will follow
    • On the next n lines – you receive quantities of water,
    which you have to pour in the tank
Output
Every time you do not have enough capacity in the tank to
pour the given liters, print: "Insufficient capacity!".
On the last line, print only the liters in the tank.
Constraints
    • n will be in the interval [1…20]
    • liters will be in the interval [1…1000]
_____________________________________________________________
INPUT                             OUTPUT
5                                 Insufficient capacity!
20                                240
100
100
100
20
_____________________________________________________________
7                                 105
10
20
30
10
5
10
20
_____________________________________________________________
4
250
10                                 Insufficient capacity!
20                                 Insufficient capacity!
40                                 Insufficient capacity!
                                   250
_____________________________________________________________
*/
using System;

namespace _7WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numLines = byte.Parse(Console.ReadLine());
            int addLitres = 0;
            byte maxCapacity = byte.MaxValue;
            int sum = 0;
            for (int i = 0; i < numLines; i++)
            {
                addLitres = int.Parse(Console.ReadLine());
                sum += addLitres;
                if (sum > maxCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= addLitres;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
