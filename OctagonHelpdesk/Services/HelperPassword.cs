using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OctagonHelpdesk.Services
{
    public static class HelperPassword
    {
        public static string HashPassword(string password)
        {
            Random random = new Random();
            string randomString = random.Next().ToString();  

            string combinedPassword = password + randomString; 

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(combinedPassword));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            if (string.IsNullOrEmpty(storedHash))
                return false;

            string randomString = storedHash.Substring(storedHash.Length - 8); 
            string combinedPassword = enteredPassword + randomString;

            string enteredPasswordHash = HashPassword(combinedPassword);
            return enteredPasswordHash.Equals(storedHash);
        }

        public static bool Checkifhashed(string password)
        {
            return password.Length == 64 && Regex.IsMatch(password, @"^[0-9a-f]{64}$", RegexOptions.IgnoreCase);
        }
    }
}
