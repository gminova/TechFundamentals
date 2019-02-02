/*Write a program to read an integer n and print all triples
 of the first n small Latin letters, ordered alphabetically.
 ____________________________________________
 INPUT                         OUTPUT
 3                              aaa
                                aab
                                aac 
                                aba
                                abb
                                abc  
                                aca
                                acb
                                acc
                                baa
                                bab
                                bac
                                bba
                                bbb
                                bbc
                                bca 
                                bcb
                                bcc
                                caa
                                cab
                                cac
                                cba
                                cbb
                                cbc
                                cca
                                ccb
                                ccc
_____________________________________________                                                              
*/
using System;

namespace _6TriplesOfLatingLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    for (int k = 0; k < max; k++)
                    {
                        Console.Write((char)('a' + i));
                        Console.Write((char)('a' + j));
                        Console.Write((char)('a' + k));
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
