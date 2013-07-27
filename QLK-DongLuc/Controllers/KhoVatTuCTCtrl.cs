using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Controllers
{
    public static class KhoVatTuCTCtrl
    {
        public static void LoadBindingSource(BindingSource bs, int ID_kho, Entities db = null)
        {
            if (db == null) db = new Entities();

            bs.DataSource = db.STO_KhoVatTuCT.Where(t => t.ID_kho == ID_kho).OrderByDescending(x => x.ID_phieu_nhap).ToList();
        }

        public static int Update(STO_KhoVatTuCT kho, Entities db = null)
        {
            if (db == null) db = new Entities();

            var entity = db.STO_KhoVatTuCT.FirstOrDefault(t => t.ID_kho == kho.ID_kho && t.ID_vat_tu == kho.ID_vat_tu);

            if (entity == null) return 0;

            if (kho.Don_gia_nhap != null)
                entity.Don_gia_nhap = kho.Don_gia_nhap;
            else
                entity.Don_gia_nhap = null;

            if (kho.Don_gia_xuat != null)
                entity.Don_gia_xuat = kho.Don_gia_xuat;
            else
                entity.Don_gia_xuat = null;

            return db.SaveChanges();
        }
    }
}
