using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Controllers
{
    public class PhieuNhapCTCtrl
    {
        public static void LoadBindingSource(int ID_phieu_nhap, BindingSource bs, Entities db = null)
        {
            if(db == null) db = new Entities();

            var t1 = db.IMP_PhieuNhap.FirstOrDefault(t => t.ID_phieu_nhap == ID_phieu_nhap);
            
            if (t1 != null)
            {
                var khovt = db.STO_KhoVatTuCT.Where(t => t.ID_kho == t1.ID_kho);
                //var khovattu = khovt.ToList();
                var pnct = from ct in t1.IMP_PhieuNhapCT
                           join vt in khovt on ct.ID_vat_tu equals vt.ID_vat_tu
                           into chitiet from pct in chitiet.DefaultIfEmpty()
                           select new IMP_PhieuNhapCT
                           {
                               ID_phieu_nhap = ct.ID_phieu_nhap,
                               ID_vat_tu = ct.ID_vat_tu,
                               So_luong = ct.So_luong,
                               STO_VatTu = ct.STO_VatTu,
                               IMP_PhieuNhap = ct.IMP_PhieuNhap,
                               Don_gia = ct.Don_gia == null && pct != null? pct.Don_gia_nhap : ct.Don_gia
                           };
                //var ct2 = pnct.ToList();
                bs.DataSource = pnct.ToList();
            }
        }
    }
}
