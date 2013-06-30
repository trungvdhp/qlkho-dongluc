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
    class PhieuXuatCTCtrl
    {
        // load data cho datasource các đối tượng
        public static void LoadBindingSource(int ID_phieu_xuat, BindingSource bs, Entities db = null)
        {
            if (db == null) db = new Entities();
            bs.DataSource = db.EXP_PhieuXuatCT.Where(t => t.ID_phieu_xuat == ID_phieu_xuat).ToList();
        }
    }
}
