/*Read two names and a delimiter. 
 Print the names joined by the delimiter.
 ________________________
 INPUT            OUTPUT
 John          John->Smith
 Smith
 ->
 ________________________
*/
using System;

namespace _07ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimeter = Console.ReadLine();
            Console.WriteLine("{0}{1}{2}", firstName, delimeter, lastName);
        }
    }
}
