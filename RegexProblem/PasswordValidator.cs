using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegexProblem
{
    public class PasswordValidator
    {
        public static bool IsValidPassword(string password)
        {
            // Rule1: Minimum 8 characters
            if (password.Length < 8)
            {
                return false;
            }

            // Rule2: Should have at least 1 Upper Case
            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            // Rule3: Should have at least 1 numeric number
            if (!password.Any(char.IsDigit))
            {
                return false;
            }

            // If all rules are passed, return true
            return true;
        }
    }
    
}
