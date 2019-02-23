/*Write a method that receives a single string and prints
 the count of the vowels. Use appropriate name for the method.
_______________________________________________
Input                       Output
SoftUni                      3
_______________________________________________
Cats                         1
_______________________________________________
JS                           0
_______________________________________________
*/
using System;
using System.Collections.Generic;

namespace _02VowelsCount
{
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(CountVowels(input));
        }

        public static int CountVowels(string input)
        {
            int count = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
