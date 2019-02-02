/*Read four integer numbers. Add first to the second, divide
 (integer) the sum by the third number and multiply the result by
 the fourth number. Print the result.
Constraints 
• First number will be in the range [-2,147,483,648… 2,147,483,647]
• Second number will be in the range [-2,147,483,648… 2,147,483,647]
• Third number will be in the range [-2,147,483,648… 2,147,483,647]
• Fourth number will be in the range [-2,147,483,648… 2,147,483,647]
__________________________
 INPUT            OUTPUT
 10                 30
 20                  
 3
 3
__________________________
 15                 42
 14
 2
 3
 _________________________
 */
using System;

namespace _1IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());
            double sum = (firstNum + secondNum) / thirdNum * fourthNum;
            Console.WriteLine(sum);
        }
    }
}