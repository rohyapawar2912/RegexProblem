using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegexProblem
{
    public class FristNameValidator
    {
        private const string FirstNamePattern = "^[A-Z][a-zA-Z]{2,}$";

        public static bool IsValidFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, FirstNamePattern);
        }

    }
    
}
