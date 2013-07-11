namespace QLK_DongLuc.Views.HeThong
{
    partial class frmVaiTroQuyen
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
            this.btnDeleteProperty = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRefreshProperties = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopyProperties = new DevExpress.XtraEditors.SimpleButton();
            this.btnInheritProperties = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteAllProperties = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveProperties = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnFilterNotAssigned = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnFilterAssigned = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.btnInherit = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpandAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnCollapseAll = new DevExpress.XtraEditors.SimpleButton();
            this.ledVaiTroKeThua = new DevExpress.XtraEditors.LookUpEdit();
            this.ledVaiTro = new DevExpress.XtraEditors.LookUpEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ControlTree = new DevExpress.XtraTreeList.TreeList();
            this.colText = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRoot = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.sYSQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdThuocTinh = new DevExpress.XtraGrid.GridControl();
            this.sYSVaiTroQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvThuocTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTen_thuoc_tinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGia_tri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledVaiTroKeThua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledVaiTro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThuocTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSVaiTroQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThuocTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(26, 38);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(65, 20);
            this.btnDeleteProperty.TabIndex = 14;
            this.btnDeleteProperty.Text = "Xóa";
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRefreshProperties);
            this.panelControl1.Controls.Add(this.btnCopyProperties);
            this.panelControl1.Controls.Add(this.btnInheritProperties);
            this.panelControl1.Controls.Add(this.btnDeleteAllProperties);
            this.panelControl1.Controls.Add(this.btnDeleteProperty);
            this.panelControl1.Controls.Add(this.btnSaveProperties);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(330, 67);
            this.panelControl1.TabIndex = 0;
            // 
            // btnRefreshProperties
            // 
            this.btnRefreshProperties.Location = new System.Drawing.Point(26, 12);
            this.btnRefreshProperties.Name = "btnRefreshProperties";
            this.btnRefreshProperties.Size = new System.Drawing.Size(65, 20);
            this.btnRefreshProperties.TabIndex = 20;
            this.btnRefreshProperties.Text = "Làm mới";
            this.btnRefreshProperties.Click += new System.EventHandler(this.btnRefreshProperties_Click);
            // 
            // btnCopyProperties
            // 
            this.btnCopyProperties.Location = new System.Drawing.Point(168, 38);
            this.btnCopyProperties.Name = "btnCopyProperties";
            this.btnCopyProperties.Size = new System.Drawing.Size(136, 20);
            this.btnCopyProperties.TabIndex = 14;
            this.btnCopyProperties.Text = "Lưu và sao chép";
            this.btnCopyProperties.Click += new System.EventHandler(this.btnCopyProperties_Click);
            // 
            // btnInheritProperties
            // 
            this.btnInheritProperties.Location = new System.Drawing.Point(168, 12);
            this.btnInheritProperties.Name = "btnInheritProperties";
            this.btnInheritProperties.Size = new System.Drawing.Size(136, 20);
            this.btnInheritProperties.TabIndex = 14;
            this.btnInheritProperties.Text = "Lưu và kế thừa";
            this.btnInheritProperties.Click += new System.EventHandler(this.btnInheritProperties_Click);
            // 
            // btnDeleteAllProperties
            // 
            this.btnDeleteAllProperties.Location = new System.Drawing.Point(97, 38);
            this.btnDeleteAllProperties.Name = "btnDeleteAllProperties";
            this.btnDeleteAllProperties.Size = new System.Drawing.Size(65, 20);
            this.btnDeleteAllProperties.TabIndex = 14;
            this.btnDeleteAllProperties.Text = "Xóa hết";
            this.btnDeleteAllProperties.Click += new System.EventHandler(this.btnDeleteAllProperties_Click);
            // 
            // btnSaveProperties
            // 
            this.btnSaveProperties.Location = new System.Drawing.Point(97, 12);
            this.btnSaveProperties.Name = "btnSaveProperties";
            this.btnSaveProperties.Size = new System.Drawing.Size(65, 20);
            this.btnSaveProperties.TabIndex = 13;
            this.btnSaveProperties.Text = "Lưu";
            this.btnSaveProperties.Click += new System.EventHandler(this.btnSaveProperties_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnRefresh);
            this.panelControl2.Controls.Add(this.btnFilterNotAssigned);
            this.panelControl2.Controls.Add(this.btnDeleteAll);
            this.panelControl2.Controls.Add(this.btnFilterAssigned);
            this.panelControl2.Controls.Add(this.btnCopy);
            this.panelControl2.Controls.Add(this.btnInherit);
            this.panelControl2.Controls.Add(this.btnExpandAll);
            this.panelControl2.Controls.Add(this.btnCollapseAll);
            this.panelControl2.Controls.Add(this.ledVaiTroKeThua);
            this.panelControl2.Controls.Add(this.ledVaiTro);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(684, 67);
            this.panelControl2.TabIndex = 16;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(311, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 20);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFilterNotAssigned
            // 
            this.btnFilterNotAssigned.Location = new System.Drawing.Point(524, 12);
            this.btnFilterNotAssigned.Name = "btnFilterNotAssigned";
            this.btnFilterNotAssigned.Size = new System.Drawing.Size(136, 20);
            this.btnFilterNotAssigned.TabIndex = 20;
            this.btnFilterNotAssigned.Text = "Chưa gán thuộc tính";
            this.btnFilterNotAssigned.Click += new System.EventHandler(this.btnFilterNotAssigned_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(453, 38);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(65, 20);
            this.btnDeleteAll.TabIndex = 20;
            this.btnDeleteAll.Text = "Xóa hết";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnFilterAssigned
            // 
            this.btnFilterAssigned.Location = new System.Drawing.Point(382, 12);
            this.btnFilterAssigned.Name = "btnFilterAssigned";
            this.btnFilterAssigned.Size = new System.Drawing.Size(136, 20);
            this.btnFilterAssigned.TabIndex = 20;
            this.btnFilterAssigned.Text = "Đã gán thuộc tính";
            this.btnFilterAssigned.Click += new System.EventHandler(this.btnFilterAssigned_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(382, 38);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(65, 20);
            this.btnCopy.TabIndex = 20;
            this.btnCopy.Text = "Sao chép";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnInherit
            // 
            this.btnInherit.Location = new System.Drawing.Point(311, 38);
            this.btnInherit.Name = "btnInherit";
            this.btnInherit.Size = new System.Drawing.Size(65, 20);
            this.btnInherit.TabIndex = 20;
            this.btnInherit.Text = "Kế thừa";
            this.btnInherit.Click += new System.EventHandler(this.btnInherit_Click);
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Location = new System.Drawing.Point(595, 38);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(65, 20);
            this.btnExpandAll.TabIndex = 21;
            this.btnExpandAll.Text = "Mở rộng";
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.Location = new System.Drawing.Point(524, 38);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(65, 20);
            this.btnCollapseAll.TabIndex = 20;
            this.btnCollapseAll.Text = "Thu gọn";
            this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
            // 
            // ledVaiTroKeThua
            // 
            this.ledVaiTroKeThua.Location = new System.Drawing.Point(27, 38);
            this.ledVaiTroKeThua.Name = "ledVaiTroKeThua";
            this.ledVaiTroKeThua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledVaiTroKeThua.Size = new System.Drawing.Size(278, 20);
            this.ledVaiTroKeThua.TabIndex = 18;
            this.ledVaiTroKeThua.EditValueChanged += new System.EventHandler(this.ledVaiTro_EditValueChanged);
            // 
            // ledVaiTro
            // 
            this.ledVaiTro.Location = new System.Drawing.Point(27, 12);
            this.ledVaiTro.Name = "ledVaiTro";
            this.ledVaiTro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledVaiTro.Size = new System.Drawing.Size(278, 20);
            this.ledVaiTro.TabIndex = 18;
            this.ledVaiTro.EditValueChanged += new System.EventHandler(this.ledVaiTro_EditValueChanged);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ControlTree);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grdThuocTinh);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1019, 518);
            this.splitContainerControl1.SplitterPosition = 684;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ControlTree
            // 
            this.ControlTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colText,
            this.colName,
            this.colType,
            this.colRoot});
            this.ControlTree.DataSource = this.sYSQuyenBindingSource;
            this.ControlTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlTree.KeyFieldName = "ID_quyen";
            this.ControlTree.Location = new System.Drawing.Point(0, 67);
            this.ControlTree.Margin = new System.Windows.Forms.Padding(0);
            this.ControlTree.Name = "ControlTree";
            this.ControlTree.OptionsBehavior.AllowIncrementalSearch = true;
            this.ControlTree.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.ControlTree.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.ControlTree.OptionsBehavior.AutoMoveRowFocus = true;
            this.ControlTree.OptionsBehavior.Editable = false;
            this.ControlTree.OptionsBehavior.EnableFiltering = true;
            this.ControlTree.OptionsBehavior.EnterMovesNextColumn = true;
            this.ControlTree.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
            this.ControlTree.OptionsBehavior.UseTabKey = true;
            this.ControlTree.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.ControlTree.OptionsFilter.ShowAllValuesInFilterPopup = true;
            this.ControlTree.OptionsPrint.PrintAllNodes = true;
            this.ControlTree.OptionsPrint.PrintFilledTreeIndent = true;
            this.ControlTree.OptionsPrint.PrintPreview = true;
            this.ControlTree.OptionsView.ShowAutoFilterRow = true;
            this.ControlTree.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.ShowAlways;
            this.ControlTree.OptionsView.ShowPreview = true;
            this.ControlTree.ParentFieldName = "ID_cha";
            this.ControlTree.Size = new System.Drawing.Size(684, 451);
            this.ControlTree.TabIndex = 23;
            this.ControlTree.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.ControlTree_FocusedNodeChanged);
            // 
            // colText
            // 
            this.colText.AppearanceCell.Options.UseTextOptions = true;
            this.colText.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colText.Caption = "Tên";
            this.colText.FieldName = "Ten_quyen";
            this.colText.MinWidth = 32;
            this.colText.Name = "colText";
            this.colText.OptionsColumn.ReadOnly = true;
            this.colText.Visible = true;
            this.colText.VisibleIndex = 0;
            this.colText.Width = 300;
            // 
            // colName
            // 
            this.colName.Caption = "Ký hiệu";
            this.colName.FieldName = "Ma_quyen";
            this.colName.MinWidth = 32;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 100;
            // 
            // colType
            // 
            this.colType.Caption = "Loại";
            this.colType.FieldName = "Loai_dieu_khien";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.ReadOnly = true;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            // 
            // colRoot
            // 
            this.colRoot.AppearanceCell.Options.UseTextOptions = true;
            this.colRoot.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoot.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoot.Caption = "Nhóm";
            this.colRoot.FieldName = "ID_goc";
            this.colRoot.Name = "colRoot";
            this.colRoot.OptionsColumn.FixedWidth = true;
            this.colRoot.OptionsColumn.ReadOnly = true;
            this.colRoot.Visible = true;
            this.colRoot.VisibleIndex = 3;
            this.colRoot.Width = 50;
            // 
            // sYSQuyenBindingSource
            // 
            this.sYSQuyenBindingSource.DataSource = typeof(QLK_DongLuc.Models.SYS_Quyen);
            // 
            // grdThuocTinh
            // 
            this.grdThuocTinh.DataSource = this.sYSVaiTroQuyenBindingSource;
            this.grdThuocTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdThuocTinh.Location = new System.Drawing.Point(0, 67);
            this.grdThuocTinh.MainView = this.grvThuocTinh;
            this.grdThuocTinh.Margin = new System.Windows.Forms.Padding(0);
            this.grdThuocTinh.Name = "grdThuocTinh";
            this.grdThuocTinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemTextEdit5,
            this.repositoryItemCheckEdit1,
            this.repositoryItemLookUpEdit1});
            this.grdThuocTinh.Size = new System.Drawing.Size(330, 451);
            this.grdThuocTinh.TabIndex = 22;
            this.grdThuocTinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvThuocTinh});
            this.grdThuocTinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdThuocTinh_KeyDown);
            // 
            // sYSVaiTroQuyenBindingSource
            // 
            this.sYSVaiTroQuyenBindingSource.DataSource = typeof(QLK_DongLuc.Models.SYS_VaiTroQuyen);
            // 
            // grvThuocTinh
            // 
            this.grvThuocTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTen_thuoc_tinh,
            this.colGia_tri});
            this.grvThuocTinh.GridControl = this.grdThuocTinh;
            this.grvThuocTinh.Name = "grvThuocTinh";
            this.grvThuocTinh.NewItemRowText = "Thêm mới dữ liệu tại đây";
            this.grvThuocTinh.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvThuocTinh.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvThuocTinh.OptionsNavigation.AutoFocusNewRow = true;
            this.grvThuocTinh.OptionsSelection.MultiSelect = true;
            this.grvThuocTinh.OptionsView.EnableAppearanceOddRow = true;
            this.grvThuocTinh.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvThuocTinh.OptionsView.ShowGroupPanel = false;
            this.grvThuocTinh.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvThuocTinh_ValidateRow);
            // 
            // colTen_thuoc_tinh
            // 
            this.colTen_thuoc_tinh.Caption = "Thuộc tính";
            this.colTen_thuoc_tinh.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colTen_thuoc_tinh.FieldName = "ID_thuoc_tinh";
            this.colTen_thuoc_tinh.Name = "colTen_thuoc_tinh";
            this.colTen_thuoc_tinh.Visible = true;
            this.colTen_thuoc_tinh.VisibleIndex = 0;
            this.colTen_thuoc_tinh.Width = 224;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // colGia_tri
            // 
            this.colGia_tri.AppearanceCell.Options.UseTextOptions = true;
            this.colGia_tri.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGia_tri.AppearanceHeader.Options.UseTextOptions = true;
            this.colGia_tri.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGia_tri.Caption = "Giá trị";
            this.colGia_tri.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colGia_tri.FieldName = "Gia_tri";
            this.colGia_tri.Name = "colGia_tri";
            this.colGia_tri.OptionsColumn.FixedWidth = true;
            this.colGia_tri.Visible = true;
            this.colGia_tri.VisibleIndex = 1;
            this.colGia_tri.Width = 60;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // frmVaiTroQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 518);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmVaiTroQuyen";
            this.Text = "Phân quyền cho từng vai trò";
            this.Load += new System.EventHandler(this.frmVaiTroQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledVaiTroKeThua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledVaiTro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ControlTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSQuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThuocTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSVaiTroQuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThuocTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDeleteProperty;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSaveProperties;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList ControlTree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colText;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colType;
        private DevExpress.XtraGrid.GridControl grdThuocTinh;
        private DevExpress.XtraGrid.Views.Grid.GridView grvThuocTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_thuoc_tinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colGia_tri;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnCollapseAll;
        private DevExpress.XtraEditors.SimpleButton btnExpandAll;
        private DevExpress.XtraEditors.LookUpEdit ledVaiTro;
        private DevExpress.XtraEditors.SimpleButton btnRefreshProperties;
        private System.Windows.Forms.BindingSource sYSQuyenBindingSource;
        private System.Windows.Forms.BindingSource sYSVaiTroQuyenBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnFilterAssigned;
        private DevExpress.XtraEditors.SimpleButton btnInherit;
        private DevExpress.XtraEditors.LookUpEdit ledVaiTroKeThua;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRoot;
        private DevExpress.XtraEditors.SimpleButton btnFilterNotAssigned;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAllProperties;
        private DevExpress.XtraEditors.SimpleButton btnInheritProperties;
        private DevExpress.XtraEditors.SimpleButton btnCopyProperties;
        private DevExpress.XtraEditors.SimpleButton btnCopy;



    }
}