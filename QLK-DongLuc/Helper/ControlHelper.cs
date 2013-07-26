using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace QLK_DongLuc.Helper
{
    public static class ControlHelper
    {
        /// <summary>
        /// Set value for a property of specified component
        /// </summary>
        /// <param name="component">A specified component</param>
        /// <param name="propertyPath">Path of property</param>
        /// <param name="value">Value to set</param>
        public static void SetValue(object component, string propertyPath, object value)
        {
            try
            {
                object propValue = component;
                var props = propertyPath.Split('.');

                for (int i = 0; i < props.Length - 1; i++)
                {
                    propValue = TypeDescriptor.GetProperties(propValue)[props[i]].GetValue(propValue);
                }

                TypeDescriptor.GetProperties(propValue)[props[props.Length - 1]].SetValue(propValue, value);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lỗi gán giá trị cho thuộc tính của thành phần :" + component.ToString());
            }
        }

        /// <summary>
        /// Find control in a parent control, find by name
        /// </summary>
        /// <param name="parent">Parent control</param>
        /// <param name="controlName">Control name</param>
        /// <returns></returns>
        public static object FindControl(object parent, string controlName)
        {
            List<Type> types = new List<Type>(new Type[] { typeof(BarButtonItem), typeof(LookUpEdit), typeof(DateEdit), typeof(SpinEdit), typeof(MemoEdit), typeof(TextEdit), typeof(TimeEdit), typeof(GridColumn) });

            List<Type> ExcludeList = new List<Type>(new Type[] { typeof(Label), typeof(LabelControl) });
            Queue<object> queue = new Queue<object>();
            queue.Enqueue(parent);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                if (node.GetType() == typeof(RibbonControl))
                {
                    var children = (node as RibbonControl).Items;

                    foreach (var child in children)
                    {
                        if (child.GetType() == typeof(BarButtonItem))
                        {
                            BarButtonItem btn = child as BarButtonItem;

                            if (btn.Name == controlName)
                                return btn;

                            queue.Enqueue(child);
                        }
                    }
                }
                else if (types.Contains(node.GetType()))
                {

                }
                else if (node.GetType() == typeof(GridControl))
                {
                    var children = (node as GridControl).Views;

                    foreach (GridView child in children)
                    {
                        if (child.Name == controlName)
                            return child;

                        queue.Enqueue(child);
                    }
                }
                else if (node.GetType() == typeof(GridView))
                {
                    var children = (node as GridView).Columns;

                    foreach (GridColumn child in children)
                    {
                        if (child.Name == controlName)
                            return child;

                        queue.Enqueue(child);
                    }
                }
                else
                {
                    var children = (node as Control).Controls;

                    foreach (Control child in children)
                    {
                        if (!ExcludeList.Contains(child.GetType()))
                        {
                            if (child.Name == controlName)
                                return child;

                            queue.Enqueue(child);
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Reset value of child controls in a specified parent controls to default values
        /// </summary>
        /// <param name="Parent">Parent control</param>
        public static void ResetControls(Control Parent)
        {
            foreach (var control in Parent.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    (control as TextBox).ResetText();
                }
                else if (control.GetType() == typeof(TextEdit))
                {
                    (control as TextEdit).ResetText();
                }
                else if (control.GetType() == typeof(MemoEdit))
                {
                    (control as MemoEdit).ResetText();
                }
                else if (control.GetType() == typeof(LookUpEdit))
                {
                    (control as LookUpEdit).EditValue = null;
                }
                else if (control.GetType() == typeof(DateEdit))
                {
                    (control as DateEdit).EditValue = DatabaseHelper.GetDatabaseDate();
                }
                else if (control.GetType() == typeof(SpinEdit))
                {
                    (control as SpinEdit).EditValue = (control as SpinEdit).Properties.MinValue;
                }
                else if (control.GetType() == typeof(GridControl))
                {
                    (control as GridControl).Views[0].RefreshData();
                }
                else if (control.GetType() == typeof(TableLayoutPanel) || control.GetType() == typeof(Panel) || control.GetType() == typeof(PanelControl) || control.GetType() == typeof(GroupControl) || control.GetType() == typeof(SplitContainerControl) || control.GetType() == typeof(SplitContainerControl) || control.GetType() == typeof(SplitContainer))
                {
                    ResetControls((Control)control);
                }
            }
        }
    }
}
