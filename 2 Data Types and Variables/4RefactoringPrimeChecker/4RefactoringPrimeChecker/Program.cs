/*You are given a program that checks if numbers in a given range [2...N]
 are prime. For each number is printed "{number} -> {true or false}". The code 
 however, is not very well written. Your job is to modify it in a way that is 
 easy to read and understand.
_______________________________________________________
int ___Do___ = int.Parse(Console.ReadLine());
for (int takoa = 2; takoa <= ___Do___; takoa++)
{
   bool takovalie = true;
   for (int cepitel = 2; cepitel < takoa; cepitel++)
   {
       if (takoa % cepitel == 0)
       {
          takovalie = false;
          break;
       }
   }
Console.WriteLine("{0} -> {1}", takoa, takovalie);
}
________________________________________________________
INPUT                        OUTPUT
5                            2 -> true
                             3 -> true
                             4 -> false
                             5 -> true
________________________________________________________
*/
using System;

namespace _4RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());
            for (int i = 2; i <= max; i++)
            {
                bool isNumberPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isNumberPrime = false;
                        break;
                    }
                }
                if (isNumberPrime == false)
                {
                    Console.WriteLine("{0} -> false", i);
                }
                else
                {
                    Console.WriteLine("{0} -> true", i);
                }
            }
        }
    }
}
