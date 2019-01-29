/*Write a method that returns the English name of the last digit of a given 
 * number. Write a program that reads an integer and prints the returned value 
 * from this method.
  __________________________________________
  INPUT                    OUTPUT
  512                       two
  1                         one
  1643                      three
  __________________________________________
*/
using System;

namespace _02EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string lastDigit = "";
            for (int i = 0; i < number.Length; i++)
            {
                lastDigit = number[i].ToString();
            }
            switch (lastDigit)
            {
                case "0": Console.WriteLine("zero");break;
                case "1": Console.WriteLine("one"); break;
                case "2": Console.WriteLine("two"); break;
                case "3": Console.WriteLine("three"); break;
                case "4": Console.WriteLine("four"); break;
                case "5": Console.WriteLine("five"); break;
                case "6": Console.WriteLine("six"); break;
                case "7": Console.WriteLine("seven"); break;
                case "8": Console.WriteLine("eight"); break;
                case "9": Console.WriteLine("nine"); break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
