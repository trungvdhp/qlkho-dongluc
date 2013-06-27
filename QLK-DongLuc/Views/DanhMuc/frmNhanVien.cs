using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Views.DanhMuc
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        QuanLyKhoDongLucEntities db = new QuanLyKhoDongLucEntities();
        bool haveInsert = false;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void Load_gridControl(bool value, string Ten = "")
        {
            if (!value)
            {
                cATNhanVienBindingSource.DataSource = db.CAT_NhanVien.ToList();;   
            }
            else
            {
                
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            Load_gridControl(false); 
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void gridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {

        }
    }
}