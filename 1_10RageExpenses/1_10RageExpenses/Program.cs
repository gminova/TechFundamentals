/*As a MOBA challenger player, Pesho has the bad habit to trash his PC when he 
 *loses a game and rage quits. His gaming setup consists of headset, mouse, 
 *keyboard and display. You will receive Pesho`s lost games count. 
Every second lost game, Pesho trashes his headset.
Every third lost game, Pesho trashes his mouse.
When Pesho trashes both his mouse and headset in the same lost game, 
he also trashes his keyboard.
Every second time, when he trashes his keyboard, he also trashes his display. 
You will receive the price of each item in his gaming setup. Calculate his rage 
expenses for renewing his gaming equipment. 

Input / Constraints
    • On the first input line - lost games count – integer in the range [0, 1000].
    • On the second line – headset price - floating point number in range [0, 1000]. 
    • On the third line – mouse price - floating point number in range [0, 1000]. 
    • On the fourth line – keyboard price - floating point number in range [0, 1000]. 
    • On the fifth line – display price - floating point number in range [0, 1000]. 
Output
    • As output you must print Pesho`s total expenses: "Rage expenses: {expenses} lv."
    • Allowed working time / memory: 100ms / 16MB.

______________________________________________________________________________
INPUT                                   OUTPUT
 7                             Rage expenses: 16.00 lv.
 2
 3
 4
 5
 _____________________________________________________________________________
 23                            Rage expenses: 608.00 lv.
 12.50
 21.50
 40
 200
 _____________________________________________________________________________
 */
using System;

namespace _1_10RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetCost = 0;
            double mouseCost = 0;
            double keyboardCost = 0;
            double displayCost = 0;

            int headset = gameCount / 2;
            int mouse = gameCount / 3;
            int keyboard = gameCount / 6;
            int display = gameCount / 12;

            if (gameCount >= 2)
            {
                headsetCost += headsetPrice * headset;
            }
            if (gameCount >= 3)
            {
                mouseCost += mousePrice * mouse;
            } 
                    if (gameCount >= 6)
            {
                keyboardCost += keyboardPrice * keyboard;
            }
            if (gameCount >= 12)
            {
                displayCost += displayPrice * display;
            }

            double expenses = headsetCost + mouseCost + keyboardCost + displayCost;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
