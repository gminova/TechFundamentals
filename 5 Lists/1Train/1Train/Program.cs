/*You will receive a list of wagons (integers) on the first line. 
 Every integer represents the number of passengers that are currently
 in each of the wagons. On the next line, you will get the max capacity
 of each wagon (a single integer). Until you receive "end" you will be
 given two types of input:
    • Add {passengers} – add a wagon to the end with the given number of
    passengers.
    • {passengers} - find an existing wagon to fit every passenger, 
    starting from the first wagon.
At the end print the final state of the train (each of the wagons, separated
by a space).
____________________________________________
Input                     Output
32 54 21 12 4 0 23        72 54 21 12 4 75 23 10 0
75
Add 10
Add 0
30
10
75
end
____________________________________________
0 0 0 10 2 4              10 10 10 10 10 10 10
10
Add 10
10
10
10
8
6
end
____________________________________________
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace _1Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int max = int.Parse(Console.ReadLine());

            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();

                if (tokens[0] == "Add")
                {
                    if (int.Parse(tokens[1]) <= max)
                    {
                        train.Add(int.Parse(tokens[1]));
                    }
                }
                else
                {
                    int passangers = int.Parse(tokens[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (passangers + train[i] <= max)
                        {
                            train[i] += passangers;
                            passangers = 0;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(' ', train));
        }
    }
}
