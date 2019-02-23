/*You are given the coordinates of four points in the 2D plane. 
 The first and the second pair of points form two different lines.
 Print the longer line in format "(X1, Y1)(X2, Y2)" starting with 
 the point that is closer to the center of the coordinate system (0, 0).
 If the lines are of equal length, print only the first one.
_______________________
Input        Output
2          (4, -3)(-5, -5)
4
-1
2
-5
-5
4
-3
________________________
*/
using System;

namespace _0_3LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double sumX1Y1 = Math.Abs(x1) + Math.Abs(y1);
            double sumX2Y2 = Math.Abs(x2) + Math.Abs(y2);
            double sumX3Y3 = Math.Abs(x3) + Math.Abs(y3);
            double sumX4Y4 = Math.Abs(x4) + Math.Abs(y4);
            if ((sumX1Y1 + sumX2Y2) >= (sumX3Y3 + sumX4Y4))
            {
                if (sumX1Y1 <= sumX2Y2)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
                }
            }

            else
            {
                if (sumX3Y3 <= sumX4Y4)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
                }
            }
        }
    }
}
