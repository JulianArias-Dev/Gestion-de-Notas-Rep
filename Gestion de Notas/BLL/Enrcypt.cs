using System;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public static class Enrcypt
    {
        public static string Encriptar(string cadena)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder stringBuilder = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i<stream.Length; i++) { stringBuilder.AppendFormat("0:x2", stream[i]); }
            return stringBuilder.ToString();
        }
    }
}
