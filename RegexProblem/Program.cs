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
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            if (FristNameValidator.IsValidFirstName(firstName))
            {
                Console.WriteLine("Valid first name entered!");
            }
            else
            {
                Console.WriteLine("Invalid first name. It should start with a capital letter and have a minimum of 3 characters.");
            }

        }
    }
}
