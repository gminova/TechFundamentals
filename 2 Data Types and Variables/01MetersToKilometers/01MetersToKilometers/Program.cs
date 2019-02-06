/*You will be given an integer that will be distance in meters. 
 Write a program that converts meters to kilometers formatted to
 the second decimal point.
 ________________________
 INPUT             OUTPUT
 1852              1.85
 ________________________
 798               0.80
 ________________________
*/
using System;

namespace _01MetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double metres = double.Parse(Console.ReadLine());
            double kilometres = 0.001;
            metres *= kilometres;
            Console.WriteLine($"{metres:f2}");
        }
    }
}
