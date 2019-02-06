/*Write a program that reads 3 lines of input. 
 On each line you get a single character. 
 Combine all the characters into one string and print it on the console.
 */
using System;
using System.Text;

namespace _09CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());
            string oneTwoThree = one.ToString() + two.ToString() + three.ToString();
            Console.WriteLine(oneTwoThree);
        }
    }
}
