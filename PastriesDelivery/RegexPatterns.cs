namespace PastriesDelivery
{
    public class RegexPatterns : IRegexPatterns
    {
        public string Addresses { get; } = @"(?:улица|ул\.?)\s?[А-Я][а-я]*\.?\,?\s(?:дом|д\.?)\s?\d{2}(?:\,\s?(?:квартира|кв\.?)\s?\d{2}|)$";
        public string PhoneNumbers { get; } = @"/\+?3?8?(0[\s\.-]?\(?\d{2}\)?[\s\.-]?\d{3}[\s\.-]?\d{2}[\s\.-]?\d{2})/gm";
    }
}