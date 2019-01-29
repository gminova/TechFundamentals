/*You are given a group of people, type of the group, 
 * on which day of the week they are going to stay. 
 * Based on that information calculate how much they have to pay
 * and print that price on the console. Use the table below. 
 * In each cell is the price for a single person. The output should look like
 * that: “Total price: {price}”. 
 * The price should be rounded to the second decimal point. 
 * 
**************FRIDAY***SATURDAY***SUNDAY*********************
STUDENTS------[8.45]----[9.80]---[10.46]

BUSSINESS-----[10.90]---[15.60]--[16.00]

REGULAR-------[15.00]---[20.00]--[22.50]


 * There are also discounts based on some conditions:
 * 
    • Students – if the group is bigger than or equal
    to 30 people you should reduce the total price by 15%
      
    • Business – if the group is bigger than or equal to
    100 people 10 of them can stay for free.
      
    • Regular – if the group is bigger than or equal to
    10 and less than or equal to 20 reduce the total price by 5%
      
You should reduce the prices in that EXACT order
EXAMPLE:

INPUT-----------------------OUTPUT
30
Students
Sunday                Total price: 266.73
------------------------------------------
40
Regular
Saturday              Total price: 800.00
*/

using System;

namespace _1_3Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayWeek = Console.ReadLine();
            double pricePerPerson = 0.0;
            double totalPrice = 0.0;
            double discount = 0.0;

            switch (dayWeek)
            {
                case "Friday":
                    if (groupType == "Students")
                    {
                        pricePerPerson = 8.45;
                    }
                    if (groupType == "Business")
                    {
                        pricePerPerson = 10.90;
                    }
                    if (groupType == "Regular")
                    {
                        pricePerPerson = 15.00;
                    }
                    break;
                case "Saturday":
                    if (groupType == "Students")
                    {
                        pricePerPerson = 9.80;
                    }
                    if (groupType == "Business")
                    {
                        pricePerPerson = 15.60;
                    }
                    if (groupType == "Regular")
                    {
                        pricePerPerson = 20.00;
                    }
                    break;
                case "Sunday":
                    if (groupType == "Students")
                    {
                        pricePerPerson = 10.46;
                    }
                    if (groupType == "Business")
                    {
                        pricePerPerson = 16.00;
                    }
                    if (groupType == "Regular")
                    {
                        pricePerPerson = 22.50;
                    }
                    break;
                default: Console.WriteLine("Error in input"); break;
            }

            totalPrice = numberPeople * pricePerPerson;

            if (groupType == "Students" && numberPeople >= 30)
            {
                discount = totalPrice * 0.15;
                totalPrice = totalPrice - discount;
            }
            if (groupType == "Business" && numberPeople >= 100)
            {
                totalPrice = (numberPeople - 10) * pricePerPerson;
            }
            if (groupType == "Regular" && numberPeople >= 10 && numberPeople <= 20)
            {
                discount = totalPrice * 0.05;
                totalPrice = totalPrice - discount;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}