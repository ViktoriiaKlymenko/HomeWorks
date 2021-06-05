using System.Text.RegularExpressions;

namespace PastriesDelivery
{
    public static class DataValidator
    {
        private static string Addresses { get; } = @"(?:�����|��\.?)\s?[�-�][�-�]*\.?\,?\s(?:���|�\.?)\s?\d{2}(?:\,\s?(?:��������|��\.?)\s?\d{2}|)$";
        private static string PhoneNumbers { get; } = @"/\+?3?8?(0[\s\.-]?\(?\d{2}\)?[\s\.-]?\d{3}[\s\.-]?\d{2}[\s\.-]?\d{2})/gm";


        public static bool IsValidateAddress(string address)
        {
            var regex = new Regex(Addresses);
            return regex.IsMatch(address);
        }

        public static bool IsValidatePhoneNumber(string phoneNumber)
        {
            var regex = new Regex(PhoneNumbers);
            return regex.IsMatch(phoneNumber);
        }
    }
}