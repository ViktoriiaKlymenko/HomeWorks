using System.Text.RegularExpressions;

namespace PastriesDelivery
{
    public static class DataValidator
    {
        private static string addresses { get; } = @"(?:улица|ул\.?)\s?[А-Я][а-я]*\.?\,?\s(?:дом|д\.?)\s?\d{2}(?:\,\s?(?:квартира|кв\.?)\s?\d{2}|)$";
        private static string phoneNumbers { get; } = @"\+?3?8?(0[\s\.-]?\(?\d{2}\)?[\s\.-]?\d{3}[\s\.-]?\d{2}[\s\.-]?\d{2})";

        public static bool IsAddressValid(string address)
        {
            var regex = new Regex(addresses);
            return regex.IsMatch(address) is true;
        }

<<<<<<< HEAD:PastriesDelivery/Services/DataValidator.cs
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
=======
        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            var regex = new Regex(phoneNumbers);
            return regex.IsMatch(phoneNumber) is false;
>>>>>>> main:PastriesDelivery/Managers/DataValidator.cs
        }
    }
}