using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Controllers
{
    public class ThongKeNhapCtrl
    {
        public static void LoadBindingSource(object Ten_nha_cung_cap ,object beginDate, object endDate,BindingSource bs, Entities db = null)
        {
            if (db == null) db = new Entities();
                
            DateTime begin = (DateTime)beginDate;
            DateTime end = (DateTime)endDate;
            end = end.AddDays(1);

            bs.DataSource = db.ViewThongKeNhap_NhaCungCap.Where(t => t.Ten_nha_cung_cap == Ten_nha_cung_cap && t.Ngay_nhap >= begin && t.Ngay_nhap <= end).OrderBy(t => t.So_chung_tu_goc).ToList();
        }
    }
}
