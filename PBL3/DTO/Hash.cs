using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PBL3.DTO
{
    public class Hash
    {
        public static string ConvertToHashCode(string input)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] password_bytes = Encoding.ASCII.GetBytes(input);
            byte[] encrypt_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrypt_bytes);
        }
    }
}
