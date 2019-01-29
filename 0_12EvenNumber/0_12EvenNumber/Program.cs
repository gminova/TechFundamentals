/*Take as an input an even number and print its absolute value. If the number is
 odd, print "Please write an even number." and continue reading numbers.
 _______________________________________________________________________________
 INPUT                                  OUTPUT
 1                                      Please write an even number.
 3                                      Please write an even number.
 6                                      The number is: 6
 _______________________________________________________________________________
 -6                                     The number is: 6
 _______________________________________________________________________________

 */
using System;

namespace _0_12EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (Math.Abs(n) % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: " + Math.Abs(n));
        }
    }
}
