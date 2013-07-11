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
            VaiTroCtrl.LoadLookUpEdit(ledVaiTroKeThua);
            VaiTroQuyenCtrl.ReconfigFormControls(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (ledVaiTro.EditValue == null || ledVaiTro.EditValue.Equals(0))
                sYSQuyenBindingSource.DataSource = null;
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

        private void btnRefreshProperties_Click(object sender, EventArgs e)
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

            btnRefreshProperties.PerformClick();
        }

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            if (grvThuocTinh.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                grvThuocTinh.DeleteSelectedRows();
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

        private void btnInherit_Click(object sender, EventArgs e)
        {
            if (ledVaiTroKeThua.EditValue == null || ledVaiTro.EditValue == null || ledVaiTroKeThua.EditValue.Equals(ledVaiTro.EditValue))
            {
                XtraMessageBox.Show("Vui lòng chọn các vai trò khác nhau để kế thừa", "Lỗi kế thừa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (XtraMessageBox.Show("Bạn có muốn vai trò \"" + ledVaiTro.Text + "\" kế thừa các quyền của vai trò \"" + ledVaiTroKeThua.Text + "\" không?", "Xác nhận kế thừa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rs = VaiTroQuyenCtrl.Inherit((int)ledVaiTroKeThua.EditValue, (int)ledVaiTro.EditValue);

                    if (rs > 0)
                    {
                        XtraMessageBox.Show("Kế thừa các quyền thành công", "Kế thừa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Kế thừa các quyền không thành công", "Lỗi kế thừa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnInheritProperties_Click(object sender, EventArgs e)
        {
            if (ledVaiTro.EditValue == null || ledVaiTro.EditValue.Equals(0)) return;

            SYS_Quyen quyen = (SYS_Quyen)ControlTree.GetDataRecordByNode(ControlTree.FocusedNode);
            int rs = VaiTroQuyenCtrl.Update((int)ledVaiTro.EditValue, quyen.ID_quyen, grvThuocTinh);

            if (rs == 0)
            {
                XtraMessageBox.Show("Không có thay đổi nào được lưu!", "Lưu các thuộc tính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (XtraMessageBox.Show("Bạn có muốn kế thừa các thuộc tính của quyền \"" + quyen.Ten_quyen + "\" cho các quyền cùng loại không?", "Xác nhận kế thừa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(ControlTree.ActiveFilterString == "")
                    rs = VaiTroQuyenCtrl.Inherit((int)ledVaiTro.EditValue, quyen.ID_quyen, (List<SYS_Quyen>)sYSQuyenBindingSource.DataSource);
                else
                    rs = VaiTroQuyenCtrl.Inherit((int)ledVaiTro.EditValue, quyen.ID_quyen, Utils.GetVisibleNodesData<SYS_Quyen>(ControlTree));

                if (rs > 0)
                {
                    XtraMessageBox.Show("Kế thừa các thuộc tính của quyền thành công", "Kế thừa các thuộc tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Không có thuộc tính nào được kế thừa!", "Kế thừa các thuộc tính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCopyProperties_Click(object sender, EventArgs e)
        {
            if (ledVaiTro.EditValue == null || ledVaiTro.EditValue.Equals(0)) return;

            SYS_Quyen quyen = (SYS_Quyen)ControlTree.GetDataRecordByNode(ControlTree.FocusedNode);
            int rs = VaiTroQuyenCtrl.Update((int)ledVaiTro.EditValue, quyen.ID_quyen, grvThuocTinh);

            if (rs == 0)
            {
                XtraMessageBox.Show("Không có thay đổi nào được lưu!", "Lưu các thuộc tính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (XtraMessageBox.Show("Bạn có muốn sao chép các thuộc tính của quyền \"" + quyen.Ten_quyen + "\" cho các quyền cùng loại không?", "Xác nhận sao chép", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(ControlTree.ActiveFilterString == "")
                    rs = VaiTroQuyenCtrl.Copy((int)ledVaiTro.EditValue, quyen.ID_quyen, (List<SYS_Quyen>)sYSQuyenBindingSource.DataSource);
                else
                    rs = VaiTroQuyenCtrl.Copy((int)ledVaiTro.EditValue, quyen.ID_quyen, Utils.GetVisibleNodesData<SYS_Quyen>(ControlTree));

                if (rs > 0)
                {
                    XtraMessageBox.Show("Sao chép các thuộc tính của quyền thành công", "Sao chép các thuộc tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Không có thuộc tính nào được sao chép!", "Sao chép các thuộc tính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (ledVaiTroKeThua.EditValue == null || ledVaiTro.EditValue == null || ledVaiTroKeThua.EditValue.Equals(ledVaiTro.EditValue))
            {
                XtraMessageBox.Show("Vui lòng chọn các vai trò khác nhau để sao chép", "Lỗi sao chép", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (XtraMessageBox.Show("Bạn có muốn vai trò \"" + ledVaiTro.Text + "\" sao chép các quyền của vai trò \"" + ledVaiTroKeThua.Text + "\" không?", "Xác nhận sao chép", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rs = VaiTroQuyenCtrl.Copy((int)ledVaiTroKeThua.EditValue, (int)ledVaiTro.EditValue);

                    if (rs > 0)
                    {
                        XtraMessageBox.Show("Sao chép các quyền thành công", "Sao chép thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Sao chép các quyền không thành công", "Lỗi sao chép", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeleteAllProperties_Click(object sender, EventArgs e)
        {
            grvThuocTinh.SelectAll();
            btnDeleteProperty.PerformClick();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (ledVaiTro.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một vai trò!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ledVaiTro.Focus();
            }
            else
            {
                if (XtraMessageBox.Show("Bạn có chắc chắn bạn muốn xóa toàn bộ các thuộc tính của các quyền bên dưới của vai trò \"" + ledVaiTro.Text + "\" không?", "Xác nhận xóa hết thuộc tính", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rs = 0;
                    if (ControlTree.ActiveFilterString == "")
                        rs = VaiTroQuyenCtrl.ClearAllProperties((int)ledVaiTro.EditValue,(List<SYS_Quyen>)sYSQuyenBindingSource.DataSource);
                    else
                        rs = VaiTroQuyenCtrl.ClearAllProperties((int)ledVaiTro.EditValue, Utils.GetVisibleNodesData<SYS_Quyen>(ControlTree));

                    if (rs > 0)
                    {
                        XtraMessageBox.Show("Xóa các thuộc tính thành công", "Xóa các thuộc tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRefreshProperties.PerformClick();
                    }
                    else
                    {
                        XtraMessageBox.Show("Không có thuộc tính nào được xóa!", "Xóa các thuộc tính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnFilterNotAssigned_Click(object sender, EventArgs e)
        {
            if (ledVaiTro.EditValue == null || ledVaiTro.EditValue.Equals(0))
                sYSQuyenBindingSource.DataSource = null;
            else
            {
                QuyenCtrl.LoadBindingSource(sYSQuyenBindingSource, (int)ledVaiTro.EditValue, 2);
                btnExpandAll.PerformClick();
            }
            
        }

        private void btnFilterAssigned_Click(object sender, EventArgs e)
        {
            if (ledVaiTro.EditValue == null || ledVaiTro.EditValue.Equals(0))
                sYSQuyenBindingSource.DataSource = null;
            else
            {
                QuyenCtrl.LoadBindingSource(sYSQuyenBindingSource, (int)ledVaiTro.EditValue, 1);
                btnExpandAll.PerformClick();
            }
        }
    }
}