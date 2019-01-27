/*Your task is to calculate the total price of a purchase from a vending machine.
 * Until you receive “Start” you will be given different coins that are being 
 * inserted in the machine. You have to sum them in order to have the total money
 * inserted. There is a problem though. Your vending machine only works with 0.1,
 * 0.2, 0.5, 1, and 2 coins. If someone tries to insert some other coins you have
 * to display “Cannot accept {money}” and not add it to the total money. On the 
 * next few lines until you receive “End” you will be given products to purchase.
 * Your machine has however only “Nuts”, “Water”, “Crisps”, “Soda”, “Coke”. The 
 * prices are: 2.0, 0.7, 1.5, 0.8, 1.0 respectively. If the person tries to 
 * purchase a non existing product print “Invalid product”. Be careful that the 
 * person may try to purchase a product they don’t have the money for. In that 
 * case print “Sorry, not enough money”. If the person purchases a product 
 * successfully print “Purchased {product name}”. After the “End” command print
 * the money that are left formatted to the second decimal point in the format 
 * “Change: {money left}”.
 EXAMPLE

Input--------------------------Output
 1                        Cannot accept 0.6
 1                        Purchased coke
 0.5                      Purchased soda
 0.6                      Sorry, not enough money
 Start                    Change: 0.70
 Coke
 Soda
 Crisps
 End

 */
using System;

namespace _1_7VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            double myCoin = 0.0;
            double totalSum = 0.0;
            string product = "";
            double productCost = 0.0;
            bool invalidProduct = false;
            while ((command = Console.ReadLine()) != "Start")
            {
                if (
                command == "0.1" ||
                command == "0.2" ||
                command == "0.5" ||
                command == "1" ||
                command == "2")
                {
                    myCoin = double.Parse(command);
                    totalSum += myCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {command}");
                }
            }
            while ((product = Console.ReadLine()) != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        productCost = 2.0; break;
                    case "Water":
                        productCost = 0.7; break;
                    case "Crisps":
                        productCost = 1.5; break;
                    case "Soda":
                        productCost = 0.8; break;
                    case "Coke":
                        productCost = 1.0; break;
                    default:
                        Console.WriteLine("Invalid product");
                        invalidProduct = true;
                        break;
                }
                totalSum -= productCost; 
                if (totalSum >= 0 && invalidProduct == false)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (totalSum < 0 && invalidProduct == false)
                {
                    Console.WriteLine("Sorry, not enough money");
                    totalSum += productCost;
                }
            }

            Console.WriteLine($"Change: {(totalSum):f2}");
        }
    }
}
