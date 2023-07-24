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
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            if (LastNameValidator.IsValidLastName(lastName))
            {
                Console.WriteLine("Valid last name entered!");
            }
            else
            {
                Console.WriteLine("Invalid last name. It should start with a capital letter and have a minimum of 3 characters.");
            }

        }
    }
}
