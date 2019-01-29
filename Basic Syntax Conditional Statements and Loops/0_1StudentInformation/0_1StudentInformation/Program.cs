/*You will be given 3 lines of input – student name, age and average grade. 
 * Your task is to print all the info about the student in the following format:
 * "Name: {student name}, Age: {student age}, Grade: {student grade}".
 ____________________________________________________________
 ____INPUT_________________OUTPUT__________________________
     John                Name: John, Age: 15, Grade: 5.40
     15
     5.40
___________________________________________________________
     Steve               Name: Steve, Age: 16, Grade: 2.50
     16
     2.50
     ______________________________________________________
*/
using System;

namespace _0_1StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
        }
    }
}
