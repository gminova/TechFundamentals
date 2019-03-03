/*Write a program, which reads a list of integers from the 
 console and receives commands, which manipulate the list. 
 Your program may receive the following commands: 
    • Delete {element} – delete all elements in the list,
    which are equal to the given element.
    • Insert {element} {position} – insert an element and 
    the given position.
You should stop the program when you receive the command "end".
Print the numbers in the list elements separated by a single whitespace.
____________________________________________________________
INPUT                          OUTPUT
1 2 3 4 5 5 5 6                1 10 2 3 4 6
Delete 5
Insert 10 1
Delete 5
end
____________________________________________________________
20 12 4 319 21 0 2 41 23 4     20 12 50 319 50 21 0 2 41 23
Insert 50 2
Insert 50 5
Delete 4
end
____________________________________________________________

*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace _2ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();

                if (tokens[0] == "Delete")
                {
                    int value = int.Parse(tokens[1]);
                    nums.RemoveAll(n => n == value);
                }
                else
                {
                    nums.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                }
            }
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
