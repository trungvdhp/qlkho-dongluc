using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using QLK_DongLuc.Models;
using DevExpress.XtraEditors;
using QLK_DongLuc.Views.HeThong;
using QLK_DongLuc.Controllers;
using QLK_DongLuc.Views.DanhMuc;

namespace QLK_DongLuc
{
    static class Program
    {
        public static SYS_NguoiDung CurrentUser { get; set; }
        public static string ConnectionString { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            CurrentUser = new SYS_NguoiDung();
            Application.Run(new frmMain());
        }
    }
}