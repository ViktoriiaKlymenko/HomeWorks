using System;
using System.Text.RegularExpressions;

namespace PastriesDelivery
{
    public class DataValidator
    {
<<<<<<< HEAD
        private readonly IRegexPatterns _patterns;

        public DataValidator(IRegexPatterns patterns)
        {
            _patterns = patterns;
        }


        public bool ValidateAddress(string address)
        {
            var regex = new Regex(_patterns.Addresses);
            return regex.IsMatch(address) is true;
        }

        public bool ValidatePhoneNumber(string phoneNumber)
        {
            var regex = new Regex(_patterns.PhoneNumbers);
            return regex.IsMatch(phoneNumber) is false;
=======
        public int ValidateIsDigit(string param)
        {
            if (Int32.TryParse(param, out int result))
            {
                return result;
            }
            return default;
>>>>>>> 6503217 (Code was improved.)
        }
    }
}