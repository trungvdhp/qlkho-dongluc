using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Controllers
{
    public class ThongSoHeThongCtrl
    {
        public static SYS_ThongSoHeThong LayThongSoHeThong(string Ma_thong_so_cha, string Ma_thong_so_con, int Cap_do = 0)
        {
            Entities db = new Entities();
            var parent = db.SYS_ThongSoHeThong.FirstOrDefault(t => t.Ma_thong_so == Ma_thong_so_cha);

            if (parent == null) return null;

            Queue< KeyValuePair<int, SYS_ThongSoHeThong> > queue = new Queue< KeyValuePair<int, SYS_ThongSoHeThong> >();
            queue.Enqueue(new KeyValuePair<int, SYS_ThongSoHeThong>(1, parent));

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                if (node.Value.Ma_thong_so == Ma_thong_so_con)
                {
                    if(Cap_do > 0)
                    {
                        if(node.Key == Cap_do)
                            return node.Value;
                    }
                    else
                        return node.Value;
                }

                var children = db.SYS_ThongSoHeThong.Where(t => t.ID_cha == node.Value.ID_thong_so);

                foreach (var child in children)
                {
                    queue.Enqueue(new KeyValuePair<int, SYS_ThongSoHeThong>(node.Key + 1, child));
                }
            }

            return null;
        }
    }
}
