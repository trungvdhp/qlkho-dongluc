namespace QLK_DongLuc.Views.HeThong
{
    partial class frmQuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ControlTreeOld = new DevExpress.XtraTreeList.TreeList();
            this.colTextOld = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNameOld = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTypeOld = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.sYSQuyenBindingSourceOld = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveOld = new DevExpress.XtraEditors.SimpleButton();
            this.btnCollapseAllOld = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpandAllOld = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteOld = new DevExpress.XtraEditors.SimpleButton();
            this.ControlTreeNew = new DevExpress.XtraTreeList.TreeList();
            this.colTextNew = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNameNew = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTypeNew = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.sYSQuyenBindingSourceNew = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCollapseAllNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpandAllNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnScanControls = new DevExpress.XtraEditors.SimpleButton();
            this.colRootOld = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRootNew = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlTreeOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSQuyenBindingSourceOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlTreeNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSQuyenBindingSourceNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ControlTreeOld);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.ControlTreeNew);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1008, 730);
            this.splitContainerControl1.SplitterPosition = 512;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ControlTreeOld
            // 
            this.ControlTreeOld.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTextOld,
            this.colNameOld,
            this.colTypeOld,
            this.colRootOld});
            this.ControlTreeOld.DataSource = this.sYSQuyenBindingSourceOld;
            this.ControlTreeOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlTreeOld.KeyFieldName = "ID_quyen";
            this.ControlTreeOld.Location = new System.Drawing.Point(0, 42);
            this.ControlTreeOld.Name = "ControlTreeOld";
            this.ControlTreeOld.OptionsBehavior.AllowIncrementalSearch = true;
            this.ControlTreeOld.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.ControlTreeOld.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.ControlTreeOld.OptionsBehavior.AutoMoveRowFocus = true;
            this.ControlTreeOld.OptionsBehavior.Editable = false;
            this.ControlTreeOld.OptionsBehavior.EnableFiltering = true;
            this.ControlTreeOld.OptionsBehavior.EnterMovesNextColumn = true;
            this.ControlTreeOld.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
            this.ControlTreeOld.OptionsBehavior.UseTabKey = true;
            this.ControlTreeOld.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.ControlTreeOld.OptionsFilter.ShowAllValuesInFilterPopup = true;
            this.ControlTreeOld.OptionsPrint.PrintAllNodes = true;
            this.ControlTreeOld.OptionsPrint.PrintFilledTreeIndent = true;
            this.ControlTreeOld.OptionsPrint.PrintPreview = true;
            this.ControlTreeOld.OptionsView.ShowAutoFilterRow = true;
            this.ControlTreeOld.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.ShowAlways;
            this.ControlTreeOld.OptionsView.ShowPreview = true;
            this.ControlTreeOld.ParentFieldName = "ID_cha";
            this.ControlTreeOld.Size = new System.Drawing.Size(512, 688);
            this.ControlTreeOld.TabIndex = 17;
            // 
            // colTextOld
            // 
            this.colTextOld.Caption = "Text";
            this.colTextOld.FieldName = "Ten_quyen";
            this.colTextOld.MinWidth = 32;
            this.colTextOld.Name = "colTextOld";
            this.colTextOld.OptionsColumn.ReadOnly = true;
            this.colTextOld.Visible = true;
            this.colTextOld.VisibleIndex = 0;
            this.colTextOld.Width = 300;
            // 
            // colNameOld
            // 
            this.colNameOld.Caption = "Name";
            this.colNameOld.FieldName = "Ma_quyen";
            this.colNameOld.MinWidth = 32;
            this.colNameOld.Name = "colNameOld";
            this.colNameOld.OptionsColumn.ReadOnly = true;
            this.colNameOld.Visible = true;
            this.colNameOld.VisibleIndex = 1;
            this.colNameOld.Width = 100;
            // 
            // colTypeOld
            // 
            this.colTypeOld.Caption = "Type";
            this.colTypeOld.FieldName = "Loai_dieu_khien";
            this.colTypeOld.Name = "colTypeOld";
            this.colTypeOld.OptionsColumn.ReadOnly = true;
            this.colTypeOld.Visible = true;
            this.colTypeOld.VisibleIndex = 2;
            // 
            // sYSQuyenBindingSourceOld
            // 
            this.sYSQuyenBindingSourceOld.DataSource = typeof(QLK_DongLuc.Models.SYS_Quyen);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnRefresh);
            this.panelControl2.Controls.Add(this.btnSaveOld);
            this.panelControl2.Controls.Add(this.btnCollapseAllOld);
            this.panelControl2.Controls.Add(this.btnExpandAllOld);
            this.panelControl2.Controls.Add(this.btnDeleteOld);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(512, 42);
            this.panelControl2.TabIndex = 16;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(27, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSaveOld
            // 
            this.btnSaveOld.Location = new System.Drawing.Point(240, 11);
            this.btnSaveOld.Name = "btnSaveOld";
            this.btnSaveOld.Size = new System.Drawing.Size(65, 23);
            this.btnSaveOld.TabIndex = 14;
            this.btnSaveOld.Text = "Lưu";
            this.btnSaveOld.Click += new System.EventHandler(this.btnSaveOld_Click);
            // 
            // btnCollapseAllOld
            // 
            this.btnCollapseAllOld.Location = new System.Drawing.Point(169, 11);
            this.btnCollapseAllOld.Name = "btnCollapseAllOld";
            this.btnCollapseAllOld.Size = new System.Drawing.Size(65, 23);
            this.btnCollapseAllOld.TabIndex = 14;
            this.btnCollapseAllOld.Text = "Thu gọn";
            this.btnCollapseAllOld.Click += new System.EventHandler(this.btnCollapseAllOld_Click);
            // 
            // btnExpandAllOld
            // 
            this.btnExpandAllOld.Location = new System.Drawing.Point(98, 11);
            this.btnExpandAllOld.Name = "btnExpandAllOld";
            this.btnExpandAllOld.Size = new System.Drawing.Size(65, 23);
            this.btnExpandAllOld.TabIndex = 14;
            this.btnExpandAllOld.Text = "Mở rộng";
            this.btnExpandAllOld.Click += new System.EventHandler(this.btnExpandAllOld_Click);
            // 
            // btnDeleteOld
            // 
            this.btnDeleteOld.Location = new System.Drawing.Point(311, 11);
            this.btnDeleteOld.Name = "btnDeleteOld";
            this.btnDeleteOld.Size = new System.Drawing.Size(65, 23);
            this.btnDeleteOld.TabIndex = 14;
            this.btnDeleteOld.Text = "Xóa";
            this.btnDeleteOld.Click += new System.EventHandler(this.btnDeleteOld_Click);
            // 
            // ControlTreeNew
            // 
            this.ControlTreeNew.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTextNew,
            this.colNameNew,
            this.colTypeNew,
            this.colRootNew});
            this.ControlTreeNew.DataSource = this.sYSQuyenBindingSourceNew;
            this.ControlTreeNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlTreeNew.KeyFieldName = "ID_quyen";
            this.ControlTreeNew.Location = new System.Drawing.Point(0, 42);
            this.ControlTreeNew.Name = "ControlTreeNew";
            this.ControlTreeNew.OptionsBehavior.AllowIncrementalSearch = true;
            this.ControlTreeNew.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.ControlTreeNew.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.ControlTreeNew.OptionsBehavior.AutoMoveRowFocus = true;
            this.ControlTreeNew.OptionsBehavior.Editable = false;
            this.ControlTreeNew.OptionsBehavior.EnableFiltering = true;
            this.ControlTreeNew.OptionsBehavior.EnterMovesNextColumn = true;
            this.ControlTreeNew.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
            this.ControlTreeNew.OptionsBehavior.UseTabKey = true;
            this.ControlTreeNew.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.ControlTreeNew.OptionsFilter.ShowAllValuesInFilterPopup = true;
            this.ControlTreeNew.OptionsPrint.PrintAllNodes = true;
            this.ControlTreeNew.OptionsPrint.PrintFilledTreeIndent = true;
            this.ControlTreeNew.OptionsPrint.PrintPreview = true;
            this.ControlTreeNew.OptionsSelection.MultiSelect = true;
            this.ControlTreeNew.OptionsView.ShowAutoFilterRow = true;
            this.ControlTreeNew.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.ShowAlways;
            this.ControlTreeNew.OptionsView.ShowPreview = true;
            this.ControlTreeNew.ParentFieldName = "ID_cha";
            this.ControlTreeNew.Size = new System.Drawing.Size(491, 688);
            this.ControlTreeNew.TabIndex = 15;
            this.ControlTreeNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlTreeNew_KeyDown);
            // 
            // colTextNew
            // 
            this.colTextNew.Caption = "Text";
            this.colTextNew.FieldName = "Ten_quyen";
            this.colTextNew.MinWidth = 32;
            this.colTextNew.Name = "colTextNew";
            this.colTextNew.OptionsColumn.ReadOnly = true;
            this.colTextNew.Visible = true;
            this.colTextNew.VisibleIndex = 0;
            this.colTextNew.Width = 300;
            // 
            // colNameNew
            // 
            this.colNameNew.Caption = "Name";
            this.colNameNew.FieldName = "Ma_quyen";
            this.colNameNew.MinWidth = 32;
            this.colNameNew.Name = "colNameNew";
            this.colNameNew.OptionsColumn.ReadOnly = true;
            this.colNameNew.Visible = true;
            this.colNameNew.VisibleIndex = 1;
            this.colNameNew.Width = 100;
            // 
            // colTypeNew
            // 
            this.colTypeNew.Caption = "Type";
            this.colTypeNew.FieldName = "Loai_dieu_khien";
            this.colTypeNew.Name = "colTypeNew";
            this.colTypeNew.OptionsColumn.ReadOnly = true;
            this.colTypeNew.Visible = true;
            this.colTypeNew.VisibleIndex = 2;
            // 
            // sYSQuyenBindingSourceNew
            // 
            this.sYSQuyenBindingSourceNew.DataSource = typeof(QLK_DongLuc.Models.SYS_Quyen);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCollapseAllNew);
            this.panelControl1.Controls.Add(this.btnExpandAllNew);
            this.panelControl1.Controls.Add(this.btnDeleteNew);
            this.panelControl1.Controls.Add(this.btnSaveNew);
            this.panelControl1.Controls.Add(this.btnScanControls);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(491, 42);
            this.panelControl1.TabIndex = 0;
            // 
            // btnCollapseAllNew
            // 
            this.btnCollapseAllNew.Location = new System.Drawing.Point(169, 11);
            this.btnCollapseAllNew.Name = "btnCollapseAllNew";
            this.btnCollapseAllNew.Size = new System.Drawing.Size(65, 23);
            this.btnCollapseAllNew.TabIndex = 15;
            this.btnCollapseAllNew.Text = "Thu gọn";
            this.btnCollapseAllNew.Click += new System.EventHandler(this.btnCollapseAllNew_Click);
            // 
            // btnExpandAllNew
            // 
            this.btnExpandAllNew.Location = new System.Drawing.Point(98, 11);
            this.btnExpandAllNew.Name = "btnExpandAllNew";
            this.btnExpandAllNew.Size = new System.Drawing.Size(65, 23);
            this.btnExpandAllNew.TabIndex = 16;
            this.btnExpandAllNew.Text = "Mở rộng";
            this.btnExpandAllNew.Click += new System.EventHandler(this.btnExpandAllNew_Click);
            // 
            // btnDeleteNew
            // 
            this.btnDeleteNew.Location = new System.Drawing.Point(311, 11);
            this.btnDeleteNew.Name = "btnDeleteNew";
            this.btnDeleteNew.Size = new System.Drawing.Size(65, 23);
            this.btnDeleteNew.TabIndex = 14;
            this.btnDeleteNew.Text = "Xóa";
            this.btnDeleteNew.Click += new System.EventHandler(this.btnDeleteNew_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(240, 11);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(65, 23);
            this.btnSaveNew.TabIndex = 13;
            this.btnSaveNew.Text = "Lưu";
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnScanControls
            // 
            this.btnScanControls.Location = new System.Drawing.Point(27, 11);
            this.btnScanControls.Name = "btnScanControls";
            this.btnScanControls.Size = new System.Drawing.Size(65, 23);
            this.btnScanControls.TabIndex = 12;
            this.btnScanControls.Text = "Quét mã";
            this.btnScanControls.Click += new System.EventHandler(this.btnScanControls_Click);
            // 
            // colRootOld
            // 
            this.colRootOld.Caption = "Gốc";
            this.colRootOld.FieldName = "ID_goc";
            this.colRootOld.Name = "colRootOld";
            this.colRootOld.Visible = true;
            this.colRootOld.VisibleIndex = 3;
            this.colRootOld.Width = 40;
            // 
            // colRootNew
            // 
            this.colRootNew.Caption = "Gốc";
            this.colRootNew.FieldName = "ID_goc";
            this.colRootNew.Name = "colRootNew";
            this.colRootNew.Visible = true;
            this.colRootNew.VisibleIndex = 3;
            this.colRootNew.Width = 40;
            // 
            // frmQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quyền";
            this.Load += new System.EventHandler(this.frmQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ControlTreeOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSQuyenBindingSourceOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ControlTreeNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSQuyenBindingSourceNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList ControlTreeNew;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTextNew;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNameNew;
        private System.Windows.Forms.BindingSource sYSQuyenBindingSourceNew;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteNew;
        private DevExpress.XtraEditors.SimpleButton btnSaveNew;
        private DevExpress.XtraEditors.SimpleButton btnScanControls;
        private DevExpress.XtraTreeList.TreeList ControlTreeOld;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTextOld;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNameOld;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDeleteOld;
        private System.Windows.Forms.BindingSource sYSQuyenBindingSourceOld;
        private DevExpress.XtraEditors.SimpleButton btnSaveOld;
        private DevExpress.XtraEditors.SimpleButton btnCollapseAllOld;
        private DevExpress.XtraEditors.SimpleButton btnExpandAllOld;
        private DevExpress.XtraEditors.SimpleButton btnCollapseAllNew;
        private DevExpress.XtraEditors.SimpleButton btnExpandAllNew;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTypeOld;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTypeNew;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRootOld;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRootNew;


    }
}