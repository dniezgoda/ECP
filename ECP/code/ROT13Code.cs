using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECP.code
{
    public class ROT13Code
    {
        public static string Cipher(string message)
        {
            char[] text = message.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                int number = (int)text[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                text[i] = (char)number;
            }
            return new string(text);
        }
    }
}
