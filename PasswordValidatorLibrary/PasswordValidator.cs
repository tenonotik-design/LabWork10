using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordValidatorLibrary
{
    public static class PasswordValidator
    {
        public static bool Validate(string? password)
        {
            if (string.IsNullOrEmpty(password)) 
                return false;

            if (password.Length < 8) 
                return false;

            bool hasDigit = false;
            bool hasLatin = false;

            foreach (char c in password) 
            {
                if (char.IsDigit(c)) 
                    hasDigit = true;
                else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    hasLatin = true;
            }

            return hasDigit && hasLatin;
        }
    }
}
