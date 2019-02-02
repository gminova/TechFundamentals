﻿/*Yoda is starting his newly created Jedi academy. So, he asked master Ivan Cho
to buy the needed equipment. The number of items depends on how many students 
will sign up. The equipment for the Padawan contains lightsabers, belts and robes. 
You will be given the amount of money Ivan Cho has, the number of students and 
the prices of each item. You have to help Ivan Cho calculate if the money he has
is enough to buy all of the equipment, or how much more money he needs. 
Because the lightsabres sometimes brake, Ivan Cho should buy 10% more, 
rounded up to the next integer. Also, every sixth belt is free. 

Input / Constraints
The input data should be read from the console. It will consist of exactly 5 lines:
    • The amount of money Ivan Cho has – floating-point number in range [0.00…1,000.00]
    • The count of students – integer in range [0…100]
    • The price of lightsabers for a single sabre – floating-point number in range [0.00…100.00]
    • The price of robes for a single robe – floating-point number in range [0.00…100.00]
    • The price of belts for a single belt – floating-point number in range [0.00…100.00]
The input data will always be valid. There is no need to check it explicitly.

Output
The output should be printed on the console.
    • If the calculated price of the equipment is less or equal to the money Ivan Cho has:
        ◦ "The money is enough - it would cost {the cost of the equipment}lv."
              
    • If the calculated price of the equipment is more than the money Ivan Cho has:
        ◦  "Ivan Cho will need {neededMoney}lv more."
              
    • All prices must be rounded to two digits after the decimal point.
    
    -------------------...<May the force be with you>...----------------------

EXAMPLE_____________________________________________________________________
INPUT______________________________OUTPUT
100                                The money is enough - it would cost 13.00lv.
2
1.0
2.0
3.0 
____________________________________________________________________________
100                                Ivan Cho will need 737.00lv more.
42
12.0
4.0
3.0

*/

using System;

namespace _1_9PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            float budget = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double extraSabers = Math.Ceiling(0.1 *students);
            double numSabers = students + extraSabers;
            double numRobes = students;
            int freeBelts = 0;
            if (students >= 6)
            {
                freeBelts = students / 6;
            }
            double numBelts = students - freeBelts;

            double costSabers = numSabers * saberPrice;
            double costBelts = numBelts * beltPrice;
            double costRobes = numRobes * robePrice;
            double totalCost = costSabers + costBelts + costRobes;

            if (totalCost <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(totalCost - budget):f2}lv more.");
            }
        }
    }
}
