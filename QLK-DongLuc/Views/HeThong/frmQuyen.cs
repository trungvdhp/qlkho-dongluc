using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using QLK_DongLuc.Models;
using QLK_DongLuc.Controllers;

namespace QLK_DongLuc.Views.HeThong
{
    public partial class frmQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmQuyen()
        {
            InitializeComponent();
        }

        private void btnScanControls_Click(object sender, EventArgs e)
        {
            QuyenCtrl.LoadAllControls(sYSQuyenBindingSourceNew);
            btnExpandAllNew.PerformClick();
        }

        Hashtable nodesForDeleting;

        private Hashtable GetNodesNewForDeleting()
        {
            nodesForDeleting = new Hashtable();
            IEnumerator sel = ControlTreeNew.Selection.GetEnumerator();
            sel.Reset();

            while (sel.MoveNext())
            {
                AddSelectedNode((DevExpress.XtraTreeList.Nodes.TreeListNode)sel.Current);
            }

            return nodesForDeleting;
        }

        private Hashtable GetNodesOldForDeleting()
        {
            nodesForDeleting = new Hashtable();
            IEnumerator sel = ControlTreeOld.Selection.GetEnumerator();
            sel.Reset();

            while (sel.MoveNext())
            {
                AddSelectedNode((DevExpress.XtraTreeList.Nodes.TreeListNode)sel.Current);
            }

            return nodesForDeleting;
        }

        private void AddSelectedNode(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            DevExpress.XtraTreeList.Nodes.TreeListNode pnode = GetSelectedParent(node);
            nodesForDeleting[pnode] = pnode;
        }

        private DevExpress.XtraTreeList.Nodes.TreeListNode GetSelectedParent(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            DevExpress.XtraTreeList.Nodes.TreeListNode pnode = node;

            while (pnode.ParentNode != null && pnode.ParentNode.Selected)
            {
                pnode = pnode.ParentNode;
            }
            return pnode;
        }

        private void btnDeleteNew_Click(object sender, EventArgs e)
        {
            if (ControlTreeNew.AllNodesCount == 0) return;

            if (XtraMessageBox.Show("Bạn có chắc bạn muốn xóa các hàng đã chọn trong cây mới?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControlTreeNew.LockReloadNodes();

                try
                {
                    Hashtable sel = GetNodesNewForDeleting();
                    IDictionaryEnumerator nodes = sel.GetEnumerator();
                    nodes.Reset();

                    while (nodes.MoveNext())
                    {
                        ControlTreeNew.DeleteNode((DevExpress.XtraTreeList.Nodes.TreeListNode)nodes.Value);
                    }
                }
                finally 
                { 
                    ControlTreeNew.UnlockReloadNodes(); 
                }
            }
        }

        private void ControlTreeNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDeleteNew.PerformClick();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            QuyenCtrl.LoadBindingSource(sYSQuyenBindingSourceOld);
            btnExpandAllOld.PerformClick();
        }

        private void frmQuyen_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
            btnScanControls.PerformClick();
            VaiTroQuyenCtrl.ReconfigFormControls(this);
        }

        private void btnDeleteOld_Click(object sender, EventArgs e)
        {
            if (ControlTreeNew.AllNodesCount == 0) return;

            if (XtraMessageBox.Show("Bạn có chắc bạn muốn xóa các hàng đã chọn trong cây cũ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControlTreeOld.LockReloadNodes();

                try
                {
                    Hashtable sel = GetNodesOldForDeleting();
                    IDictionaryEnumerator nodes = sel.GetEnumerator();
                    nodes.Reset();

                    while (nodes.MoveNext())
                    {
                        ControlTreeOld.DeleteNode((DevExpress.XtraTreeList.Nodes.TreeListNode)nodes.Value);
                    }
                }
                finally
                {
                    ControlTreeOld.UnlockReloadNodes();
                }
            }
        }

        private void btnSaveOld_Click(object sender, EventArgs e)
        {
            List<SYS_Quyen> list = (List<SYS_Quyen>)sYSQuyenBindingSourceOld.DataSource;
            var items = list.Select(t => t.ID_quyen).ToList();
            Entities db = new Entities();
            var entyties = db.SYS_Quyen.Where(t => !items.Contains(t.ID_quyen));
            db.SYS_Quyen.RemoveRange(entyties);

            if (db.SaveChanges() > 0)
            {
                XtraMessageBox.Show("Lưu các quyền cũ thành công", "Lưu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lưu các quyền cũ không thành công", "Lỗi khi lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            List<SYS_Quyen> list = (List<SYS_Quyen>)sYSQuyenBindingSourceNew.DataSource;

            Entities db = new Entities();
            db.SYS_Quyen.RemoveRange(db.SYS_Quyen.ToList());
            db.SYS_Quyen.AddRange(list);

            if (db.SaveChanges() > 0)
            {
                XtraMessageBox.Show("Lưu các quyền mới thành công", "Lưu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefresh.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Lưu các quyền mới không thành công", "Lỗi khi lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExpandAllOld_Click(object sender, EventArgs e)
        {
            ControlTreeOld.ExpandAll();
        }

        private void btnCollapseAllOld_Click(object sender, EventArgs e)
        {
            ControlTreeOld.CollapseAll();
        }

        private void btnExpandAllNew_Click(object sender, EventArgs e)
        {
            ControlTreeNew.ExpandAll();
        }

        private void btnCollapseAllNew_Click(object sender, EventArgs e)
        {
            ControlTreeNew.CollapseAll();
        }
    }
}