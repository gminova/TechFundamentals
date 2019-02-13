/*The clone factory in Kamino got another order to clone troops. 
 But this time you are tasked to find the best DNA sequence to use
 in the production. 
You will receive the DNA length and until you receive the command
"Clone them!" you will be receiving a DNA sequences of ones and zeroes,
split by "!" (one or several).
You should select the sequence with the longest subsequence of ones. 
If there are several sequences with same length of subsequence of ones,
print the one with the leftmost starting index, if there are several sequences
with same length and starting index, select the sequence with the greater sum
of its elements.
After you receive the last command "Clone them!" you should print the
collected information in the following format:
"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
"{DNA sequence, joined by space}"

Input / Constraints:
    • The first line holds the length of the sequences – integer in range [1…100];
    • On the next lines until you receive "Clone them!" you will be receiving
    sequences (at least one) of ones and zeroes, split by "!" (one or several).
 Output:
The output should be printed on the console and consists of two lines in
the following format:
"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
"{DNA sequence, joined by space}"
_________________________________________________________________________
Input                                       Output
5                                     Best DNA sample 2 with sum: 2.
1!0!1!1!0                             0 1 1 0 0
0!1!1!0!0
Clone them!
_________________________________________________________________________
4                                     Best DNA sample 1 with sum: 3.
1!1!0!1                               1 1 0 1
1!0!0!1
1!1!0!0
Clone them!
_________________________________________________________________________
*/
using System;
using System.Linq;

namespace _09KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int length = int.Parse(Console.ReadLine());
            int[] lss = new int[length];
            int lssLength = int.MinValue, lssIndex = int.MinValue, lssSum = int.MinValue, lssStart = -1;
            int index = 1;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] data = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentLength = int.MinValue, currentIndex = int.MinValue, currentSubLength = 0, currentSubIndex = 0;
                bool isOne = false;

                for (int i = 0; i < length; i++)
                {
                    if (data[i] == 1 && isOne)
                    {
                        currentSubLength++;
                    }
                    else if (data[i] == 1)
                    {
                        isOne = true;
                        currentSubIndex = i;
                        currentSubLength = 1;
                    }
                    else if (data[i] == 0 && isOne)
                    {
                        if (currentSubLength > currentLength)
                        {
                            currentLength = currentSubLength;
                            currentIndex = currentSubIndex;
                        }
                        isOne = false;
                        currentSubLength = 0;
                        currentSubIndex = 0;
                    }
                }

                if (isOne)
                {
                    if (currentSubLength > currentLength)
                    {
                        currentLength = currentSubLength;
                        currentIndex = currentSubIndex;
                    }
                }

                if (currentLength > lssLength)
                {
                    lssLength = currentLength;
                    lssIndex = currentIndex;
                    lssSum = data.Sum();
                    lss = data;
                    lssStart = index;
                }
                else if (currentLength == lssLength)
                {
                    if (currentIndex < lssIndex)
                    {
                        lssLength = currentLength;
                        lssIndex = currentIndex;
                        lssSum = data.Sum();
                        lss = data;
                        lssStart = index;
                    }
                    else if (currentIndex == lssIndex)
                    {
                        if (data.Sum() > lssSum)
                        {
                            lssLength = currentLength;
                            lssIndex = currentIndex;
                            lssSum = data.Sum();
                            lss = data;
                            lssStart = index;
                        }
                    }
                }
                index++;
            }

            Console.WriteLine($"Best DNA sample {lssStart} with sum: {lssSum}.");
            Console.WriteLine(string.Join(" ", lss));
        }
    }
}
