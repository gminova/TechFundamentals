/*You will be given a list of integer numbers on the first line of input. 
 You will be receiving operations you have to apply on the list until you receive the "End" command. 
 The possible commands are:
    • Add {number} – add number at the end.
    • Insert {number} {index} – insert number at given index.
    • Remove {index} – remove at index.
    • Shift left {count} – first number becomes last ‘count’ times.
    • Shift right {count} – last number becomes first ‘count’ times.
Note: there is a possibility that the given index is outside of the bounds of the array.
In that case print "Invalid index"
________________________________________
Input                     Output
1 23 29 18 43 21 20        43 20 5 1 23 29 18
Add 5
Remove 5
Shift left 3
Shift left 1
End
________________________________________
5 12 42 95 32 1            Invalid index
Insert 3 0                 5 12 42 95 32 8 1 3
Remove 10
Insert 8 6
Shift right 1
Shift left 2
End
________________________________________
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace _4ListOperations
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandLine = command.Split();
                ExecuteCommands(numbers, commandLine);
            }
            Console.WriteLine(String.Join(" ", numbers));

        }
        private static void ExecuteCommands(List<int> numbers, string[] commandLine)
        {
            if (commandLine[0] == "Add")
            {
                numbers.Add(int.Parse(commandLine[1]));
            }
            else if (commandLine[0] == "Remove")
            {
                int index = int.Parse(commandLine[1]);
                if (index >= 0 && index < numbers.Count)
                {
                    numbers.RemoveAt(index);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            else if (commandLine[0] == "Insert")
            {
                int index = int.Parse(commandLine[2]);
                int element = int.Parse(commandLine[1]);

                if (index >= 0 && index < numbers.Count)
                {
                    numbers.Insert(index, element);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            else if (commandLine[0] == "Shift")
            {
                string direction = commandLine[1];
                int count = int.Parse(commandLine[2]);
                ShiftList(numbers, direction, count);
            }
        }
        private static void ShiftList(List<int> numbers, string direction, int count)
        {
            if (direction == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    int tempNumber = numbers[0];
                    numbers.Add(tempNumber);
                    numbers.RemoveAt(0);
                }
            }
            else if (direction == "right")
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
        }
    }
}
