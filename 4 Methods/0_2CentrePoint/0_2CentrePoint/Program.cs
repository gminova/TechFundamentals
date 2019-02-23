/* You are given the coordinates of two points (real numbers)
 on a Cartesian coordinate system - X1, Y1, X2 and Y2. 
 Create a method that prints the point that is closest
 to the center of the coordinate system (0, 0) in the format (X, Y). 
 If the points are on a same distance from the center, print only the first one.
_____________________
Input          Output
2              (-1, 2) 
4
-1
2
_____________________
*/
using System;

namespace _0_2CentrePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            ClosestPoint(x1, y1, x2, y2);
        }

        private static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            if ((Math.Abs(x1) + Math.Abs(y1)) > (Math.Abs(x2) + Math.Abs(y2)))
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
        }
    }
}
