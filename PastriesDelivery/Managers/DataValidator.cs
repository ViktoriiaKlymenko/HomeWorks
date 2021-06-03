using System;
using System.Text.RegularExpressions;

namespace PastriesDelivery
{
    public static class DataValidator
    {
        private static string addresses { get; } = @"(?:�����|��\.?)\s?[�-�][�-�]*\.?\,?\s(?:���|�\.?)\s?\d{2}(?:\,\s?(?:��������|��\.?)\s?\d{2}|)$";
        private static string phoneNumbers { get; } = @"/\+?3?8?(0[\s\.-]?\(?\d{2}\)?[\s\.-]?\d{3}[\s\.-]?\d{2}[\s\.-]?\d{2})/gm";

        public static bool ValidateAddress(string address)
        {
            var regex = new Regex(addresses);
            return regex.IsMatch(address) is true;
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            var regex = new Regex(phoneNumbers);
            return regex.IsMatch(phoneNumber) is false;
        }
    }
}