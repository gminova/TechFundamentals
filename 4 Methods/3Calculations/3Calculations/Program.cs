/*Write a program that receives a string on the first line
 (add, multiply, subtract, divide) and on the next two lines 
 receives two numbers. Create four methods (for each calculation) 
 and invoke the right one depending on the command. 
 The method should also print the result (needs to be void)
_____________________
Input          Output
subtract       5
               4
               1
_____________________
divide         8
               4
               2
_____________________                            
*/
using System;

namespace _3Calculations
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            switch (command)
            {
                case "add": Addition(a, b); break;
                case "subtract": Subtraction(a, b); break;
                case "multiply": Multiplication(a, b); break;
                case "divide": Division(a, b); break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        static void Addition (double a, double b)
        {
            Console.WriteLine(a + b);
        }
        static void Subtraction (double a, double b)
        {
            Console.WriteLine(a - b);
        }
        static void Multiplication (double a, double b)
        {
            Console.WriteLine(a * b);
        }
        static void Division (double a, double b)
        {
            Console.WriteLine(a / b);
        }
    }
}
