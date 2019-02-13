/*Write a program that reads a sequence of strings from the console.
 Encrypt every string by summing:
    • The code of each vowel multiplied by the string length
    • The code of each consonant divided by the string length
Sort the number sequence in ascending order and print it on the console.
On first line, you will always receive the number of strings you have to read.
________________________
Input             Output
4 
Peter             1032
Maria             1071
Katya             1168
Todor             1532
________________________
3
Sofia             1396
London            1601
Washington        3202
________________________ 
*/
using System;
using System.Linq;

namespace _0_1EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStrings = int.Parse(Console.ReadLine());
            int[] numbers = new int[numberStrings];
            string vowels = "aAeEiIoOuU";
            char[] vowelsArr = vowels.ToCharArray();

            for (int i = 0; i < numberStrings; i++)
            {
                string word = Console.ReadLine();
                char[] letters = word.ToCharArray();

                int sum = 0;
                for (int j = 0; j < letters.Length; j++)
                {
                    char currentChar = letters[j];
                    if (vowelsArr.Contains(currentChar))
                    {
                        sum += letters[j] * letters.Length;
                    }
                    else
                    {
                        sum += letters[j] / letters.Length;
                    }
                }
                numbers[i] = sum;
            }

            Array.Sort(numbers);

            foreach (var element in numbers)
            {
                Console.WriteLine($"{element}");
            }
        }
    }
}
