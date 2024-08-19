using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace e_booking.Helpers
{
    internal class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha512.ComputeHash(bytes);

                StringBuilder result = new();
                foreach (byte b in hash)
                {
                    result.Append(b.ToString("x2"));
                }
                return result.ToString();
            }
        }

        public static bool ValidatePassword(string inputPassword, string storedHashedPassword)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(inputPassword);
                byte[] hash = sha512.ComputeHash(bytes);

                StringBuilder hashedInputPassword = new();
                foreach (byte b in hash)
                {
                    hashedInputPassword.Append(b.ToString("x2"));
                }

                return hashedInputPassword.ToString() == storedHashedPassword;
            }
        }
    }
}
