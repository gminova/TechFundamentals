/*Write a method that receives two characters and prints
 on a single line all the characters in between them according to ASCII.
________________________________________________________________________
Input             Output
a
d                 b c
________________________________________________________________________
#
:                 $ % & ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9
________________________________________________________________________
C
#                 $ % & ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9 : ; < = > ? @ A B
________________________________________________________________________
*/
using System;

namespace _03CharactersInRange
{
    class Program
    {
        public static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintRange(start, end);
        }

        private static void PrintRange(char start, char end)
        {
            if ((int)start < (int)end)
            {
                for (int i = (int)start + 1; i < (int)end; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = (int)end + 1; i < (int)start; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
