using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECP.code
{
    public class XORCipherCode
    {
        public static int number;

        public static string Encrypt(string textToEncrypt, string key)
        {
            number = Convert.ToInt32(key);

            StringBuilder inSb = new StringBuilder(textToEncrypt);
            StringBuilder outSb = new StringBuilder(textToEncrypt.Length);
            char c;
            for (int i = 0; i < textToEncrypt.Length; i++)
            {
                c = inSb[i];
                c = (char)(c ^ number);
                outSb.Append(c);
            }
            return outSb.ToString();
        }
    }
}
