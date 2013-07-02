using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLK_DongLuc.Models
{
    public partial class TuyChonTimKiem
    {
        public int ID_tuy_chon { get; set; }
        public string Ten_tuy_chon { get ; set; }

        public static List<TuyChonTimKiem> DanhSachTuyChonMacDinh()
        {
            List<TuyChonTimKiem> options = new List<TuyChonTimKiem>();

            options.Add(new TuyChonTimKiem { ID_tuy_chon = 1, Ten_tuy_chon = "Tìm kiếm theo ngày" });
            options.Add(new TuyChonTimKiem { ID_tuy_chon = 2, Ten_tuy_chon = "Tìm kiếm theo tuần" });
            options.Add(new TuyChonTimKiem { ID_tuy_chon = 3, Ten_tuy_chon = "Tìm kiếm theo tháng" });
            options.Add(new TuyChonTimKiem { ID_tuy_chon = 4, Ten_tuy_chon = "Tìm kiếm theo năm" });

            return options;
        }
    }
}
