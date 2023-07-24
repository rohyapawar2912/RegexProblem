using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegexProblem
{
    public class MobileNumberValidator
    {
        private const string MobileNumberPattern = @"^91 [1-9]\d{9}$";

        public static bool IsValidMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MobileNumberPattern);
        }
    }
    
}
