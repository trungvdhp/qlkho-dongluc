using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using QLK_DongLuc.Controllers;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Views.ThongKeBaoCao
{
    public partial class frmThongKeNhap_NhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        Entities db;

        public frmThongKeNhap_NhaCungCap()
        {
            InitializeComponent();
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptThongKeNhap_NhaCungCap rpt = new rptThongKeNhap_NhaCungCap(ledNhaCungCap.Text, QLK_DongLuc.Helper.DatabaseHelper.GetDatabaseDate(), dteTuNgay.EditValue, dteDenNgay.EditValue);
            rpt.CreateDocument();
            rpt.Print();
        }

        private void frmThongKeNhap_NhaCungCap_Load(object sender, EventArgs e)
        {
            db = new Entities();
            NhaCungCapCtrl.LoadLookUpEdit(ledNhaCungCap, db);
            dteTuNgay.EditValue = dteDenNgay.EditValue = QLK_DongLuc.Helper.DatabaseHelper.GetDatabaseDate();
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            rptThongKeNhap_NhaCungCap rpt = new rptThongKeNhap_NhaCungCap(ledNhaCungCap.Text, QLK_DongLuc.Helper.DatabaseHelper.GetDatabaseDate(), dteTuNgay.EditValue, dteDenNgay.EditValue);
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain.CloseCurrentForm(this.Parent);
        }
    }
}