/*ly likes to play Pokemon Go a lot. But Pokemon Go bankrupted … So the developers made Pokemon Don’t Go out of depression. And so Ely now plays Pokemon Don’t Go. In Pokemon Don’t Go, when you walk to a certain pokemon, those closer to you, naturally get further, and those further from you, get closer.
You will receive a sequence of integers, separated by spaces – the distances to the pokemons. Then you will begin receiving integers, which will correspond to indexes in that sequence.
When you receive an index, you must remove the element at that index from the sequence (as if you’ve captured the pokemon).
    • You must increase the value of all elements in the sequence, which are less or equal to the removed element, with the value of the removed element.
    • You must decrease the value of all elements in the sequence, which are greater than the removed element, with the value of the removed element.
If the given index is less than 0, remove the first element of the sequence, and copy the last element to its place.
If the given index is greater than the last index of the sequence, remove the last element from the sequence, and copy the first element to its place.
The increasing and decreasing of elements should be done in these cases, also. The element, whose value you should use is the removed element.
The program ends when the sequence has no elements (there are no pokemons left for Ely to catch).
Input
    • On the first line of input you will receive a sequence of integers, separated by spaces.
    • On the next several lines you will receive integers – the indexes.
Output
    • When the program ends, you must print the summed value of all removed elements.
Constrains
    • The input data will consist only of valid integers in the range [-2.147.483.648, 2.147.483.647].

_____________________________________________________
Input                             Output
4 5 3                             14
1
1
0
_____________________________________________________
5 10 6 3 5                        51
2
4
1
1
3
0
0
______________________________________________________
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int removedElement = 0;

            while (!sequence.Count.Equals(0))
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    removedElement = sequence[0];
                    sum += removedElement;
                    sequence[0] = sequence[sequence.Count - 1];

                    IncreaseAndDecrease(sequence, removedElement);
                }
                else if (index >= sequence.Count)
                {
                    removedElement = sequence[sequence.Count - 1];
                    sum += removedElement;
                    sequence[sequence.Count - 1] = sequence[0];

                    IncreaseAndDecrease(sequence, removedElement);
                }
                else
                {
                    removedElement = sequence[index];
                    sum += removedElement;
                    sequence.RemoveAt(index);

                    IncreaseAndDecrease(sequence, removedElement);
                }
            }

            Console.WriteLine(sum);
        }

        private static List<int> IncreaseAndDecrease(List<int> sequence, int removedElement)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] <= removedElement)
                {
                    sequence[i] += removedElement;
                }
                else if (sequence[i] > removedElement)
                {
                    sequence[i] -= removedElement;
                }
            }

            return sequence;
        }
    }
}
