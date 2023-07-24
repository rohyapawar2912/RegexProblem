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
            Console.WriteLine("Please enter your email address:");
            string email = Console.ReadLine();

            if (EmailValidator.IsValidEmail(email))
            {
                Console.WriteLine("Valid email address entered!");
            }
            else
            {
                Console.WriteLine("Invalid email address. The email should have 3 mandatory parts (abc, bl & co) and 2 optional (xyz & in) with precise @ and . positions.");
            }

        }
    }
}
