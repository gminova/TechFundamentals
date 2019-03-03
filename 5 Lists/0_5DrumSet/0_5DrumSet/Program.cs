/*Gabsy is Orgolt's Final Revenge charming drummer. She has a drum set but the 
 different drums have different origins – some she bought, some are gifts, so 
 they are all with different quality. Every day she practices on each of them,
 so she does damage and reduces the drum`s quality. Sometimes a drum brakes, so 
 she needs to buy new one. Help her keep her drum set organized.
 
You will receive Gabsy's savings, the money she can spend on new drums. 
Next, you will receive a sequence of integers, which represents the initial quality of each 
drum in Gabsy's drum set.
Until you receive the command "Hit it again, Gabsy!", you will be receiving an 
integer: the hit power Gabsy applies on each drum, while practicing. When the power
is applied, you should decrease the value of all the drums' quality with the current power.
When a certain drum reaches 0 quality, it breaks. Then Gabsy should buy a replacement.
She needs to buy the exact same model. Therefore, its quality will be the same as the
initial quality of the broken drum. 
The price is calculated by the formula: {initialQuality} * 3.
Gabsy will always replace her broken drums until the moment she can no longer afford it.
If she doesn't have enough money for a replacement, the broken drum is removed from the
drum set. When you receive the command "Hit it again, Gabsy!", the program ends and you 
should print the current state of the drum set. On the second line you should print the 
remaining money in Gabsy's savings account.
Input
    • On the first line you will receive the savings – a floating-point number.
    • On the second line you will recieve the drum set: a sequence of integers, separated by spaces.
    • Until you receive the command "Hit it again, Gabsy!", you will be receiving integers – the hit 
    power Gabsy applies on each drum.
Output
    • On the first line you should print each drum in the drum set, separated by space.
    • Then you must print the money that are left on the second line in the format "Gabsy has {money left}lv.", 
    formatted with two digits after the decimal point.
Constraints
    • The savings – a floating-point number in the range [0.00, 10000.00]
    • The quality of each drum in the drum set – an integer in the range [1, 1000].
    • The hit power will be in the range [0, 1000]
    • Allowed working time / memory: 100ms / 16MB.
_______________________________________________________________
Input                                     Output
1000.00                                   7 14 23
58 65 33                                  Gabsy has 901.00lv.
11
12
18
10
Hit it again, Gabsy!
___________________________
HINT:
DrumSet – 58 65 33.
Day 1: hit power applied = 11 => 47 54 22;
Day 2: hit power applied = 12 => 35 42 10;
Day 3: hit power applied = 18 => 17 24 -8;
The third drum breaks. But Gabsy has enough savings, so she replaces it => 17 24 33;
Day 4: hit power applied = 10 => 7 14 23;
We print the current state of the drum set and what's left in Gabsy's bank account. 
________________________________________________________________
154.00                                   27 2 4 7
55 111 3 5 8 50                          Gabsy has 10.00lv. 
2
50
8
23
1
Hit it again, Gabsy!
________________________________________________________________
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace _0_5DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            List <int> drums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> price = new List<int>();
            price.AddRange(drums);

            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "Hit it again, Gabsy!") break;
                int hit = int.Parse(command);
                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= hit;
                    if (drums[i] <= 0)
                    {
                        if (budget - (price[i] * 3) >= 0)
                        {
                            budget = budget - (price[i] * 3);
                            drums[i] = price[i];
                        }
                        else
                        {
                            drums.RemoveAt(i);
                            price.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            foreach (var drum in drums)
            {
                Console.Write(drum + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Gabsy has {budget:f2}lv.");
        }
    }
}
