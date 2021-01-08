using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ECP.code
{
    public class SHA1Code
    {
        public static string Hash(string message)
        {
            SHA1CryptoServiceProvider provider = new SHA1CryptoServiceProvider();
            provider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(message));
            byte[] text = provider.Hash;
            StringBuilder builder = new StringBuilder();
            foreach(byte b in text)
            {
                builder.Append(b.ToString("x2"));
            }
            string result = builder.ToString();

            return result;
        }
    }
}
