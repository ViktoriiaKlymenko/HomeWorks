using System.Text.RegularExpressions;

namespace PastriesDelivery
{
    public static class DataValidator
    {
        private static string Addresses { get; } = @"(?:улица|ул\.?)\s?[А-Я][а-я]*\.?\,?\s(?:дом|д\.?)\s?\d{2}(?:\,\s?(?:квартира|кв\.?)\s?\d{2}|)$";
        private static string PhoneNumbers { get; } = @"\+?3?8?(0[\s\.-]?\(?\d{2}\)?[\s\.-]?\d{3}[\s\.-]?\d{2}[\s\.-]?\d{2})";

        public static bool ValidateAddress(string address)
        {
            var regex = new Regex(Addresses);
            if (regex.IsMatch(address))
            {
                return true;
            }
            return false;
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            var regex = new Regex(PhoneNumbers);
            if (regex.IsMatch(phoneNumber))
            {
                return true;
            }
            return false;
        }
    }
}