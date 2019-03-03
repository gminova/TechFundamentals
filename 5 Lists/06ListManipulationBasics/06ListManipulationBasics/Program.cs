/*Write a program that reads a list of integers. 
 *Then until you receive "end", you will receive different
 commands:
Add {number}: add a number to the end of the list.
Remove {number}: remove a number from the list.
RemoveAt {index}: remove a number at a given index.
Insert {number} {index}: insert a number at a given index.
Note: All the indices will be valid!
When you receive the "end" command, print the final state
of the list (separated by spaces).
__________________________
INPUT              OUTPUT
4 19 2 53 6 43     4 53 6 8 43 3
Add 3
Remove 2
RemoveAt 1
Insert 8 3
end
__________________________
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace _06ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = "";
            while (command != "end")
            {
                command = Console.ReadLine().ToLower();

                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "add": ints.Add(int.Parse(tokens[1])); break;
                    case "remove": ints.Remove(int.Parse(tokens[1])); break;
                    case "removeat": ints.RemoveAt(int.Parse(tokens[1])); break; 
                    case "insert": ints.Insert(int.Parse(tokens[2]), int.Parse(tokens[1])); break;  
                }              
            }
            Console.WriteLine(string.Join(' ', ints));
        }
    }
}
