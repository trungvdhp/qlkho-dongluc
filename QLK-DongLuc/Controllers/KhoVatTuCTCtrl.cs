﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Controllers
{
    public class KhoVatTuCTCtrl
    {
        public static void LoadBindingSource(int ID_kho, BindingSource bs, Entities db = null)
        {
            if (db == null) db = new Entities();

            bs.DataSource = db.STO_KhoVatTuCT.Where(t => t.ID_kho == ID_kho).OrderByDescending(x => x.ID_phieu_nhap).ToList();
        }

        public static int Update(int ID_kho, int ID_vat_tu, object Don_gia_xuat, Entities db = null)
        {
            if (db == null) db = new Entities();

            var entity = db.STO_KhoVatTuCT.FirstOrDefault(t => t.ID_kho == ID_kho && t.ID_vat_tu == ID_vat_tu);

            if (entity == null) return 0;

            if (Don_gia_xuat != null)
                entity.Don_gia_xuat = (decimal)Don_gia_xuat;
            else
                entity.Don_gia_xuat = null;

            return db.SaveChanges();
        }
    }
}