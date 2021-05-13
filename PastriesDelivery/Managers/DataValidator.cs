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

        public bool ValidateAddress(string address)
        {
            foreach (var pattern in _patterns.Addresses)
            {
                var regex = new Regex(pattern);
                if (regex.IsMatch(address))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidatePhoneNumber(string phoneNumber)
        {
            foreach (var pattern in _patterns.PhoneNumbers)
            {
                var regex = new Regex(pattern);
                if (regex.IsMatch(phoneNumber))
                {
                    return true;
                }
            }
            return false;
        }
    }
}