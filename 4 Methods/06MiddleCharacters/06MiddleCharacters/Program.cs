/*You will receive a single string. Write a method that prints the 
 middle character. If the length of the string is even there are
 two middle characters.
____________________________
Input              Output
aString               r
____________________________
someText              eT
____________________________
3245                  24
____________________________

*/
using System;

namespace _06MiddleCharacters
{
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(MiddleChar(input));
        }

        public static string MiddleChar(string input)
        {
            string middleChar = "";
            if (input.Length % 2 == 0)
            {
                middleChar = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }
            else
            {
                middleChar = input[input.Length / 2].ToString();
            }

            return middleChar;
        }
    }
}
