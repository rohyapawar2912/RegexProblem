using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegexProblem
{
    public class LastNameValidator
    {
        private const string LastNamePattern = "^[A-Z][a-zA-Z]{2,}$";

        public static bool IsValidFirstName(string lastName)
        {
            return Regex.IsMatch(lastName, LastNamePattern);
        }

        internal static bool IsValidLastName(string lastName)
        {
            throw new NotImplementedException();
        }
    }
    
}
