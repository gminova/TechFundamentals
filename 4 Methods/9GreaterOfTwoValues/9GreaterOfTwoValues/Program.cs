/*Create a method GetMax() that returns the greater 
 of two values (the values can be of type int, char or string)
______________________
Input          Output
int              16
2
16
______________________
char             z
a
z
______________________
string           bbb
aaa
bbb
______________________
*/
using System;
using System.Text;

namespace _9GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            var value1 = Console.ReadLine();
            var value2 = Console.ReadLine();
            switch (valueType)
            {
                case "int": Console.WriteLine(GetMax(int.Parse(value1), int.Parse(value2))); break;
                case "char": Console.WriteLine(GetMax(char.Parse(value1), char.Parse(value2))); break;
                case "string": Console.WriteLine(GetMax(value1, value2)); break;
                default: break;
            }

        }
        static int GetMax(int value1, int value2)
        {
            int maxValue = value2;
            if (value1 > value2)
            {
                return value1;
            }
            return maxValue;
        }
        static char GetMax(char value1, char value2)
        {
            char maxValue = value2;
            if (value1 > value2)
            {
                maxValue = value1;
            }
            return maxValue;
        }
        static string GetMax(string value1, string value2)
        {
            int maxValue = value1.CompareTo(value2);
            if (maxValue > 0)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
    }
}
