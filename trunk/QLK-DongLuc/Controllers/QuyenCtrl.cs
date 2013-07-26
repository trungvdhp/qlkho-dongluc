using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Control;
using QLK_DongLuc.Helper;
using QLK_DongLuc.Models;
using QLK_DongLuc.Views.HeThong;

namespace QLK_DongLuc.Controllers
{
    public class QuyenCtrl
    {
        public static void LoadAllControls(BindingSource bindingSource)
        {
            var forms = GetFormList();
            bindingSource.DataSource = GetControls(forms).OrderBy(t => t.Loai_dieu_khien).ToList();
        }

        /// <summary>
        /// Load binding source quyền theo loại
        /// </summary>
        /// <param name="ID_vai_tro"></param>
        /// <param name="type">type = 0 load toàn bộ, type = 1 load các quyền có ít nhất 1 thuộc tính được đặt của vai trò, type = 2 load các quyền mà chưa được được thuộc tính của vai trò</param>
        /// <param name="bs">Binding Source</param>
        /// <param name="db">Database Context</param>
        public static void LoadBindingSource(BindingSource bs, int ID_vai_tro = 0, int type = 0, Entities db = null)
        {
            if (db == null) db = new Entities();

            if(type == 0)
            {
                bs.DataSource = db.SYS_Quyen.OrderBy(t => t.Loai_dieu_khien).ToList();
            }
            else if (type == 1)
            {
                bs.DataSource = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_vai_tro).Select(s => s.SYS_Quyen).Distinct().ToList();
            }
            else
            {
                var ids = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_vai_tro).Select(s => s.ID_quyen).Distinct().ToList();
                bs.DataSource = db.SYS_Quyen.Where(t => !ids.Contains(t.ID_quyen)).OrderBy(t => t.Loai_dieu_khien).ToList();
            }
        }

        #region Get controls
        /// <summary>
        /// Get sub classes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static List<Type> GetSubClasses<T>()
        {
            return AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(
                    a => a.GetTypes().Where(type => type.IsSubclassOf(typeof(T)))
                ).ToList();
        }

        /// <summary>
        /// Get form list
        /// </summary>
        /// <returns></returns>
        public static  List<Control> GetFormList()
        {
            List<Control> list = new List<Control>();
            var tmp = GetSubClasses<XtraForm>().Where(x => x.Name.StartsWith("frm")).ToList();

            foreach (var item in tmp)
            {
                list.Add((Control)(Activator.CreateInstance(item)));
            }

            return list;
        }

        public static bool HaveRelationShip(string formName, int ID_quyen, Entities db = null)
        {
            if (db == null) db = new Entities();

            var quyen = db.SYS_Quyen.FirstOrDefault(t => t.ID_quyen == ID_quyen);

            while (true)
            {
                if (quyen == null) return false;

                if (quyen.Ma_quyen == formName) return true;

                if (quyen.ID_quyen == quyen.ID_cha) return false;

                quyen = db.SYS_Quyen.FirstOrDefault(t => t.ID_quyen == quyen.ID_cha);
            }

            return false;
        }

        public static List<int> GetChildrenIDs(string formName, Entities db = null)
        {
            if (db == null) db = new Entities();

            var form = db.SYS_Quyen.FirstOrDefault(t => t.Ma_quyen == formName);
            List<int> list = new List<int>();

            Queue<SYS_Quyen> queue = new Queue<SYS_Quyen>();
            queue.Enqueue(form);

            while (queue.Count != 0)
            {
                SYS_Quyen node = queue.Dequeue();

                var children = db.SYS_Quyen.Where(t => t.ID_cha == node.ID_quyen && t.ID_quyen != node.ID_quyen);

                foreach (var child in children)
                {
                    list.Add(child.ID_quyen);
                    queue.Enqueue(child);
                }
            }

            return list;
        }

        /// <summary>
        /// Get list children controls
        /// </summary>
        /// <returns></returns>
        public static List<SYS_Quyen> GetControls(List<Control> forms)
        {
            List<SYS_Quyen> controls = new List<SYS_Quyen>();
            List<Type> types = new List<Type>(new Type[] { typeof(BarButtonItem), typeof(LookUpEdit), typeof(DateEdit), typeof(SpinEdit), typeof(MemoEdit), typeof(TextEdit), typeof(TimeEdit), typeof(GridColumn), typeof(LabelControl), typeof(PrintControl)});

            List<Type> ExcludeList = new List<Type>(new Type[] { typeof(Label), typeof(LabelControl) });

            Queue<KeyValuePair<SYS_Quyen, object>> queue = new Queue<KeyValuePair<SYS_Quyen, object>>();
            int id = 0;

            foreach (var form in forms)
            {
                if (form.Name != "frmQuyen" && form.Name != "frmDangNhap" && form.Name != "frmCauHinh")
                {
                    id++;
                    queue.Enqueue(
                        new KeyValuePair<SYS_Quyen, object>(
                            new SYS_Quyen
                            {
                                ID_quyen = id,
                                ID_cha = id,
                                Ma_quyen = form.Name,
                                Ten_quyen = form.Text,
                                Loai_dieu_khien = StringHelper.GetLastString(form.GetType().BaseType.ToString()),
                                ID_goc = id
                            },
                            form)
                        );
                }
            }

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                controls.Add(node.Key);

                if (node.Value.GetType() == typeof(RibbonControl))
                {
                    var children = (node.Value as RibbonControl).Items;

                    foreach (object child in children)
                    {
                        if (child.GetType() == typeof(BarButtonItem))
                        {
                            id++;
                            BarButtonItem btn = child as BarButtonItem;

                            queue.Enqueue(
                                new KeyValuePair<SYS_Quyen, object>(
                                    new SYS_Quyen
                                    {
                                        ID_quyen = id,
                                        ID_cha = node.Key.ID_quyen,
                                        Ma_quyen = btn.Name,
                                        Ten_quyen = btn.Caption,
                                        Loai_dieu_khien = StringHelper.GetLastString(child.GetType().ToString()),
                                        ID_goc = node.Key.ID_goc
                                    },
                                    child)
                                );
                        }
                    }
                }
                else if (types.Contains(node.Value.GetType()))
                {
                }
                else if (node.Value.GetType() == typeof(GridControl))
                {
                    var children = (node.Value as GridControl).Views;

                    foreach (GridView child in children)
                    {
                        id++;
                        queue.Enqueue(
                            new KeyValuePair<SYS_Quyen, object>(
                                new SYS_Quyen
                                {
                                    ID_quyen = id,
                                    ID_cha = node.Key.ID_quyen,
                                    Ma_quyen = child.Name,
                                    Ten_quyen = child.ViewCaption,
                                    Loai_dieu_khien = StringHelper.GetLastString(child.GetType().ToString()),
                                    ID_goc = node.Key.ID_goc
                                },
                                child)
                            );
                    }
                  
                }
                else if (node.Value.GetType() == typeof(GridView))
                {
                    var children = (node.Value as GridView).Columns;

                    foreach (GridColumn child in children)
                    {
                        id++;
                        queue.Enqueue(
                            new KeyValuePair<SYS_Quyen, object>(
                                new SYS_Quyen
                                {
                                    ID_quyen = id,
                                    ID_cha = node.Key.ID_quyen,
                                    Ma_quyen = child.Name,
                                    Ten_quyen = child.Caption,
                                    Loai_dieu_khien = StringHelper.GetLastString(child.GetType().ToString()),
                                    ID_goc = node.Key.ID_goc
                                },
                                child)
                            );
                    }
                }
                else
                {
                    var children = (node.Value as Control).Controls;

                    foreach (object child in children)
                    {
                        if (!ExcludeList.Contains(child.GetType()))
                        {
                            id++;
                            Control ctrl = child as Control;
                            queue.Enqueue(
                                new KeyValuePair<SYS_Quyen, object>(
                                    new SYS_Quyen
                                    {
                                        ID_quyen = id,
                                        ID_cha = node.Key.ID_quyen,
                                        Ma_quyen = ctrl.Name,
                                        Ten_quyen = (child.GetType() == typeof(GridColumn)) ? (child as GridColumn).Caption : ctrl.Tag != null ? ctrl.Tag.ToString() : ctrl.Text != "" ? ctrl.Text : ctrl.Name,
                                        Loai_dieu_khien = StringHelper.GetLastString(child.GetType().ToString()),
                                        ID_goc = node.Key.ID_goc
                                    },
                                    child)
                                );
                        }
                    }
                }
            }

            return controls;
        }
        #endregion
    }
}
