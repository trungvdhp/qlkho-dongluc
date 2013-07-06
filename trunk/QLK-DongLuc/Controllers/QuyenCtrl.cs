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
using QLK_DongLuc.Models;
using QLK_DongLuc.Views.HeThong;

namespace QLK_DongLuc.Controllers
{
    public class QuyenCtrl
    {
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

        /// <summary>
        /// Get list children controls
        /// </summary>
        /// <returns></returns>
        public static List<SYS_Quyen> GetControls(List<Control> forms)
        {
            List<SYS_Quyen> controls = new List<SYS_Quyen>();
            List<Type> types = new List<Type>(new Type[] { typeof(BarButtonItem), typeof(LookUpEdit), typeof(DateEdit), typeof(SpinEdit), typeof(MemoEdit), typeof(TextEdit), typeof(TimeEdit), typeof(GridColumn) });

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
                                Ten_quyen = form.Text
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
                                        Ten_quyen = btn.Caption
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
                    var children = ((ColumnView)(node.Value as GridControl).Views[0]).Columns;

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
                                    Ten_quyen = child.Caption
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
                                        Ten_quyen = (child.GetType() == typeof(GridColumn)) ? (child as GridColumn).Caption : ctrl.Tag != null ? ctrl.Tag.ToString() : ctrl.Text != "" ? ctrl.Text : ctrl.Name
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
