/*Write a program, which calculates the volume of n beer
 kegs. You will receive in total 3 * n lines. Each three 
 lines will hold information for a single keg. First up is
 the model of the keg, after that is the radius of the keg,
 and lastly is the height of the keg.
Calculate the volume using the following formula:
π * r^2 * h. 
At the end, print the model of the biggest keg.
Input:
You will receive 3 * n lines. Each group of lines will be on
a new line:
    • First – model – string.
    • Second –radius – floating-point number
    • Third – height – integer number
Output:
Print the model of the biggest keg.
Constraints:
    • n will be in the interval [1…10]
    • The radius will be a floating-point number in the
    interval [1…3.402823E+38]
    • The height will be an integer in the interval
    [1…2147483647]
_____________________________________________________________
INPUT                                            OUTPUT
3                                                Keg 2
Keg 1
10
10
Keg 2
20
20
Keg 3
10
30
______________________________________________________________
2                                                 Bigger Keg
Smaller Keg
2.41
10
Bigger Keg
5.12
20
_____________________________________________________________
*/
using System;

namespace _8BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numLines = byte.Parse(Console.ReadLine());
            double biggestVolume = double.MinValue;
            string biggestKeg = "";
            for (int i = 0; i < numLines; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow((double)radius, 2) * (double)height;
                if (biggestVolume <= volume)
                {
                    biggestVolume = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}