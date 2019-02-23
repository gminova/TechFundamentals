/*Write a method that calculates the total price of an order
 and prints it on the console. The method should receive one
 of the following products: coffee, coke, water, snacks; 
 and a quantity of the product. The prices for a single piece
 of each product are: 
    • coffee – 1.50
    • water – 1.00
    • coke – 1.40
    • snacks – 2.00
Print the result formatted to the second decimal place
_____________________________
Input                Output
water                  5.00
5
_____________________________
coffee                 3.00
2
_____________________________
*/
using System;

namespace _5Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            switch (order)
            {
                case "coffee": TotalPriceOrder(quantity, 1.50); break;
                case "water": TotalPriceOrder(quantity, 1.00); break;
                case "coke": TotalPriceOrder(quantity, 1.40); break;
                case "snacks": TotalPriceOrder(quantity, 2.00); break;
                default: Console.WriteLine("Item not available");break;
            }
        }
        static void TotalPriceOrder(int quantity, double price)
        {
            Console.WriteLine($"{quantity *  price:f2}");
        }
    }
}
