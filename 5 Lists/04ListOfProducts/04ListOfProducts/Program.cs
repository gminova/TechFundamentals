/*Read a number n and n lines of products. Print a numbered
 list of all the products ordered by name.
_______________________________
Input              Output
4                  1.Apples
Potatoes           2.Onions
Tomatoes           3.Potatoes
Onions             4.Tomatoes
Apples
_______________________________
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace _04ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = Console.ReadLine()
            .Split(' ')
            .ToList();

            ListOfProducts(n, products);
        }

        private static void ListOfProducts(int n, List<string> products)
        {
            for (int i = 0; i < n - 1; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }
            products.Sort();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
