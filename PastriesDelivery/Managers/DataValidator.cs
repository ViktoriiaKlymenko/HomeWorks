using System;

namespace PastriesDelivery
{
    public class DataValidator
    {
        public bool ValidateIsDigit(string param)
        {
            foreach (var ch in param)
            {
                if (!Char.IsDigit(ch))
                {
                    Console.Write("not digit");
                    return false;
                    
                }
            }
            Console.Write("digit");
            return true;
        }
    }
}