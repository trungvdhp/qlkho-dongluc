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

            bs.DataSource = db.IMP_PhieuNhapCT.Where(t => t.ID_phieu_nhap == ID_phieu_nhap).ToList();
        }
    }
}
