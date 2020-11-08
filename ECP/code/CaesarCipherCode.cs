using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECP.code
{
    public class CaesarCipherCode
    {
		private static char Cipher(char message, int key)
		{
			if (!char.IsLetter(message))
				return message;

			char offset = char.IsUpper(message) ? 'A' : 'a';
			return (char)((((message + key) - offset) % 26) + offset);
		}

		public static string Encrypt(string input, int key)
		{
			string output = string.Empty;

			foreach (char message in input)
				output += Cipher(message, key);

			return output;
		}

		public static string Decrypt(string input, int key)
		{
			return Encrypt(input, 26 - key);
		}
	}
}
