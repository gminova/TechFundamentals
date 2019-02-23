/*Write a program that checks if a given password is valid. Password rules are:
    • 6 – 10 characters (inclusive)
    • Consists only of letters and digits
    • Have at least 2 digits 
If a password is valid print “Password is valid”. If it is not valid, for every
unfulfilled rule print a message:
    • "Password must be between 6 and 10 characters"
    • "Password must consist only of letters and digits"
    • "Password must have at least 2 digits"
_____________________________________________
Input                       Output
logIn              Password must be between 6 and 10 characters 
                   Password must have at least 2 digits
_____________________________________________
MyPass123          Password is valid
_____________________________________________
Pa$s$s             Password must consist only of letters and digits
                   Password must have at least 2 digits
_____________________________________________                 
*/
using System;
using System.Linq;

namespace _04PasswordValidator
{
    class Program
    {
        public static void Main()
        {
            char[] password = Console.ReadLine().ToArray();
            if (CheckLength(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (CheckCharacters(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (CheckTwoDigits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (CheckLength(password) && CheckCharacters(password) && CheckTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckLength(char[] password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool CheckCharacters(char[] password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckTwoDigits(char[] password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    count++;
                }
            }

            return count >= 2 ? true : false;
        }
    }
}
