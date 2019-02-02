/*Write a program, which sums the ASCII codes of n characters and
 prints the sum on the console.
Input:
    • On the first line, you will receive n – the number of lines
    • On the next n lines – you will receive letters from the
    Latin alphabet
Output:
Print the total sum in the following format:
The sum equals: {totalSum}
Constraints:
    • n will be in the interval [1…20].
    • The characters will always be either upper or lower-case
    letters from the English alphabet
    • You will always receive one letter per line
_______________________________________________________
Input                                        Output
5                                    The sum equals: 399
A
b
C
d
E
________________________________________________________
12                                  The sum equals: 1263
S
o
f
t
U
n
i
R
u
l
z
z
_______________________________________________________
*/
using System;

namespace _4SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numLines = byte.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += letter;
            }
            Console.WriteLine("The sum equals: " + sum);
        }
    }
}
