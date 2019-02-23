/*Write a program that, depending on the first line of the input, reads an int, double or string.
    • If the data type is int, multiply the number by 2.
    • If the data type is real, multiply the number by 1.5 and format it to the second decimal point.
    • If the data type is string, surround the input with "$".
Print the result on the console.
_______________________________
Input                 Output
int
5                       10
_______________________________
real
2                       3.00
_______________________________
string
hello                   $hello$
_______________________________
*/
using System;

namespace _0_1DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value = Console.ReadLine();
            switch (type)
            {
                case "int": Integer(value); break;
                case "real": Double(value); break;
                default: Console.WriteLine("${0}$", value); break;
            }
        }

        private static void Integer(string value)
        {
            int isInt;
            int.TryParse(value, out isInt);
            Console.WriteLine(isInt * 2);
        }

        private static void Double(string value)
        {

            double isDouble;
            double.TryParse(value, out isDouble);
            Console.WriteLine($"{(isDouble * 1.5):f2}");
        }
    }
}
