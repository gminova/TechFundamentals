/*     
Write a program which reverses a string and print it on the console.
__________________________
INPUT              OUTPUT
Hello              olleH

*/
using System;

namespace _04ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = input.Length -1; i >=0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
