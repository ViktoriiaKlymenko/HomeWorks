using System;
﻿using System.Text.RegularExpressions;

namespace PastriesDelivery
{
    public class DataValidator
    {
        private readonly IRegexPatterns _patterns;

        public DataValidator(IRegexPatterns patterns)
        {
            _patterns = patterns;
        }

        public static bool ValidateIsDigit(string param)
        {
<<<<<<< HEAD
            foreach (var ch in param)
            {
                if (!Char.IsDigit(ch))
                {
                    Console.Write("not digit");
                    return false;
                }
=======
            var regex = new Regex(_patterns.Addresses);
            if (regex.IsMatch(address))
            {
                return true;
>>>>>>> 61f99be (Regular expressions were united.)
            }
            Console.Write("digit");
            return true;
        }

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
<<<<<<< HEAD
                var regex = new Regex(_patterns.PhoneNumbers);
=======
            var regex = new Regex(_patterns.PhoneNumbers);
>>>>>>> 61f99be (Regular expressions were united.)
            if (regex.IsMatch(phoneNumber))
            {
                return true;
            }
            return false;
        }
    }
}