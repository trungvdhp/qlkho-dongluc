using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using QLK_DongLuc.Models;
using DevExpress.XtraEditors;

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

            try
            {
                Entities db = new Entities();
                db.Database.Connection.Open();
            }
            catch
            {
                XtraMessageBox.Show("Không thể mở kết nối đến máy chủ", "Kết nối máy chủ thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QLK_DongLuc.Views.HeThong.frmCauHinh frm = new QLK_DongLuc.Views.HeThong.frmCauHinh();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //Application.Run(new frmMain());
                }
            }

            Application.Run(new frmMain());
        }
    }
}