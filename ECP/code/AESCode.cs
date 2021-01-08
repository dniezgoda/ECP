using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ECP.code
{
    public class AESCode
    {
        public static string Encrypt(string message, string key)
        {
            byte[] text = UTF8Encoding.UTF8.GetBytes(message);
            MD5CryptoServiceProvider providerMD5 = new MD5CryptoServiceProvider();
            byte[] securityKey = providerMD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            providerMD5.Clear();
            var provider3DES = new AesCryptoServiceProvider();
            provider3DES.Key = securityKey;
            provider3DES.Mode = CipherMode.ECB;
            provider3DES.Padding = PaddingMode.PKCS7;
            var transform = provider3DES.CreateEncryptor();
            byte[] resultArray = transform.TransformFinalBlock(text, 0, text.Length);
            provider3DES.Clear();
            string result = Convert.ToBase64String(resultArray, 0, resultArray.Length);

            return result;
        }

        public static string Decrypt(string message, string key)
        {
            byte[] text = Convert.FromBase64String(message);
            MD5CryptoServiceProvider providerMD5 = new MD5CryptoServiceProvider();
            byte[] securityKey = providerMD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            providerMD5.Clear();
            var provider3DES = new AesCryptoServiceProvider();
            provider3DES.Key = securityKey;
            provider3DES.Mode = CipherMode.ECB;
            provider3DES.Padding = PaddingMode.PKCS7;
            var transform = provider3DES.CreateDecryptor();
            byte[] resultArray = transform.TransformFinalBlock(text, 0, text.Length);
            provider3DES.Clear();
            string result = UTF8Encoding.UTF8.GetString(resultArray);

            return result;
        }
    }
}
