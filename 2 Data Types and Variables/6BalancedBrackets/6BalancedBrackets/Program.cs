/*You will receive n lines. On those lines, you will receive 
 one of the following:
    • Opening bracket – “(“,
    • Closing bracket – “)” or
    • Random string
Your task is to find out if the brackets are balanced. That means 
after every opening bracket should follow a closing one. Nested 
parentheses are not valid, and if two consecutive opening brackets 
exist, the expression should be marked as unbalanced. 
Input:
    • On the first line, you will receive n – the number of lines, which will follow
    • On the next n lines, you will receive “(”, “)” or another string
Output:
You have to print “BALANCED”, if the parentheses are balanced and “UNBALANCED” otherwise.
Constraints
    • n will be in the interval [1…20]
    • The length of the stings will be between [1…100] characters
__________________________________________________________
INPUT                                       OUTPUT
8                                          BALANCED
(
5 + 10
)
* 2 +
(
5
)
-12
___________________________________________________________
6                                           UNBALANCED
12 *
)
10 + 2 -
( 
5 + 10
)
____________________________________________________________
*/
using System;

namespace _6BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());
            int countOpen = 0;
            int countClosed = 0;
            bool lastWasOpen = false;
            for (int i = 0; i < max; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    countOpen++;
                    if (!lastWasOpen)
                    {
                        lastWasOpen = true;
                    }
                    else
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                if (input == ")")
                {
                    countClosed++;
                    lastWasOpen = false;
                }
            }
            if (countOpen == countClosed && !lastWasOpen)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
