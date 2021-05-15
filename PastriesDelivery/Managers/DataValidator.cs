using System;

namespace PastriesDelivery
{
    public class DataValidator
    {
        public int ValidateIsDigit(string param)
        {
            if (Int32.TryParse(param, out int result))
            {
                return result;
            }
            return default;
        }
    }
}