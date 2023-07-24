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
            Console.WriteLine("Please enter your mobile number (e.g., 91 9919819801):");
            string mobileNumber = Console.ReadLine();

            if (MobileNumberValidator.IsValidMobileNumber(mobileNumber))
            {
                Console.WriteLine("Valid mobile number entered!");
            }
            else
            {
                Console.WriteLine("Invalid mobile number. The mobile number should follow the format: 91 <10 digit number>.");
            }
        }
    }
}
