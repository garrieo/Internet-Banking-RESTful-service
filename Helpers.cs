using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_Banking_RESTful_service
{
    public class Helpers
    {
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static bool IsPasswordStrong(string password)
        {
            password = password.Trim();

            if (password.Length < 8)
                return false;

            if (!StrongEnough(password))
                return false;

            return true;
        }

        private static bool StrongEnough(string password)
        {
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            bool hasSpecialCharacters = false;
            foreach (char c in password)
            {

                if (Char.IsWhiteSpace(c))
                    return false;
                if (Char.IsUpper(c))
                    hasUpperCase = true;
                if (Char.IsLower(c))
                    hasLowerCase = true;
                if (Char.IsDigit(c))
                    hasDigit = true;
                if (!Char.IsLetterOrDigit(c))
                    hasSpecialCharacters = true;              

            }

            return hasSpecialCharacters && hasUpperCase && hasLowerCase && hasDigit;
        }
    }
}
