using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DASInvoice
{
    static class Util
    {
        public static Boolean IsValidEmail(String source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }

        public static String RemoveNonNumeric(String input)
        {
            return Regex.Replace(input, "[^0-9]", "");
        }
    }
}
