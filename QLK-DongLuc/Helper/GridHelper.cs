using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace QLK_DongLuc.Helper
{
    public static class GridHelper
    {
        /// <summary>
        /// Reconfig properties of gridview
        /// </summary>
        /// <param name="gridView">GridView</param>
        public static void ReconfigGridView(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            gridView.BestFitColumns();

            if (gridView.OptionsBehavior.ReadOnly == true)
            {
                gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
                gridView.OptionsBehavior.Editable = false;
            }

            if (gridView.OptionsBehavior.AllowAddRows == DevExpress.Utils.DefaultBoolean.False)
            {
                gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            else
            {
                gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }

            gridView.OptionsView.ShowGroupPanel = gridView.OptionsCustomization.AllowGroup;
            gridView.OptionsView.ShowAutoFilterRow = gridView.OptionsCustomization.AllowFilter;

            //if (gridView.OptionsCustomization.AllowFilter == true)
            //    gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            //else
            gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
        }

        public static void ConfigGridView(DevExpress.XtraGrid.Views.Grid.GridView gridView, string[] bestFitColumns = null, string[] invisibleColumns = null, bool readOnly = false, string[] readOnlyColumns = null, bool allowGroup = false, string[] groupColumns = null, bool merge = false, string[] mergeColumns = null, bool allowFilter = true, bool allowSort = true)
        {
            gridView.OptionsCustomization.AllowFilter = allowFilter;
            gridView.OptionsCustomization.AllowSort = allowSort;

            //AutoSizeColumn
            //gridView.BestFitColumns();

            if (bestFitColumns != null)
            {
                foreach (var column in bestFitColumns)
                {
                    gridView.Columns[column].BestFit();
                }
            }

            //Visible column
            if (invisibleColumns != null)
            {
                foreach (var column in invisibleColumns)
                {
                    gridView.Columns[column].Visible = false;
                }
            }

            //Readonly
            gridView.OptionsBehavior.ReadOnly = readOnly;

            if (!readOnly && readOnlyColumns != null)
            {
                foreach (var column in readOnlyColumns)
                {
                    gridView.Columns[column].OptionsColumn.ReadOnly = true;
                }
            }

            //group column
            gridView.OptionsCustomization.AllowGroup = allowGroup;

            if (groupColumns != null)
            {
                gridView.BeginSort();
                try
                {
                    gridView.ClearGrouping();
                    int index = 0;
                    foreach (var column in groupColumns)
                    {
                        gridView.Columns[column].GroupIndex = index++;
                    }
                }
                finally
                {
                    gridView.EndSort();
                }
            }

            //merge column
            gridView.OptionsView.AllowCellMerge = merge;

            if (mergeColumns != null)
            {
                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    gridView.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                }

                foreach (var column in mergeColumns)
                {
                    gridView.Columns[column].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                }
            }

            ReconfigGridView(gridView);
        }
    }
}