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
    public class VaiTroCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Entities db = null)
        {
            if (db == null) db = new Entities();
            bindingSource.DataSource = db.SYS_VaiTro.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();
            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.ViewCboKhachHang.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vai_tro", "Vai trò"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mo_ta", "Mô tả"));
            lookUpEdit.Properties.DisplayMember = "Ten_vai_tro";
            lookUpEdit.Properties.ValueMember = "ID_vai_tro";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn vai trò người dùng";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }

        public static int Insert(object Ten_vai_tro, object Mo_ta, Entities db = null)
        {
            if (Ten_vai_tro == null) return 0;

            if (db == null) db = new Entities();

            var entity = new SYS_VaiTro();

            entity.Ten_vai_tro = Ten_vai_tro.ToString().Trim();
            entity.Mo_ta = Mo_ta.ToString().Trim();

            db.SYS_VaiTro.Add(entity);

            return db.SaveChanges();
        }

        public static int Update(object ID_vai_tro, object Ten_vai_tro, object Mo_ta, Entities db = null)
        {
            if (ID_vai_tro == null || Ten_vai_tro == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_vai_tro;
            var entity = db.SYS_VaiTro.FirstOrDefault(p => p.ID_vai_tro == id);

            if (entity == null) return 0;

            entity.Ten_vai_tro = Ten_vai_tro.ToString().Trim();
            entity.Mo_ta = Mo_ta.ToString().Trim();

            return db.SaveChanges();
        }

        public static int Delete(object ID_vai_tro, Entities db = null)
        {
            if (ID_vai_tro == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_vai_tro;
            var entity = db.SYS_VaiTro.FirstOrDefault(p => p.ID_vai_tro == id);

            if (entity == null) return 0;

            db.SYS_VaiTro.Remove(entity);

            return db.SaveChanges();
        }
    }
}
