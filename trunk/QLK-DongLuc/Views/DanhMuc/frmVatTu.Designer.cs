namespace QLK_DongLuc.Views.DanhMuc
{
    partial class frmVatTu
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
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_loai_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleLoaiVatTu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colMa_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDon_vi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.sTOVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ledLoaiVatTu = new DevExpress.XtraEditors.LookUpEdit();
            this.ledNhomVatTu = new DevExpress.XtraEditors.LookUpEdit();
            this.ledKhoVatTu = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleKhoVatTu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rleNhomVatTu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleLoaiVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOVatTuBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledLoaiVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhomVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledKhoVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleKhoVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleNhomVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colID_loai_vat_tu,
            this.colMa_vat_tu,
            this.colTen_vat_tu,
            this.colDon_vi});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupPanelText = "Kéo tiêu đề cột vào đây để nhóm theo cột đó";
            this.gridView.Name = "gridView";
            this.gridView.NewItemRowText = "Thêm mới dữ liệu tại đây";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsView.EnableAppearanceOddRow = true;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView_InvalidRowException);
            this.gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            // 
            // colID_loai_vat_tu
            // 
            this.colID_loai_vat_tu.Caption = "Loại vật tư";
            this.colID_loai_vat_tu.ColumnEdit = this.rleLoaiVatTu;
            this.colID_loai_vat_tu.FieldName = "ID_loai_vat_tu";
            this.colID_loai_vat_tu.Name = "colID_loai_vat_tu";
            this.colID_loai_vat_tu.OptionsColumn.ReadOnly = true;
            this.colID_loai_vat_tu.Visible = true;
            this.colID_loai_vat_tu.VisibleIndex = 2;
            // 
            // rleLoaiVatTu
            // 
            this.rleLoaiVatTu.AutoHeight = false;
            this.rleLoaiVatTu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleLoaiVatTu.Name = "rleLoaiVatTu";
            // 
            // colMa_vat_tu
            // 
            this.colMa_vat_tu.Caption = "Mã vật tư";
            this.colMa_vat_tu.FieldName = "Ma_vat_tu";
            this.colMa_vat_tu.Name = "colMa_vat_tu";
            this.colMa_vat_tu.Visible = true;
            this.colMa_vat_tu.VisibleIndex = 3;
            // 
            // colTen_vat_tu
            // 
            this.colTen_vat_tu.Caption = "Vật tư - Chủng loại";
            this.colTen_vat_tu.FieldName = "Ten_vat_tu";
            this.colTen_vat_tu.Name = "colTen_vat_tu";
            this.colTen_vat_tu.Visible = true;
            this.colTen_vat_tu.VisibleIndex = 4;
            // 
            // colDon_vi
            // 
            this.colDon_vi.Caption = "Khẩu độ";
            this.colDon_vi.ColumnEdit = this.repositoryItemSpinEdit2;
            this.colDon_vi.DisplayFormat.FormatString = "{0:N1} (m)";
            this.colDon_vi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDon_vi.FieldName = "Don_vi";
            this.colDon_vi.Name = "colDon_vi";
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit2.MaxLength = 10;
            this.repositoryItemSpinEdit2.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            this.repositoryItemSpinEdit2.NullValuePrompt = "Nhập khẩu độ";
            this.repositoryItemSpinEdit2.NullValuePromptShowForEmptyValue = true;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.sTOVatTuBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControl_EmbeddedNavigator_ButtonClick);
            this.gridControl.Location = new System.Drawing.Point(13, 83);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rleLoaiVatTu,
            this.repositoryItemSpinEdit2,
            this.rleKhoVatTu,
            this.rleNhomVatTu});
            this.gridControl.Size = new System.Drawing.Size(758, 265);
            this.gridControl.TabIndex = 3;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 361);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ledLoaiVatTu);
            this.groupBox1.Controls.Add(this.ledNhomVatTu);
            this.groupBox1.Controls.Add(this.ledKhoVatTu);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chú thích:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ledLoaiVatTu
            // 
            this.ledLoaiVatTu.Location = new System.Drawing.Point(634, 28);
            this.ledLoaiVatTu.Name = "ledLoaiVatTu";
            this.ledLoaiVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledLoaiVatTu.Size = new System.Drawing.Size(189, 20);
            this.ledLoaiVatTu.TabIndex = 16;
            this.ledLoaiVatTu.EditValueChanged += new System.EventHandler(this.ledLoaiVatTu_EditValueChanged);
            // 
            // ledNhomVatTu
            // 
            this.ledNhomVatTu.Location = new System.Drawing.Point(363, 28);
            this.ledNhomVatTu.Name = "ledNhomVatTu";
            this.ledNhomVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledNhomVatTu.Size = new System.Drawing.Size(189, 20);
            this.ledNhomVatTu.TabIndex = 15;
            this.ledNhomVatTu.EditValueChanged += new System.EventHandler(this.ledNhomVatTu_EditValueChanged);
            // 
            // ledKhoVatTu
            // 
            this.ledKhoVatTu.Location = new System.Drawing.Point(84, 28);
            this.ledKhoVatTu.Name = "ledKhoVatTu";
            this.ledKhoVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledKhoVatTu.Size = new System.Drawing.Size(189, 20);
            this.ledKhoVatTu.TabIndex = 14;
            this.ledKhoVatTu.EditValueChanged += new System.EventHandler(this.ledKhoVatTu_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(23, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Kho vật tư:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(569, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Loại vật tư: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(293, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Nhóm vật tư:";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Kho vật tư";
            this.gridColumn1.ColumnEdit = this.rleKhoVatTu;
            this.gridColumn1.FieldName = "ID_kho";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nhóm vật tư";
            this.gridColumn2.ColumnEdit = this.rleNhomVatTu;
            this.gridColumn2.FieldName = "ID_nhom_vat_tu";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // rleKhoVatTu
            // 
            this.rleKhoVatTu.AutoHeight = false;
            this.rleKhoVatTu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleKhoVatTu.Name = "rleKhoVatTu";
            // 
            // rleNhomVatTu
            // 
            this.rleNhomVatTu.AutoHeight = false;
            this.rleNhomVatTu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleNhomVatTu.Name = "rleNhomVatTu";
            // 
            // frmVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmVatTu";
            this.Text = "Danh sách vật tư - chủng loại";
            this.Load += new System.EventHandler(this.frmVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleLoaiVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOVatTuBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledLoaiVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhomVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledKhoVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleKhoVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleNhomVatTu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_loai_vat_tu;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_vat_tu;
        private DevExpress.XtraGrid.Columns.GridColumn colDon_vi;
        private System.Windows.Forms.BindingSource sTOVatTuBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_vat_tu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleLoaiVatTu;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.LookUpEdit ledNhomVatTu;
        private DevExpress.XtraEditors.LookUpEdit ledKhoVatTu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit ledLoaiVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleKhoVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleNhomVatTu;


    }
}