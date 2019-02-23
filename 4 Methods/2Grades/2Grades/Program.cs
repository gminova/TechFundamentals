/*Write a method that receives a grade between
 2.00 and 6.00 and prints the corresponding grade in words.
    • 2.00 – 2.99 - "Fail"
    • 3.00 – 3.49 - "Poor"
    • 3.50 – 4.49 - "Good"
    • 4.50 – 5.49 - "Very good"
    • 5.50 – 6.00 - "Excellent"
____________________
Input         Output
3.33           Poor
4.50           Very good
2.99           Fail
*/
using System;

namespace _2Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Grades(double.Parse(Console.ReadLine()));
        }
        static void Grades(double number)
        {
            if (2.00 <= number && number <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (3.00 <= number && number <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (3.50 <= number && number <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (4.50 <= number && number <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (5.50 <= number && number <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
