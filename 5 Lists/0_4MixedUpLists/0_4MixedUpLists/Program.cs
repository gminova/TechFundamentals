/*Write a program that mixes up two lists by some rules. 
 You will receive two lines of input, each one being a list of numbers. The rules for mixing are:
    • Start from the beginning of the first list and from the ending of the second.
    • Add element from the first and element from the second.
    • At the end there will always be a list, in which there are 2 elements remaining.
    • These elements will be the range of the elements you need to print.
    • Loop through the result list and take only the elements that fulfill the condition.
    • Print the elements ordered in ascending order and separated by a space.
    
________________________________________
Input                      Output
1 5 23 64 2 3 34 54 12     23 23 31 34 43 51 
43 23 12 31 54 51 92                           
________________________________________
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace _0_4MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> inputTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> rule = new List<int>();
            List<int> maxList = new List<int>();
            List<int> mixedList = new List<int>();
            if (inputOne.Count > inputTwo.Count)
            {
                maxList = inputOne;
            }
            else
            {
                maxList = inputTwo;
                maxList.Reverse();
            }
            for (int i = maxList.Count - 2; i < maxList.Count; i++)
            {
                rule.Add(maxList[i]);
            }
            rule.Sort();
            if (inputOne.Count > inputTwo.Count)
            {
                inputOne.RemoveRange(inputOne.Count - 2, 2);
                inputTwo.Reverse();
            }
            else
            {
                inputTwo.RemoveRange(inputTwo.Count - 2, 2);
                inputTwo.Reverse();
            }
            for (int i = 0; i < inputOne.Count; i++)
            {
                mixedList.Add(inputOne[i]);
                mixedList.Add(inputTwo[i]);
            }
            List<int> output = mixedList.FindAll(x => x > rule[0] && x < rule[1]);
            output.Sort();
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
