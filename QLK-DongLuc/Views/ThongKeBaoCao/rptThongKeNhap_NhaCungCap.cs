using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLK_DongLuc.Models;
using QLK_DongLuc.Controllers;

namespace QLK_DongLuc.Views.ThongKeBaoCao
{
    public partial class rptThongKeNhap_NhaCungCap : DevExpress.XtraReports.UI.XtraReport
    {
        Entities db;

        private static DateTime dtTuNgay;
        private static DateTime dtDenNgay;
        private static string Ten_nha_cung_cap;

        public rptThongKeNhap_NhaCungCap(object NCC, object beginDate, object endDate)
        {
            InitializeComponent();
            Ten_nha_cung_cap = (string)NCC;
            dtTuNgay = (DateTime)beginDate;
            dtDenNgay = (DateTime)endDate;
        }

        private void rptThongKeNhap_NhaCungCap_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            txtTuNgay.Text = dtTuNgay.ToString("dd/MM/yyyy");
            txtDenNgay.Text = dtDenNgay.ToString("dd/MM/yyyy");

            ThongKeNhapCtrl.LoadBindingSource(Ten_nha_cung_cap, dtTuNgay, dtDenNgay, bindingSource1, db);
        }

    }
}
