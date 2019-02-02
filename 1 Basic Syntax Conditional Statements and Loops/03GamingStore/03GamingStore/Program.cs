/*Write a program, which helps you buy the games. The valid games are the 
 following games in this table:
__________________________________________________
Name                                Price
__________________________________________________
OutFall 4                           $39.99
CS: OG                              $15.99
Zplinter Zell                       $19.99
Honored 2                           $59.99
RoverWatch                          $29.99
RoverWatch Origins Edition          $39.99
__________________________________________________
On the first line, you will receive your current balance – a floating-point 
number in the range [0.00…5000.00].
Until you receive the command “Game Time”, you have to keep buying games. When a
game is bought, the user’s balance decreases by the price of the game.
Additionally, the program should obey the following conditions:
    • If a game the user is trying to buy is not present in the table above, 
    print “Not Found” and read the next line.
    • If at any point, the user has $0 left, print “Out of money!” and end the 
    program.
    • Alternatively, if the user is trying to buy a game which they can’t afford,
    print “Too Expensive” and read the next line.
    • If the game exists and the player has the money for it, print 
    “Bought {nameOfGame}”
When you receive “Game Time”, print the user’s remaining money and total spent 
on games, rounded to the 2nd decimal place.
____________________________________________________________________
INPUT                             OUTPUT
120                            Bought RoverWatch
RoverWatch                     Bought Honored 2
Honored 2                      Total spent: $89.98. Remaining: $30.02
Game Time
____________________________________________________________________
19.99                          Not Found    
Reimen origin                  Too Expensive
RoverWatch                     Bought Zplinter Zell
Zplinter Zell                  Out of money!
Game Time
____________________________________________________________________
79.99                          Bought OutFall 4
OutFall 4                      Bought RoverWatch Origins Edition
RoverWatch Origins Edition     Total spent: $79.98. Remaining: $0.01
Game Time
____________________________________________________________________
*/
using System;

namespace _03GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command = "";
            double startBudget = budget;
            double price = 0;
            bool outOfMoney = false;
            bool wrongProduct = false;
            while ((command = Console.ReadLine()) != "Game Time")
            {
                switch (command)
                {
                    case "OutFall 4":
                        price = 39.99;
                        wrongProduct = false; break;
                    case "CS: OG":
                        price = 15.99;
                        wrongProduct = false; break;
                    case "Zplinter Zell":
                        price = 19.99;
                        wrongProduct = false; break;
                    case "Honored 2":
                        price = 59.99;
                        wrongProduct = false; break;
                    case "RoverWatch":
                        price = 29.99;
                        wrongProduct = false; break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        wrongProduct = false; break;
                    default:
                        wrongProduct = true;
                        Console.WriteLine("Not Found");
                        break;
                }
                if (budget >= price && wrongProduct == false)
                {
                    budget -= price;
                    Console.WriteLine($"Bought {command}");
                    if (budget <= 0)
                    {
                        outOfMoney = true;
                        Console.WriteLine("Out of money!");
                    }
                }
                else if (budget < price && outOfMoney == false)
                {
                    Console.WriteLine($"Too Expensive");
                }
            }
            if (outOfMoney == false)
            {
                Console.Write($"Total spent: ${(startBudget - budget):f2}. ");
                Console.Write($"Remaining: ${(budget):f2}");
            }
        }
    }
}