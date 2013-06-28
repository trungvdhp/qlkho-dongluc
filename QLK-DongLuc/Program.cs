using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using QLK_DongLuc.Models;

namespace QLK_DongLuc
{
    static class Program
    {
        public static SYS_NguoiDung CurrentUser { get; set; }
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
            QuanLyKhoDongLucEntities db = new QuanLyKhoDongLucEntities();
            CurrentUser = db.SYS_NguoiDung.First();
            Application.Run(new frmMain());
        }
    }
}