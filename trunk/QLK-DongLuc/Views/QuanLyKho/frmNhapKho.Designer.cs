namespace QLK_DongLuc.Views.QuanLyKho
{
    partial class frmNhapKho
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
            this.colDonGia_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colMaLoai_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colMaKho_Exit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDonVi_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhomVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenVatTu_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTenVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataGrid = new DevExpress.XtraGrid.GridControl();
            this.colSoLuong_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.colDonGia_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colMaLoai_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colMaKho_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colDonVi_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colTenVatTu_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colSoLuong_Edit)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colDonGia_Edit
            // 
            this.colDonGia_Edit.AutoHeight = false;
            this.colDonGia_Edit.Name = "colDonGia_Edit";
            // 
            // colMaLoai_Edit
            // 
            this.colMaLoai_Edit.AutoHeight = false;
            this.colMaLoai_Edit.Name = "colMaLoai_Edit";
            // 
            // colMaKho_Exit
            // 
            this.colMaKho_Exit.AutoHeight = false;
            this.colMaKho_Exit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colMaKho_Exit.Name = "colMaKho_Exit";
            // 
            // colDonVi_Edit
            // 
            this.colDonVi_Edit.AutoHeight = false;
            this.colDonVi_Edit.Name = "colDonVi_Edit";
            // 
            // colDonVi
            // 
            this.colDonVi.Caption = "Đơn vị";
            this.colDonVi.ColumnEdit = this.colDonVi_Edit;
            this.colDonVi.FieldName = "DonVi";
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.Visible = true;
            this.colDonVi.VisibleIndex = 5;
            this.colDonVi.Width = 188;
            // 
            // colMaLoai
            // 
            this.colMaLoai.Caption = "Loại vật tư";
            this.colMaLoai.FieldName = "TenLoai";
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.Visible = true;
            this.colMaLoai.VisibleIndex = 3;
            this.colMaLoai.Width = 134;
            // 
            // colNhomVatTu
            // 
            this.colNhomVatTu.Caption = "Nhóm vật tư";
            this.colNhomVatTu.FieldName = "TenNhom";
            this.colNhomVatTu.Name = "colNhomVatTu";
            this.colNhomVatTu.Visible = true;
            this.colNhomVatTu.VisibleIndex = 2;
            this.colNhomVatTu.Width = 145;
            // 
            // colTenVatTu_Edit
            // 
            this.colTenVatTu_Edit.AutoHeight = false;
            this.colTenVatTu_Edit.Name = "colTenVatTu_Edit";
            // 
            // colTenVatTu
            // 
            this.colTenVatTu.Caption = "Tên vật tư";
            this.colTenVatTu.ColumnEdit = this.colTenVatTu_Edit;
            this.colTenVatTu.FieldName = "TenVatTu";
            this.colTenVatTu.Name = "colTenVatTu";
            this.colTenVatTu.Visible = true;
            this.colTenVatTu.VisibleIndex = 4;
            this.colTenVatTu.Width = 232;
            // 
            // colMaVatTu
            // 
            this.colMaVatTu.Caption = "Mã vật tư";
            this.colMaVatTu.FieldName = "MaVatTu";
            this.colMaVatTu.Name = "colMaVatTu";
            // 
            // colMaKho
            // 
            this.colMaKho.Caption = "Kho mặc định";
            this.colMaKho.FieldName = "TenKho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.Visible = true;
            this.colMaKho.VisibleIndex = 1;
            this.colMaKho.Width = 169;
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 92;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMaKho,
            this.colMaVatTu,
            this.colTenVatTu,
            this.colNhomVatTu,
            this.colMaLoai,
            this.colDonVi});
            this.gridView1.GridControl = this.dataGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // dataGrid
            // 
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 193);
            this.dataGrid.MainView = this.gridView1;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colTenVatTu_Edit,
            this.colMaKho_Exit,
            this.colMaLoai_Edit,
            this.colSoLuong_Edit,
            this.colDonVi_Edit,
            this.colDonGia_Edit});
            this.dataGrid.Size = new System.Drawing.Size(978, 225);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // colSoLuong_Edit
            // 
            this.colSoLuong_Edit.AutoHeight = false;
            this.colSoLuong_Edit.Name = "colSoLuong_Edit";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGrid, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 461);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnSua);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(978, 34);
            this.panelControl1.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(271, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 25);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(146, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 25);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(28, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 25);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 43);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(978, 144);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin Nhà cung cấp";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(974, 121);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhapKho";
            this.Text = "Chức năng nhập kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.colDonGia_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colMaLoai_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colMaKho_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colDonVi_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colTenVatTu_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colSoLuong_Edit)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colDonGia_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colMaLoai_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox colMaKho_Exit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colDonVi_Edit;
        private DevExpress.XtraGrid.Columns.GridColumn colDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomVatTu;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colTenVatTu_Edit;
        private DevExpress.XtraGrid.Columns.GridColumn colTenVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dataGrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colSoLuong_Edit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}