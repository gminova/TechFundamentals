/*Write a program, which takes an integer from the console and prints the 
 * corresponding month. If the number is more than 12 or less than 1 print "Error!".

You will receive a single integer on a single line.

If the number is within the boundaries print the corresponding month,
otherwise print "Error!".
____________________________________________________
INPUT                    OUTPUT
2                        February
___________________________________
13                       Error!
___________________________________
*/
using System;

namespace _0_5MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
