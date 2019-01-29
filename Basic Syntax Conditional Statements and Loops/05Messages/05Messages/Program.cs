/*Write a program, which emulates typing an SMS on a phone, following this guide:
                       ___________________
                       |  1  |  2  |  3  |
                       |_____|_abc_|_def_|
                       |  4  |  5  |  6  |
                       |_ghi_|_jkl_|_mno_|
                       |  7  |  8  |  9  |
                       |_pqrs|_tuv_|_wxyz|
                       |     |  0  |     |
                       |_____|space|_____|

Following the guide, 2 becomes “a”, 22 becomes “b” and so on.
________________________________________________________________________________
INPUT                                OUTPUT
5                                    hello
44
33
555
555
666
________________________________________________________________________________
9                                    hey there
44
33
999
0
8
44
33
777
33
________________________________________________________________________________
7                                    meet me
6
33
33
8
0
6
33
________________________________________________________________________________
Hints
    • A native approach would be to just put all the possible combinations of 
    digits in a giant switch statement.
    • A smarter approach would be to come up with a mathematical formula, which
    converts a number to its alphabet representation:
____________________________________________________________________________      
Digit   |  2  |  3  |  4  |   5   |    6   |     7     |    8   |     9     |
Index   |0-1-2|3-4-5|6-7-8|9-10-11|12-13-14|15-16-17-18|19-20-21|22-23-24-25|
Letter  |a,b,c|d,e,f|g,h,i| j,k,l | m,n,o  |  p,q,r,s  | t,u,v  |  w,x,y,z  |
¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
_____________________________________________________________________________
• Let’s take the number 222 (c) for example. Our algorithm would look like this:
        ◦ Find the number of digits the number has “e.g. 222 has 3 digits”
        ◦ Find the main digit of the number “e.g.  222 has 2”
        ◦ Find the offset of the number. To do that, you can use 
        the formula: (main digit - 2) * 3
        ◦ If the main digit is 8 or 9, we need to add 1 to the offset, since the 
        digits 7 and 9 have 4 letters each
        ◦ Finally, find the letter index (a = 0, c = 2, etc.). To do that, we can use
        the following formula: (offset + digit length - 1).
        ◦ After we’ve found the letter index, we can just add that to the ASCII code
        of the lowercase letter “a” (97)
*/
using System;

namespace _06Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfPush = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < numbersOfPush; i++)
            {
                string digits = Console.ReadLine();
                int digitLength = digits.Length;
                char oneDigit = digits[0];
                var mainDigit = Char.GetNumericValue(oneDigit);
                var offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset = (mainDigit - 2) * 3 + 1;
                }
                var letterIndex = offset + digitLength - 1;
                var letterCode = letterIndex + 97;
                char letter = (char)letterCode;
                if (mainDigit == 0)
                {
                    letter = (char)(mainDigit + 32);
                }
                message += letter;
            }
            Console.WriteLine(message);
        }
    }
}
