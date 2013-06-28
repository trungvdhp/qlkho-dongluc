using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Controllers;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Views.HeThong
{
    public partial class frmQuanLyNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        QuanLyKhoDongLucEntities db = new QuanLyKhoDongLucEntities();

        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
            NguoiDungCtrl.LoadBindingSource(viewNguoiDungBindingSource, db);
        }
    }
}