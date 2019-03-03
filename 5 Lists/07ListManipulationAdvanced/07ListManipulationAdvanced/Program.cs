/*Next, we are going to implement more complicated list commands,
 extending the previous task (06ListManipulationBasics).
 Again, read a list and keep reading commands until you receive "end":
 
-Contains {number} – check if the list contains the number and if
so - print "Yes", otherwise print "No such number".
-PrintEven – print all the even numbers, separated by a space.
-PrintOdd – print all the odd numbers, separated by a space.
-GetSum – print the sum of all the numbers.
-Filter {condition} {number} – print all the numbers that fulfill 
the given condition. The condition will be either '<', '>', ">=", "<=".

After the end command, print the list only if you have made some changes 
to the original list. Changes are made only from the commands from the
previous task (06ListManipulationBasics).

_____________________________________________
INPUT                         OUTPUT
2 13 43 876 342 23 543        
Contains 100                  No such number
Contains 543                  Yes
PrintEven                     2 876 342
PrintOdd                      13 43 23 543
GetSum                        1842
Filter >= 43                  43 876 342 543
Filter < 100                  2 13 43 23
end
_____________________________________________
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace _07ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            bool change = false;
            string command = "";
            while (command != "end")
            {
                command = Console.ReadLine().ToLower();

                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "add": ints.Add(int.Parse(tokens[1])); 
                    change = true; break;
                    case "remove": ints.Remove(int.Parse(tokens[1])); 
                    change = true; break;
                    case "removeat": ints.RemoveAt(int.Parse(tokens[1])); 
                    change = true; break;
                    case "insert": ints.Insert(int.Parse(tokens[2]), int.Parse(tokens[1])); 
                    change = true; break;
                    case "contains":
                        if (ints.Contains(int.Parse(tokens[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        ; break;
                    case "printeven":
                        for (int i = 0; i < ints.Count; i++)
                        {
                            if (ints[i] % 2 == 0)
                            {
                                Console.Write(ints[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "printodd":
                        for (int i = 0; i < ints.Count; i++)
                        {
                            if (ints[i] % 2 != 0)
                            {
                                Console.Write(ints[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "getsum": Console.WriteLine(ints.Sum()); break;
                    case "filter":
                        string operand = tokens[1];
                        int num = int.Parse(tokens[2]);
                        for (int i = 0; i < ints.Count; i++)
                        {
                            if (operand == "<" && ints[i] < num
                                || operand == ">" && ints[i] > num
                                || operand == ">=" && ints[i] >= num
                                || operand == "<=" && ints[i] <= num)
                            {
                                Console.Write(ints[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                }
            }
            if (change)
            {
                Console.WriteLine(string.Join(' ', ints));
            }
        }
    }
}
