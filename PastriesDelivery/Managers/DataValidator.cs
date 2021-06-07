using System.Text.RegularExpressions;

namespace PastriesDelivery
{
    public static class DataValidator
    {
<<<<<<< HEAD
        private static string Addresses { get; } = @"(?:ÑƒÐ»Ð¸Ñ†Ð°|ÑƒÐ»\.?)\s?[Ð-Ð¯][Ð°-Ñ]*\.?\,?\s(?:Ð´Ð¾Ð¼|Ð´\.?)\s?\d{2}(?:\,\s?(?:ÐºÐ²Ð°Ñ€Ñ‚Ð¸Ñ€Ð°|ÐºÐ²\.?)\s?\d{2}|)$";
        private static string PhoneNumbers { get; } = @"\+?3?8?(0[\s\.-]?\(?\d{2}\)?[\s\.-]?\d{3}[\s\.-]?\d{2}[\s\.-]?\d{2})";


        public static bool IsAddressValid(string address)
        {
            var regex = new Regex(Addresses);
            return regex.IsMatch(address);
        }

        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            var regex = new Regex(PhoneNumbers);
            return regex.IsMatch(phoneNumber);
=======
        private static string addresses { get; } = @"(?:óëèöà|óë\.?)\s?[À-ß][à-ÿ]*\.?\,?\s(?:äîì|ä\.?)\s?\d{2}(?:\,\s?(?:êâàðòèðà|êâ\.?)\s?\d{2}|)$";
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
>>>>>>> main
        }
    }
}