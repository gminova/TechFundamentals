/*Write a method that receives a string and a repeat
 count n (integer). The method should return a new 
 string (the old one repeated n times)
____________________
Input        Output
abc        abcabcabc
3
____________________
String     StringString
2
____________________
*/
using System;
using System.Text;

namespace _7RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string output = RepeatString(input, count);
            Console.WriteLine(output);
        }
        private static string RepeatString(string input, int count)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                output.Append(input);
            }
            return output.ToString();
        }

    }
}
