/*A palindrome is a number which reads the same backward as
 forward, such as 323 or 1001. Write a program which reads a
 positive integer numbers until you receive "End", for each
 number print whether the number is palindrome or not.
______________________
Input         Output
123           false
323           true
421           false
121           true
END           
______________________
32            false
2             true
232           true
1010          false
END
______________________
*/
using System;

namespace _09PalindromeIntegers
{
    class Program
    {
        public static void Main()
        {
            string n = " ";
            while ((n = Console.ReadLine()) != "END")
            {
                Console.WriteLine(Palindrome(n));
            }
        }

        private static string Palindrome(string n)
        {
            bool check = false;
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = n.Length - 1; j >= 0; j--)
                {
                    if (n[i] != n[j])
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                    }
                }
            }

            return check.ToString().ToLower();
        }
    }
}
