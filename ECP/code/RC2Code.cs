﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ECP.code
{
    public class RC2Code
    {
        public static string Encrypt(string message, string password)
        {
            byte[] messageBytes = ASCIIEncoding.ASCII.GetBytes(message);
            byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

            RC2CryptoServiceProvider provider = new RC2CryptoServiceProvider();
            ICryptoTransform transform = provider.CreateEncryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, mode);
            cryptoStream.Write(messageBytes, 0, messageBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] encryptedMessageBytes = new byte[memoryStream.Length];
            memoryStream.Position = 0;
            memoryStream.Read(encryptedMessageBytes, 0, encryptedMessageBytes.Length);

            string encryptedMessage = Convert.ToBase64String(encryptedMessageBytes);

            return encryptedMessage;
        }

        public static string Decrypt(string encryptedMessage, string password)
        {
            byte[] encryptedMessageBytes = Convert.FromBase64String(encryptedMessage);
            byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

            RC2CryptoServiceProvider provider = new RC2CryptoServiceProvider();
            ICryptoTransform transform = provider.CreateDecryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, mode);
            cryptoStream.Write(encryptedMessageBytes, 0, encryptedMessageBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] decryptedMessageBytes = new byte[memoryStream.Position];
            memoryStream.Position = 0;
            memoryStream.Read(decryptedMessageBytes, 0, decryptedMessageBytes.Length);

            string message = ASCIIEncoding.ASCII.GetString(decryptedMessageBytes);

            return message;
        }
    }
}
