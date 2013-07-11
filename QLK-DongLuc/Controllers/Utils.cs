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
using System.ComponentModel;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraBars;

namespace QLK_DongLuc.Controllers
{
	class Utils
	{
        public static void ReconfigGridView(GridView gridView)
        {
            if (gridView.OptionsBehavior.AllowAddRows == DevExpress.Utils.DefaultBoolean.False)
            {
                gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            else
            {
                gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }

            gridView.OptionsView.ShowGroupPanel = gridView.OptionsCustomization.AllowGroup;
            gridView.OptionsView.ShowAutoFilterRow = gridView.OptionsCustomization.AllowFilter;

            if (gridView.OptionsCustomization.AllowFilter == true)
                gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            else
                gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
        }

        public static string GetLastString(string path)
        {
            return path.Split('.').Last();
        }

        public static void SetValue(object component, string propertyPath, object value)
        {
            object propValue = component;
            var props = propertyPath.Split('.');

            for (int i = 0; i < props.Length - 1; i++)
            {
                propValue = TypeDescriptor.GetProperties(propValue)[props[i]].GetValue(propValue);
            }

            TypeDescriptor.GetProperties(propValue)[props[props.Length - 1]].SetValue(propValue, value);
        }

        public static object FindControl(object parent, string controlName)
        {
            List<Type> types = new List<Type>(new Type[] { typeof(BarButtonItem), typeof(LookUpEdit), typeof(DateEdit), typeof(SpinEdit), typeof(MemoEdit), typeof(TextEdit), typeof(TimeEdit), typeof(GridColumn) });

            List<Type> ExcludeList = new List<Type>(new Type[] { typeof(Label), typeof(LabelControl) });
            Queue<object> queue = new Queue<object>();
            queue.Enqueue(parent);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                if (node.GetType() == typeof(RibbonControl))
                {
                    var children = (node as RibbonControl).Items;

                    foreach (var child in children)
                    {
                        if (child.GetType() == typeof(BarButtonItem))
                        {
                            BarButtonItem btn = child as BarButtonItem;

                            if (btn.Name == controlName)
                                return btn;

                            queue.Enqueue(child);
                        }
                    }
                }
                else if (types.Contains(node.GetType()))
                {
                    
                }
                else if (node.GetType() == typeof(GridControl))
                {
                    var children = (node as GridControl).Views;

                    foreach (GridView child in children)
                    {
                        if (child.Name == controlName)
                            return child;

                        queue.Enqueue(child);
                    }
                }
                else if (node.GetType() == typeof(GridView))
                {
                    var children = (node as GridView).Columns;

                    foreach (GridColumn child in children)
                    {
                        if (child.Name == controlName)
                            return child;

                        queue.Enqueue(child);
                    }
                }
                else
                {
                    var children = (node as Control).Controls;

                    foreach (Control child in children)
                    {
                        if (!ExcludeList.Contains(child.GetType()))
                        {
                            if (child.Name == controlName)
                                return child;

                            queue.Enqueue(child);
                        }
                    }
                }
            }

            return null;
        }

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
                    (control as DateEdit).EditValue = KetNoiCSDLCtrl.GetDatabaseDate();
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

        public static string MilliSecondsToString(double milliseconds, string format)
        {
            TimeSpan t = TimeSpan.FromMilliseconds(milliseconds);

            return t.ToString(format);
        }
	}
}
