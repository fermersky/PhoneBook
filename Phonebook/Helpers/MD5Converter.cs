using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Phonebook.Server.Helpers
{
    public static class MD5Converter
    {
        private const string hash = "f01hA87H";
        public static string GetHashFromString(string input)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(input);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));

                using (var triDes = new TripleDESCryptoServiceProvider()
                    { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    var transform = triDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);

                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public static string GetStringFromHash(string input)
        {
            byte[] data = Convert.FromBase64String(input);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));

                using (var triDes = new TripleDESCryptoServiceProvider()
                    { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    var transform = triDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);

                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}
