using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PANDA.Services
{
    public class CryptoHelper
    {
        public static string HMACSHA512(string str, byte[] salt)
        {
            var crypt = new HMACSHA512(salt);
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(str));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
