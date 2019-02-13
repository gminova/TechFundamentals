/*You will be given a count (n) of cars of a train. 
 On the next n lines you will receive how many people are going
 to get in each car. At the end print the whole train and after
 that the sum of the people in the train. 
________________________________________
Input                    Output
3                        13 24 8
13                       45
24
8
________________________________________
6                        3 52 71 13 65 4
3                        208
52
71
13
65
4
________________________________________
1                        100
100                      100
________________________________________
*/
using System;

namespace _01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCars = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] allPassangers = new int[numCars];
            for (int i = 0; i < numCars; i++)
            {
                allPassangers[i] = int.Parse(Console.ReadLine());
                sum += allPassangers[i];            
            }
            for (int i = 0; i < allPassangers.Length; i++)
            {
                Console.Write(allPassangers[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine(sum);
        }
    }
}
