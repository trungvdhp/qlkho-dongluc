namespace QLK_DongLuc.Views.DanhMuc
{
    partial class frmLoaiVatTu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.sTOLoaiVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_loai_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_nhom_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.sTONhomVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_loai_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Ten_kho_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Dia_diem_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ID_kho_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOLoaiVatTuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTONhomVatTuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten_kho_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dia_diem_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_kho_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.sTOLoaiVatTuBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(13, 83);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.Ten_kho_edit,
            this.Dia_diem_edit,
            this.ID_kho_edit,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemGridLookUpEdit1});
            this.gridControl.Size = new System.Drawing.Size(758, 265);
            this.gridControl.TabIndex = 3;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl_KeyDown);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_loai_vat_tu,
            this.colID_nhom_vat_tu,
            this.colTen_loai_vat_tu,
            this.colGhi_chu});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.NewItemRowText = "Thêm mới dữ liệu tại đây";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsView.EnableAppearanceOddRow = true;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView_InvalidRowException);
            this.gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            // 
            // colID_loai_vat_tu
            // 
            this.colID_loai_vat_tu.FieldName = "ID_loai_vat_tu";
            this.colID_loai_vat_tu.Name = "colID_loai_vat_tu";
            // 
            // colID_nhom_vat_tu
            // 
            this.colID_nhom_vat_tu.Caption = "Nhóm vật tư";
            this.colID_nhom_vat_tu.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colID_nhom_vat_tu.FieldName = "ID_nhom_vat_tu";
            this.colID_nhom_vat_tu.Name = "colID_nhom_vat_tu";
            this.colID_nhom_vat_tu.Visible = true;
            this.colID_nhom_vat_tu.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.sTONhomVatTuBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Ten_nhom_vat_tu";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemGridLookUpEdit1.ValueMember = "ID_nhom_vat_tu";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Danh sách nhóm vật tư";
            this.gridColumn1.FieldName = "Ten_nhom_vat_tu";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colTen_loai_vat_tu
            // 
            this.colTen_loai_vat_tu.Caption = "Loại vật tư";
            this.colTen_loai_vat_tu.FieldName = "Ten_loai_vat_tu";
            this.colTen_loai_vat_tu.Name = "colTen_loai_vat_tu";
            this.colTen_loai_vat_tu.Visible = true;
            this.colTen_loai_vat_tu.VisibleIndex = 1;
            // 
            // colGhi_chu
            // 
            this.colGhi_chu.Caption = "Diễn giải";
            this.colGhi_chu.FieldName = "Ghi_chu";
            this.colGhi_chu.Name = "colGhi_chu";
            this.colGhi_chu.Visible = true;
            this.colGhi_chu.VisibleIndex = 2;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // Ten_kho_edit
            // 
            this.Ten_kho_edit.AutoHeight = false;
            this.Ten_kho_edit.Name = "Ten_kho_edit";
            // 
            // Dia_diem_edit
            // 
            this.Dia_diem_edit.AutoHeight = false;
            this.Dia_diem_edit.Name = "Dia_diem_edit";
            // 
            // ID_kho_edit
            // 
            this.ID_kho_edit.AutoHeight = false;
            this.ID_kho_edit.Name = "ID_kho_edit";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.sTONhomVatTuBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Ten_nhom_vat_tu";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID_nhom_vat_tu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.label1);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "(Bắt buộc phải nhập)";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(121, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(211, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Diễn giải: là ghi chú, giải thích về  loại vật tư";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "(Bắt buộc phải nhập)";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(121, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(255, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Nhóm vật tư: Lựa chọn nhóm vật tư chứa  loại vật tư";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(121, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(279, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Loại vật tư: là tên của loại vật tư (VD: loại Giá đỡ, Tụ, ...) ";
            // 
            // frmLoaiVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmLoaiVatTu";
            this.Text = "Danh sách loại vật tư";
            this.Load += new System.EventHandler(this.frmLoaiVatTu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOLoaiVatTuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTONhomVatTuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten_kho_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dia_diem_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_kho_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Ten_kho_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Dia_diem_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ID_kho_edit;
        private System.Windows.Forms.BindingSource sTOLoaiVatTuBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID_loai_vat_tu;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_loai_vat_tu;
        private DevExpress.XtraGrid.Columns.GridColumn colID_nhom_vat_tu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource sTONhomVatTuBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_chu;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label label2;


    }
}