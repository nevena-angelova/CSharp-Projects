using System;

namespace PANDA.Services
{
    public class UsersService
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            var hmac = new System.Security.Cryptography.HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

        public static byte[] CreateCheckPasswordHash(string password, byte[] passwordSalt)
        {
            var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt);
            return hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }
}
