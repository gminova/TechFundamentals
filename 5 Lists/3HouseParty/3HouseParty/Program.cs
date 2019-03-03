/*Write a program that keeps track of guests, that are going to a house party.
 On the first line of input, you are going to receive the number of commands
 you are going to receive. On the next lines you are going to receive one of 
 the following messages:
    • "{name} is going!"
    • "{name} is not going!"
If you receive the first message, you have to add the person if he/she is not 
in the list and if he/she is in the list print on the console: "{name} is 
already in the list!". If you receive the second message, you have to remove 
the person if he/she is in the list and if not print: "{name} is not in the list!".
At the end print all the guests.
______________________________________________________
Input                                Output
4                                    John is not in the list!
Allie is going!                      Allie
George is going!               
John is not going!
George is not going!
______________________________________________________
5                                    Tom is already in the list!
Tom is going!                        Tom                         
Annie is going!                      Annie
Tom is going!                        Garry
Garry is going!                      Jerry
Jerry is going!
______________________________________________________
*/
using System;
using System.Collections.Generic;

namespace _3HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCommands = int.Parse(Console.ReadLine());
            List<string> guest = new List<string>();

            for (int i = 0; i < numbersOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                if (tokens.Length == 3)
                {
                    if (!guest.Contains(tokens[0]))
                    {
                        guest.Add(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is already in the list!");
                    }
                }
                else if (tokens.Length == 4)
                {
                    if (guest.Contains(tokens[0]))
                    {
                        guest.Remove(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                }
            }

            foreach (var person in guest)
            {
                Console.WriteLine(person);
            }
        }
    }
}