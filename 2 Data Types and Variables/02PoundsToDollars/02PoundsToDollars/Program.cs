/*Write a program that converts British pounds to US dollars 
 formatted to 3th decimal point.
 
1 British Pound = 1.31 Dollars
______________________________
INPUT                 OUTPUT
80                    104.800
______________________________
39                    51.090
______________________________
 */
using System;

namespace _02PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double dollars = 1.31;
            pounds *= dollars;
            Console.WriteLine($"{pounds:f3}");
        }
    }
}
