/*Write a program, which reads a string and skips through it, extracting a hidden message.
 The algorithm you have to implement is as follows:
Let’s take the string “skipTest_String044170” as an example.
Take every digit from the string and store it somewhere. After that, remove all the digits
from the string. After this operation, you should have two lists of items: the numbers list and the non-numbers list:
    • Numbers list: [0, 4, 4, 1, 7, 0]
    • Non-numbers: [s, k, i, p, T, e, s, t, _, S, t, r, i, n, g]
After that, take every digit in the numbers list and split it up into a take list and a skip list,
depending on whether the digit is in an even or an odd index:
    • Numbers list: [0, 4, 4, 1, 7, 0]
    • Take list: [0, 4, 7]
    • Skip list: [4, 1, 0]
Afterwards, iterate over both of the lists and skip {skipCount} characters from the non-numbers list, 
then take {takeCount} characters and store it in a result string. Note that the skipped characters are 
summed up as they go. The process would look like this on the aforementioned non-numbers list:
    1. Take 0 characters  ->  Taken: "", skip 4 characters (total 0)  ->  Skipped: "skipTest_String" ->  Result: ""
    2. Take 4 characters ->  Taken: "Test", skip 1 characters (total 4)  ->  Skipped: "skip"  ->  Result: "Test"
    3. Take 7 characters ->  Taken: "String", skip 0 characters (total 9) ->  Skipped: ""  ->  Result: "TestString"
After that, just print the result string on the console.
Input
    • First line: The encrypted message as a string
Output
    • First line: The decrypted message as a string
Constraints
    • The count of digits in the input string will always be even.
    • The encrypted message will contain any printable ASCII character.
_________________________________________________________________________
Input                                                Output
T2exs15ti23ng1_3cT1h3e0_Roppe                        TestingTheRope
_________________________________________________________________________
O{1ne1T2021wf312o13Th111xreve!!@!                    OneTwoThree!!!
_________________________________________________________________________
this forbidden mess of an age rating 0127504740      hidden message
_________________________________________________________________________
*/
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _0_3TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            StringBuilder result = new StringBuilder();
            List<string> nonNumbers = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    numbers.Add(int.Parse(word[i].ToString()));
                }
                else
                {
                    nonNumbers.Add(word[i].ToString());
                }

            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            int indexForSkip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>(nonNumbers);

                temp = temp.Skip(indexForSkip).Take(takeList[i]).ToList();

                result.Append(string.Join("", temp));

                indexForSkip += takeList[i] + skipList[i];
            }

            Console.WriteLine(result.ToString());
        }
    }
}
