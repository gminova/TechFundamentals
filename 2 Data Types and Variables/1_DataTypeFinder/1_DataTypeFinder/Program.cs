/*You will receive an input until you receive "END". 
 Find what data type is the input. Possible data types are:
    • Integer 
    • Floating point 
    • Characters
    • Boolean
    • Strings
Print the result in the following format: "{input} is {data type} type"
_______________________________________________________________
Input                               Output
5                               5 is integer type
2.5                             2.5 is floating point type
true                            true is boolean type
END
_______________________________________________________________
a                               a is character type
asd                             asd is string type
-5                              -5 is integer type
END
_______________________________________________________________
*/
using System;

namespace _1_DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int checkInt;
            float checkFloat;
            char checkChar;
            bool checkBool;
            while (input != "END")
            {
                if (int.TryParse(input, out checkInt))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out checkFloat))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out checkChar))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out checkBool))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}