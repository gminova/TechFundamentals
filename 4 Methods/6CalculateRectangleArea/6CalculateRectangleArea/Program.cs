/*Create a method that calculates and returns
 the area of a triangle by given width and height:
________________
Input      Output
3            12
4
________________
6            12
2
________________
*/
using System;

namespace _6CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(width, height);
            Console.WriteLine(area);
        }
        static double GetTriangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
