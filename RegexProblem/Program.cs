using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            if (PasswordValidator.IsValidPassword(password))
            {
                Console.WriteLine("Valid password!");
            }
            else
            {
                Console.WriteLine("Invalid password. The password must have a minimum of 8 characters, at least 1 upper case character, and at least 1 numeric number.");
            }
        }
    }
}
