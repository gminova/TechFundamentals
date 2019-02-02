/*Find online more information about ASCII 
 (American Standard Code for Information Interchange) and write
 a program that prints part of the ASCII table of characters in 
 the console.  On the first line of input you will receive the
 char index you should start with and on the second line - the
 index of the last character you should print.
_________________________________________________________
Input                                           Output
60                                            < = > ? @ A
65
_________________________________________________________
69                                  E F G H I J K L M N O
79
_________________________________________________________
97                                        a b c d e f g h
104
_________________________________________________________
40                        ( ) * + , - . / 0 1 2 3 4 5 6 7
55
_________________________________________________________
*/
using System;

namespace _5PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
