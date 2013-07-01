using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLK_DongLuc.Controllers;

namespace QLK_DongLuc.Models
{
    public class Entities : QuanLyKhoDongLucEntities
    {
        public Entities()
            : base()
        {
            this.Database.Connection.ConnectionString = KetNoiCSDLCtrl.GetConnectionString();
        }
    }
}
