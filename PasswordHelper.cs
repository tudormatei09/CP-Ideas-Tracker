using System.Security.Cryptography;
using System.Text;

namespace CP_Ideas_Tracker
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha256.ComputeHash(passwordBytes);

            return Convert.ToBase64String(hashBytes);
        }

        public static bool VerifyPassword(string password, string savedHash)
        {
            string passwordHash = HashPassword(password);

            return passwordHash == savedHash;
        }
    }
}