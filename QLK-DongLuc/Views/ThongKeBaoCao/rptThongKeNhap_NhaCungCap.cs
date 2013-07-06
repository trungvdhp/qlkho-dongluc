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
        private static DateTime dtNgayLap;
        private static string Ten_nha_cung_cap;

        public rptThongKeNhap_NhaCungCap(object NCC, object nowDate, object beginDate, object endDate)
        {
            InitializeComponent();
            Ten_nha_cung_cap = (string)NCC;
            dtNgayLap = (DateTime)nowDate;
            dtTuNgay = (DateTime)beginDate;
            dtDenNgay = (DateTime)endDate;
        }

        private void rptThongKeNhap_NhaCungCap_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            txtThongKe.Text = String.Format("từ {0} - đến {1}", dtTuNgay.ToString("dd/MM/yyyy"), dtDenNgay.ToString("dd/MM/yyyy"));

            txtNgayLap.Text = String.Format("Hải Phòng, ngày {0:00} tháng {1:00} năm {2:0000}", dtNgayLap.Day, dtNgayLap.Month, dtNgayLap.Year);

            ThongKeNhapCtrl.LoadBindingSource(Ten_nha_cung_cap, dtTuNgay, dtDenNgay, bindingSource1, db);
        }

    }
}
