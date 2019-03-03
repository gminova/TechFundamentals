/*You will be given two hands of cards, which will be integer numbers. 
 Assume that you have two players. You have to find out the winning deck
 and respectively the winner.
You start from the beginning of both hands. Compare the cards from the
first deck to the cards from the second deck. The player, who has the bigger 
card, takes both cards and puts them at the back of his hand - the second 
player’s card is last, and the first person’s card (the winning one) is 
before it (second to last) and the player with the smaller card must remove
the card from his deck. If both players’ cards have the same values - no one
wins, and the two cards must be removed from the decks. The game is over, when
one of the decks is left without any cards. You have to print the winner on 
the console and the sum of the left cards: "Player {one/two} wins! Sum: {sum}".
__________________________________________________________
Input              Output
20 30 40 50        First player wins! Sum: 240
10 20 30 40
__________________________________________________________
10 20 30 40 50     Second player wins! Sum: 50
50 40 30 30 10
__________________________________________________________
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace _6CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                }

                firstPlayer.Remove(firstPlayer[0]);
                secondPlayer.Remove(secondPlayer[0]);

                if (firstPlayer.Count == 0)
                {
                    int sum = secondPlayer.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (secondPlayer.Count == 0)
                {
                    int sum = firstPlayer.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}