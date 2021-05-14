<<<<<<< HEAD
﻿using System;
=======
>>>>>>> 9a903c7fb2ffea3e48b25be51423fdb81311199c
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

<<<<<<< HEAD
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

=======
>>>>>>> 9a903c7fb2ffea3e48b25be51423fdb81311199c
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
<<<<<<< HEAD
                var regex = new Regex(_patterns.PhoneNumbers);
=======
            var regex = new Regex(_patterns.PhoneNumbers);
>>>>>>> 61f99be (Regular expressions were united.)
=======
            var regex = new Regex(_patterns.PhoneNumbers);
>>>>>>> 9a903c7fb2ffea3e48b25be51423fdb81311199c
            if (regex.IsMatch(phoneNumber))
            {
                return true;
            }
            return false;
        }
    }
}