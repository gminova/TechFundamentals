/*You are tasked to help with the planning of the next Technology Fundamentals 
 course by keeping track of the lessons, that are going to be included in the 
 course, as well as all the exercises for the lessons. 
On the first line you will receive the initial schedule of the lessons and the 
exercises that are going to be a part of the next course, separated by comma and
space ", ". But before the course starts, some changes should be made. Until you 
receive "course start" you will be given some commands to modify the course schedule.
The possible commands are: 

Add:{lessonTitle} – add the lesson to the end of the schedule, if it does not exist.
Insert:{lessonTitle}:{index} – insert the lesson to the given index, if it does not exist.
Remove:{lessonTitle} – remove the lesson, if it exists.
Swap:{lessonTitle}:{lessonTitle} – change the place of the two lessons, if they exist.
Exercise:{lessonTitle} – add Exercise in the schedule right after the lesson index, if the
lesson exists and there is no exercise already, in the following format "{lessonTitle}-Exercise".
If the lesson doesn`t exist, add the lesson in the end of the course schedule, followed by the Exercise.

Each time you Swap or Remove a lesson, you should do the same with the Exercises, if there are any, which follow the lessons.
Input / Constraints
    • first line – the initial schedule lessons – strings, separated by comma and space ", "
    • until "course start" you will receive commands in the format described above
Output
    • Print the whole course schedule, each lesson on a new line with its number(index) in the schedule: 
"{lesson index}.{lessonTitle}"
    • Allowed working time / memory: 100ms / 16MB.
_______________________________________________________________
Input                                Output

Data Types, Objects, Lists           1.Arrays
Add:Databases                        2.Data Types
Insert:Arrays:0                      3.Objects
Remove:Lists                         4.Databases
course start
_______________________________________________________________
Arrays, Lists, Methods               1.Methods
Swap:Arrays:Methods                  2.Databases
Exercise:Databases                   3.Databases-Exercise
Swap:Lists:Databases                 4.Arrays
Insert:Arrays:0                      5.Lists
course start
_______________________________________________________________
*/
using System;
using System.Linq;

namespace _CoursePlanning
{
    class Program
    {
        static void Main()
        {
            var lessons = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                var command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

                var command1 = command[0];

                if (command1 == "course start")
                {
                    break;
                }

                if (command1 == "Add")
                {
                    if (!lessons.Contains(command[1]))
                    {
                        lessons.Add(command[1]);
                    }
                }
                else if (command1 == "Insert")
                {
                    if (!lessons.Contains(command[1]))
                    {
                        if (Convert.ToInt32(command[2]) < lessons.Count &&
                            Convert.ToInt32(command[2]) >= 0)
                        {
                            lessons.Insert(Convert.ToInt32(command[2]), command[1]);
                        }

                    }
                }
                else if (command1 == "Remove")
                {
                    lessons.Remove(command[1]);
                    lessons.Remove($"{command[1]}-Exercise");
                }
                else if (command1 == "Swap")
                {
                    string lessonTitle1 = command[1];
                    string lessonTitle2 = command[2];

                    int index1 = lessons.IndexOf(lessonTitle1);
                    int index2 = lessons.IndexOf(lessonTitle2);
                    if (index1 != -1 && index2 != -1)
                    {
                        lessons[index1] = lessonTitle2;
                        lessons[index2] = lessonTitle1;

                        if (index1 + 1 < lessons.Count && lessons[index1 + 1] == $"{lessonTitle1}-Exercise")
                        {
                            lessons.RemoveAt(index1 + 1);
                            index1 = lessons.IndexOf(lessonTitle1);
                            lessons.Insert(index1 + 1, $"{lessonTitle1}-Exercise");
                        }

                        if (index2 + 1 < lessons.Count && lessons[index2 + 1] == $"{lessonTitle2}-Exercise")
                        {
                            lessons.RemoveAt(index2 + 1);
                            index2 = lessons.IndexOf(lessonTitle2);
                            lessons.Insert(index2 + 1, $"{lessonTitle2}-Exercise");
                        }
                    }
                }
                else if (command1 == "Exercise")
                {
                    int index = lessons.IndexOf(command[1]);
                    if (lessons.Contains(command[1]) && !lessons.Contains($"{command[1]}-Exercise"))
                    {
                        lessons.Insert(index + 1, $"{command[1]}-Exercise");
                    }
                    else if (!lessons.Contains(command[1]))
                    {
                        lessons.Add(command[1]);
                        lessons.Add($"{command[1]}-Exercise");
                    }
                }
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}