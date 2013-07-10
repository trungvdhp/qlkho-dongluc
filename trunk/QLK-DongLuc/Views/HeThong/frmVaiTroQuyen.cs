using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using QLK_DongLuc.Controllers;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Views.HeThong
{
    public partial class frmVaiTroQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmVaiTroQuyen()
        {
            InitializeComponent();
        }

        private void frmVaiTroQuyen_Load(object sender, EventArgs e)
        {
            VaiTroCtrl.LoadLookUpEdit(ledVaiTro);
            VaiTroQuyenCtrl.ReconfigFormControls(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (ledVaiTro.EditValue == null || ledVaiTro.EditValue.Equals(0))
                sYSQuyenBindingSource = null;
            else
            {
                QuyenCtrl.LoadBindingSource(sYSQuyenBindingSource);
                btnExpandAll.PerformClick();
            }
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            ControlTree.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            ControlTree.CollapseAll();
        }

        private void LoadProperties(TreeListNode node)
        {
            SYS_Quyen quyen = (SYS_Quyen)ControlTree.GetDataRecordByNode(node);

            if (quyen != null)
            {
                Entities db = new Entities();
                ThuocTinhCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1, quyen.Loai_dieu_khien, db);
                VaiTroQuyenCtrl.LoadBindingSource(sYSVaiTroQuyenBindingSource, ledVaiTro.EditValue, quyen.ID_quyen, db);
            }
        }

        private void ControlTree_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            LoadProperties(e.Node);
        }

        private void btnRefreshProperty_Click(object sender, EventArgs e)
        {
            LoadProperties(ControlTree.FocusedNode);
        }

        private void grdThuocTinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && grvThuocTinh.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing && grvThuocTinh.OptionsBehavior.AllowDeleteRows == DevExpress.Utils.DefaultBoolean.True)
            {
                grvThuocTinh.DeleteRow(grvThuocTinh.FocusedRowHandle);
            }

            if (e.KeyCode == Keys.Enter && grvThuocTinh.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle && grvThuocTinh.OptionsBehavior.Editable == true)
            {
                grvThuocTinh.CloseEditor();
                grvThuocTinh.UpdateCurrentRow();
            }

            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.P)
            {
                if (!grdThuocTinh.IsPrintingAvailable)
                {
                    XtraMessageBox.Show("Not available printing.", "Lỗi in dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                grdThuocTinh.ShowPrintPreview();
            }
        }

        private void btnSaveProperties_Click(object sender, EventArgs e)
        {
            if (ledVaiTro.EditValue == null || ledVaiTro.EditValue.Equals(0)) return;

            SYS_Quyen quyen = (SYS_Quyen)ControlTree.GetDataRecordByNode(ControlTree.FocusedNode);
            int rs = VaiTroQuyenCtrl.Update((int)ledVaiTro.EditValue, quyen.ID_quyen, grvThuocTinh);

            if (rs == 0)
            {
                XtraMessageBox.Show("Không có thay đổi nào được lưu. Vui lòng thử lại!", "Lưu các thuộc tính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                XtraMessageBox.Show("Lưu các thuộc tính thành công!", "Lưu các thuộc tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnRefreshProperty.PerformClick();
        }

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            if (grvThuocTinh.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                grvThuocTinh.DeleteRow(grvThuocTinh.FocusedRowHandle);
            }
        }

        private void ledVaiTro_EditValueChanged(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void grvThuocTinh_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;
            string sError = "";

            var ID_thuoc_tinh = grvThuocTinh.GetRowCellValue(e.RowHandle, "ID_thuoc_tinh");
            
            if (ID_thuoc_tinh.Equals(0))
            {
                bError = true;
                sError += "\n Chưa chọn thuộc tính.";
            }
            else
            {
                int n = grvThuocTinh.RowCount;

                for (int i = 0; i < n; i++)
                {
                    if (i != e.RowHandle)
                    {
                        var id = grvThuocTinh.GetRowCellValue(i, "ID_thuoc_tinh");

                        if (ID_thuoc_tinh.Equals(id))
                        {
                            bError = true;
                            sError += "\n Không được chọn trùng thuộc tính.";
                            break;
                        }
                    }
                }
            }

            if (bError)
            {
                e.ErrorText = sError + "\n Bạn có muốn sửa lại không?\n";
                e.Valid = false;
                //XtraMessageBox.Show(sError, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}