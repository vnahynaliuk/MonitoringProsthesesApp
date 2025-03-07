﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace MonitoringProsthesesApp.AppCode
{
  class EncryptData
  {
    static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("FixedWWW");

    public string Encrypt(string originalString)
    {
      if (String.IsNullOrEmpty(originalString))
      {
        throw new ArgumentNullException
               ("The string which needs to be encrypted can not be null.");
      }
      DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
      MemoryStream memoryStream = new MemoryStream();
      CryptoStream cryptoStream = new CryptoStream(memoryStream,
          cryptoProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
      StreamWriter writer = new StreamWriter(cryptoStream);
      writer.Write(originalString);
      writer.Flush();
      cryptoStream.FlushFinalBlock();
      writer.Flush();
      return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
    }

    public string Decrypt(string cryptedString)
    {
      if (String.IsNullOrEmpty(cryptedString))
      {
        throw new ArgumentNullException
           ("The string which needs to be decrypted can not be null.");
      }
      DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
      MemoryStream memoryStream = new MemoryStream
              (Convert.FromBase64String(cryptedString));
      CryptoStream cryptoStream = new CryptoStream(memoryStream,
          cryptoProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
      StreamReader reader = new StreamReader(cryptoStream);
      return reader.ReadToEnd();
    }
  }
}
