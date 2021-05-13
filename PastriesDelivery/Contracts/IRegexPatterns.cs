using System.Collections.Generic;

namespace PastriesDelivery
{
    public interface IRegexPatterns
    {
        List<string> Addresses { get; }
        List<string> PhoneNumbers { get; }
    }
}