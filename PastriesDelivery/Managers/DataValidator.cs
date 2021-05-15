using System;
using System.Text.RegularExpressions;

namespace PastriesDelivery
{
    public class DataValidator
    {
        private readonly IRegexPatterns _patterns;

        public DataValidator(IRegexPatterns patterns)
        {
            _patterns = patterns;
        }

        public static int ValidateIsDigit(string param)
        {
            if (Int32.TryParse(param, out int result))
            {
                return result;
            }
            return default;
        }

        public bool ValidateAddress(string address)
        {
            var regex = new Regex(_patterns.Addresses);
            if (regex.IsMatch(address))
            {
                return true;
            }
            return false;
        }

        public bool ValidatePhoneNumber(string phoneNumber)
        {
            var regex = new Regex(_patterns.PhoneNumbers);
            if (regex.IsMatch(phoneNumber))
            {
                return true;
            }
            return false;
        }
    }
}