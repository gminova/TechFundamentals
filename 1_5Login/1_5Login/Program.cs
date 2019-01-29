/*You will be given a string representing a username. 
 * The password will be that username reversed. 
 * Until you receive the correct password print on the console
 * “Incorrect password. Try again.”. 
 * When you receive the correct password print “User {username} logged in.” 
 * However on the fourth try if the password is still not correct print 
 * “User {username} blocked!” and end the program.

EXAMPLE
INPUT--------------------------------OUTPUT

Acer
login                          Incorrect password. Try again.
go                             Incorrect password. Try again.
let me in                      Incorrect password. Try again.
recA                           Incorrect password. Try again.
                               User Acer logged in.
-----------------------------------------------
momo
omom                           User momo logged in.
-----------------------------------------------
sunny
rainy                          Incorrect password. Try again.
cloudy                         Incorrect password. Try again.
sunny                          Incorrect password. Try again.
not sunny                      User sunny blocked!
-----------------------------------------------
*/

using System;

namespace _1_5Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string reversedUsername = "";
            int length = username.Length - 1;
            for (int j = length; j >= 0; j--)
            {
                reversedUsername = reversedUsername + username[j];
            }
            for (int i = 1; i <= 4; i++)
            {
                string password = Console.ReadLine();
                if (password != reversedUsername)
                {
                    if (i < 4)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    if (i >= 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                }
                else if (password == reversedUsername)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }                
        }
    }
}