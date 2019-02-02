/*Calculate how many courses will be needed to elevate n persons
 by using an elevator of capacity of p persons. The input holds
 two lines: the number of people n and the capacity p of the 
 elevator.
_______________________________________________
Input                              Output
17                                    6
3
_______________________________________________
4                                     1
5
_______________________________________________
10                                    2
5
_______________________________________________
*/
using System;

namespace _3Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;
            if (persons % capacity == 0)
            {
                courses = persons / capacity;
            }
            else
            {
                courses = (int)Math.Ceiling((decimal)persons / capacity);
            }
            Console.WriteLine(courses);
        }
    }
}
