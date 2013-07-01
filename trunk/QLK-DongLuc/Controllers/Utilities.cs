using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QLK_DongLuc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using System.Security.Cryptography;

namespace QLK_DongLuc.Controllers
{
	class Utilities
	{
        public static void ResetControls(Control Parent)
        {
            foreach (var control in Parent.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                    (control as TextBox).Refresh();
                }
                else if (control is TextEdit)
                {
                    (control as TextEdit).Text = string.Empty;
                    (control as TextEdit).Refresh();
                }
                else if (control is MemoEdit)
                {
                    (control as MemoEdit).Text = string.Empty;
                    (control as MemoEdit).Refresh();
                }
                else if (control is LookUpEdit)
                {
                    (control as LookUpEdit).Reset();
                }
                else if (control is DateEdit)
                {
                    (control as DateEdit).EditValue = DateTime.Now;
                }
                else if (control is GridControl)
                {
                    (control as GridControl).RefreshDataSource();
                }
                else if (control is TableLayoutPanel || control is Panel || control is GroupControl)
                {
                    ResetControls((Control)control);
                }
            }
        }

        public static string CreateSHAHash(string Phrase)
        {
            SHA512Managed HashTool = new SHA512Managed();
            Byte[] PhraseAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Phrase));
            Byte[] EncryptedBytes = HashTool.ComputeHash(PhraseAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }

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
            byte[] encrypt_data = utf8.GetBytes(message);

            try
            {
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
            byte[] decrypt_data = Convert.FromBase64String(message);

            try
            {
                ICryptoTransform decryptor = desalg.CreateDecryptor();
                results = decryptor.TransformFinalBlock(decrypt_data, 0, decrypt_data.Length);
            }
            finally
            {
                desalg.Clear();
                md5.Clear();

            }

            return utf8.GetString(results);
        }
	}
}
