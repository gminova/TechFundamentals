/*The Anonymous have created a cyber hypervirus, which steals data from the CIA. You, as the lead security developer in CIA, have been tasked to analyze the software of the virus and observe its actions on the data. The virus is known for his innovative and unbeleivably clever technique of merging and dividing data into partitions. 
You will receive a single input line, containing strings, separated by spaces. The strings may contain any ASCII character except whitespace.Then you will begin receiving commands in one of the following formats:
    • merge {startIndex} {endIndex}
    • divide {index} {partitions}
Every time you receive the merge command, you must merge all elements from the startIndex, till the endIndex. In other words, you should concatenate them. 
Example: {abc, def, ghi} -> merge 0 1 -> {abcdef, ghi}
If any of the given indexes is out of the array, you must take only the range that is inside the array and merge it.
Every time you receive the divide command, you must divide the element at the given index, into several small substrings with equal length. The count of the substrings should be equal to the given partitions. 
Example: {abcdef, ghi, jkl} -> divide 0 3 -> {ab, cd, ef, ghi, jkl}
If the string cannot be exactly divided into the given partitions, make all partitions except the last with equal lengths, and make the last one – the longest. 
Example: {abcd, efgh, ijkl} -> divide 0 3 -> {a, b, cd, efgh, ijkl}
The input ends when you receive the command “3:1”. At that point you must print the resulting elements, joined by a space.
Input
    • The first input line will contain the array of data.
    • On the next several input lines you will receive commands in the format specified above.
    • The input ends when you receive the command “3:1”.
Output
    • As output you must print a single line containing the elements of the array, joined by a space.
Constrains
    • The strings in the array may contain any ASCII character except whitespace.
    • The startIndex and the endIndex will be in range [-1000, 1000].
    • The endIndex will always be greater than the startIndex.
    • The index in the divide command will always be inside the array.
    • The partitions will be in range [0, 100].
    • Allowed working time/memory: 100ms / 16MB.
______________________________________________________________________________
Input                                     Output
Ivo Johny Tony Bony Mony                  IvoJohnyTonyBonyMony
merge 0 3
merge 3 4
merge 0 3
3:1
______________________________________________________________________________
abcd efgh ijkl mnop qrst uvwx yz          abcd efgh ijkl mnop qr st uv wx yz
merge 4 10
divide 4 5
3:1
______________________________________________________________________________
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace _7AnonymusThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            while (command != "3:1")
            {
                List<string> tokens = command.Split().ToList();
                if (tokens[0] == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (startIndex > input.Count - 1)
                    {
                        startIndex = input.Count - 1;
                    }
                    if (endIndex < 0)
                    {
                        endIndex = 0;
                    }
                    else if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }
                    List<string> temp = new List<string>();
                    for (int i = startIndex; i <= endIndex; i++)
                    {

                        temp.Add(input[i]);
                    }
                    input[startIndex] = string.Join("", temp);
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        input.RemoveAt(startIndex + 1);

                    }
                }
                else if (tokens[0] == "divide")
                {
                    List<string> temp = new List<string>();
                    string toDivide = input[int.Parse(tokens[1])];
                    int partitions = int.Parse(tokens[2]);
                    int partLength = toDivide.Length / int.Parse(tokens[2]);
                    int additionalPartLength = toDivide.Length % int.Parse(tokens[2]);
                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1) partLength += additionalPartLength;
                        temp.Add(toDivide.Substring(0, partLength));
                        toDivide = toDivide.Remove(0, partLength);
                    }
                    input.RemoveAt(int.Parse(tokens[1]));
                    input.InsertRange(int.Parse(tokens[1]), temp);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}