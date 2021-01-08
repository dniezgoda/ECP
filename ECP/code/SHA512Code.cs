using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ECP.code
{
    public class SHA512Code
    {
        public static string Hash(string message)
        {
            SHA512CryptoServiceProvider provider = new SHA512CryptoServiceProvider();
            provider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(message));
            byte[] text = provider.Hash;
            StringBuilder builder = new StringBuilder();
            foreach (byte b in text)
            {
                builder.Append(b.ToString("x2"));
            }
            string result = builder.ToString();

            return result;
        }
    }
}
