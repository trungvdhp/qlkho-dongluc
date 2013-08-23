namespace QLK_DongLuc.Views.DanhMuc
{
    partial class frmNhomVatTu
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
            this.sTONhomVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKho_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleKhoVatTu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTen_nhom_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_nhom_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTONhomVatTuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleKhoVatTu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 361);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.sTONhomVatTuBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControl_EmbeddedNavigator_ButtonClick);
            this.gridControl.Location = new System.Drawing.Point(13, 53);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rleKhoVatTu});
            this.gridControl.Size = new System.Drawing.Size(758, 295);
            this.gridControl.TabIndex = 0;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl_KeyDown);
            // 
            // sTONhomVatTuBindingSource
            // 
            this.sTONhomVatTuBindingSource.DataSource = typeof(QLK_DongLuc.Models.STO_NhomVatTu);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKho_vat_tu,
            this.colTen_nhom_vat_tu,
            this.colMa_nhom_vat_tu,
            this.colGhi_chu});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupPanelText = "Kéo tiêu đề cột vào đây để nhóm theo cột đó";
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView_InvalidRowException);
            this.gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            // 
            // colKho_vat_tu
            // 
            this.colKho_vat_tu.Caption = "Kho vật tư";
            this.colKho_vat_tu.ColumnEdit = this.rleKhoVatTu;
            this.colKho_vat_tu.FieldName = "ID_kho";
            this.colKho_vat_tu.Name = "colKho_vat_tu";
            this.colKho_vat_tu.OptionsColumn.ReadOnly = true;
            this.colKho_vat_tu.Visible = true;
            this.colKho_vat_tu.VisibleIndex = 0;
            // 
            // rleKhoVatTu
            // 
            this.rleKhoVatTu.AutoHeight = false;
            this.rleKhoVatTu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleKhoVatTu.Name = "rleKhoVatTu";
            // 
            // colTen_nhom_vat_tu
            // 
            this.colTen_nhom_vat_tu.Caption = "Tên nhóm vật tư";
            this.colTen_nhom_vat_tu.FieldName = "Ten_nhom_vat_tu";
            this.colTen_nhom_vat_tu.Name = "colTen_nhom_vat_tu";
            this.colTen_nhom_vat_tu.Visible = true;
            this.colTen_nhom_vat_tu.VisibleIndex = 1;
            // 
            // colMa_nhom_vat_tu
            // 
            this.colMa_nhom_vat_tu.Caption = "Mã nhóm vật tư";
            this.colMa_nhom_vat_tu.FieldName = "Ma_nhom_vat_tu";
            this.colMa_nhom_vat_tu.Name = "colMa_nhom_vat_tu";
            // 
            // colGhi_chu
            // 
            this.colGhi_chu.Caption = "Diễn giải";
            this.colGhi_chu.FieldName = "Ghi_chu";
            this.colGhi_chu.Name = "colGhi_chu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lookUpEdit);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 44);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm vật tư đang làm việc:";
            // 
            // lookUpEdit
            // 
            this.lookUpEdit.Location = new System.Drawing.Point(300, 17);
            this.lookUpEdit.Name = "lookUpEdit";
            this.lookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit.Size = new System.Drawing.Size(261, 20);
            this.lookUpEdit.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(143, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(151, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Lựa chọn nhóm vật tư làm việc:";
            // 
            // frmNhomVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmNhomVatTu";
            this.Text = "Danh sách nhóm vật tư";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhomVatTu_FormClosing);
            this.Load += new System.EventHandler(this.frmNhomVatTu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTONhomVatTuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleKhoVatTu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_nhom_vat_tu;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_chu;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colKho_vat_tu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleKhoVatTu;
        private System.Windows.Forms.BindingSource sTONhomVatTuBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_nhom_vat_tu;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;


    }
}