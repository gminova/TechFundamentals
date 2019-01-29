/*A theatre is doing a ticket sale, but they need a program to calculate the 
 * price of a single ticket. If the given age does not fit one of the categories,
 * you should print "Error!".  You can see the prices in the table below:
 _______________________________________________________________________  
 Day / Age   |  0 <= age <= 18  |  18 < age <= 64  |  64 < age <= 122
 _______________________________________________________________________
 Weekday     |       12$        |       18$        |       12$
 Weekend     |       15$        |       20$        |       15$
 Holiday     |        5$        |       12$        |       10$
_________________________________________________________________________
The input comes in two lines. On the first line, you will receive the type of day.
On the second – the age of the person.

Print the price of the ticket according to the table, or "Error!" if the age is
not in the table.

Constraints
    • The age will be in the interval [-1000…1000].
    • The type of day will always be valid. 
________________________________________________________________________________
INPUT                            OUTPUT
Weekday
42                                18$
_________________________________________
Holiday
-12                               Error!
_________________________________________
Holiday
15                                5$
_________________________________________
Weekend
122                               15$
_________________________________________
*/
using System;

namespace _0_7TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            switch (day)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 18;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 12;
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        price = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 15;
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 10;
                    }
                    break;
            }
            if (age >= 0 && age <= 122)
            {
                Console.WriteLine(price + "$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
