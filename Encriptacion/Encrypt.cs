using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Encriptacion
{
    public class Encrypt
    {
        public static string GetSHA256(string srt)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();

            stream = sha256.ComputeHash(encoding.GetBytes(srt));

            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }

            return sb.ToString();
        }


    }
}
