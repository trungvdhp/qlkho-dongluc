using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace QLK_DongLuc.Helper
{
    public static class SecurityHelper
    {
        #region Cryptography
        /// <summary>
        /// Creat SHA Hash
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns></returns>
        public static string CreateSHAHash(string data)
        {
            SHA512Managed HashTool = new SHA512Managed();
            Byte[] PhraseAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(data));
            Byte[] EncryptedBytes = HashTool.ComputeHash(PhraseAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }

        /// <summary>
        /// Encrypt MD5
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="key">Key</param>
        /// <returns></returns>
        public static string EnCryptMD5(string message, string key)
        {
            byte[] results;
            UTF8Encoding utf8 = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] deskey = md5.ComputeHash(utf8.GetBytes(key));
            TripleDESCryptoServiceProvider desalg = new TripleDESCryptoServiceProvider();
            desalg.Key = deskey;
            desalg.Mode = CipherMode.ECB;
            desalg.Padding = PaddingMode.PKCS7;

            try
            {
                byte[] encrypt_data = utf8.GetBytes(message);
                ICryptoTransform encryptor = desalg.CreateEncryptor();
                results = encryptor.TransformFinalBlock(encrypt_data, 0, encrypt_data.Length);
            }
            finally
            {
                desalg.Clear();
                md5.Clear();
            }

            return Convert.ToBase64String(results);
        }

        /// <summary>
        /// DeCrypt MD5
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="key">Key</param>
        /// <returns></returns>
        public static string DeCryptMD5(string message, string key)
        {
            byte[] results;
            UTF8Encoding utf8 = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] deskey = md5.ComputeHash(utf8.GetBytes(key));
            TripleDESCryptoServiceProvider desalg = new TripleDESCryptoServiceProvider();
            desalg.Key = deskey;
            desalg.Mode = CipherMode.ECB;
            desalg.Padding = PaddingMode.PKCS7;

            try
            {
                byte[] decrypt_data = Convert.FromBase64String(message);
                ICryptoTransform decryptor = desalg.CreateDecryptor();
                results = decryptor.TransformFinalBlock(decrypt_data, 0, decrypt_data.Length);

                return utf8.GetString(results);
            }
            catch (Exception)
            {
            }
            finally
            {
                desalg.Clear();
                md5.Clear();
            }

            return "";
        }
        #endregion
    }
}
