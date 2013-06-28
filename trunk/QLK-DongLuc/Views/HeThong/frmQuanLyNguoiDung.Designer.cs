namespace QLK_DongLuc.Views.HeThong
{
    partial class frmQuanLyNguoiDung
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
            this.grdNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.viewNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTai_khoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_day_du = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhan_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLan_dang_nhap_cuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colThoi_gian_cho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrang_thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSetTimeOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.btnKhoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_phieu_nhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMP_PhieuNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTO_VatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grdNguoiDung, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 441);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // grdNguoiDung
            // 
            this.grdNguoiDung.DataSource = this.viewNguoiDungBindingSource;
            this.grdNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNguoiDung.Location = new System.Drawing.Point(3, 40);
            this.grdNguoiDung.MainView = this.grvNguoiDung;
            this.grdNguoiDung.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.grdNguoiDung.Name = "grdNguoiDung";
            this.grdNguoiDung.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemDateEdit1});
            this.grdNguoiDung.Size = new System.Drawing.Size(849, 398);
            this.grdNguoiDung.TabIndex = 11;
            this.grdNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNguoiDung});
            // 
            // viewNguoiDungBindingSource
            // 
            this.viewNguoiDungBindingSource.DataSource = typeof(QLK_DongLuc.Models.ViewNguoiDung);
            // 
            // grvNguoiDung
            // 
            this.grvNguoiDung.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grvNguoiDung.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTai_khoan,
            this.colTen_day_du,
            this.colNhan_vien,
            this.colLan_dang_nhap_cuoi,
            this.colThoi_gian_cho,
            this.colTrang_thai});
            this.grvNguoiDung.GridControl = this.grdNguoiDung;
            this.grvNguoiDung.GroupPanelText = "Kéo tiêu đề cột vào đây để nhóm theo cột đó";
            this.grvNguoiDung.Name = "grvNguoiDung";
            this.grvNguoiDung.NewItemRowText = "Nhấn vào đây để thêm người dùng";
            this.grvNguoiDung.OptionsBehavior.AutoExpandAllGroups = true;
            this.grvNguoiDung.OptionsBehavior.Editable = false;
            this.grvNguoiDung.OptionsView.ShowAutoFilterRow = true;
            // 
            // colTai_khoan
            // 
            this.colTai_khoan.Caption = "Tên đăng nhập";
            this.colTai_khoan.FieldName = "Tai_khoan";
            this.colTai_khoan.Name = "colTai_khoan";
            this.colTai_khoan.Visible = true;
            this.colTai_khoan.VisibleIndex = 0;
            // 
            // colTen_day_du
            // 
            this.colTen_day_du.Caption = "Tên đầy đủ";
            this.colTen_day_du.FieldName = "Ten_day_du";
            this.colTen_day_du.Name = "colTen_day_du";
            this.colTen_day_du.Visible = true;
            this.colTen_day_du.VisibleIndex = 1;
            // 
            // colNhan_vien
            // 
            this.colNhan_vien.Caption = "Nhân viên";
            this.colNhan_vien.FieldName = "Nhan_vien";
            this.colNhan_vien.Name = "colNhan_vien";
            this.colNhan_vien.Visible = true;
            this.colNhan_vien.VisibleIndex = 2;
            // 
            // colLan_dang_nhap_cuoi
            // 
            this.colLan_dang_nhap_cuoi.Caption = "Lần đăng nhập cuối";
            this.colLan_dang_nhap_cuoi.ColumnEdit = this.repositoryItemDateEdit1;
            this.colLan_dang_nhap_cuoi.FieldName = "Lan_dang_nhap_cuoi";
            this.colLan_dang_nhap_cuoi.Name = "colLan_dang_nhap_cuoi";
            this.colLan_dang_nhap_cuoi.Visible = true;
            this.colLan_dang_nhap_cuoi.VisibleIndex = 3;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colThoi_gian_cho
            // 
            this.colThoi_gian_cho.Caption = "Thời gian chờ";
            this.colThoi_gian_cho.FieldName = "Thoi_gian_cho";
            this.colThoi_gian_cho.Name = "colThoi_gian_cho";
            this.colThoi_gian_cho.Visible = true;
            this.colThoi_gian_cho.VisibleIndex = 4;
            // 
            // colTrang_thai
            // 
            this.colTrang_thai.Caption = "Trạng thái";
            this.colTrang_thai.FieldName = "Trang_thai";
            this.colTrang_thai.Name = "colTrang_thai";
            this.colTrang_thai.Visible = true;
            this.colTrang_thai.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemSpinEdit1.MaxLength = 20;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.NullText = "1";
            this.repositoryItemSpinEdit1.NullValuePrompt = "Nhập số lượng vật tư nhập";
            this.repositoryItemSpinEdit1.NullValuePromptShowForEmptyValue = true;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit2.IsFloatValue = false;
            this.repositoryItemSpinEdit2.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSetTimeOut);
            this.panelControl1.Controls.Add(this.btnMoTaiKhoan);
            this.panelControl1.Controls.Add(this.btnKhoa);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.btnSua);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(855, 40);
            this.panelControl1.TabIndex = 12;
            // 
            // btnSetTimeOut
            // 
            this.btnSetTimeOut.Location = new System.Drawing.Point(376, 8);
            this.btnSetTimeOut.Name = "btnSetTimeOut";
            this.btnSetTimeOut.Size = new System.Drawing.Size(152, 25);
            this.btnSetTimeOut.TabIndex = 7;
            this.btnSetTimeOut.Text = "Hẹn giờ tự động đăng xuất";
            this.btnSetTimeOut.Visible = false;
            // 
            // btnMoTaiKhoan
            // 
            this.btnMoTaiKhoan.Location = new System.Drawing.Point(285, 8);
            this.btnMoTaiKhoan.Name = "btnMoTaiKhoan";
            this.btnMoTaiKhoan.Size = new System.Drawing.Size(85, 25);
            this.btnMoTaiKhoan.TabIndex = 7;
            this.btnMoTaiKhoan.Text = "Mở tài khoản";
            this.btnMoTaiKhoan.Click += new System.EventHandler(this.btnMoTaiKhoan_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Location = new System.Drawing.Point(194, 8);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(85, 25);
            this.btnKhoa.TabIndex = 7;
            this.btnKhoa.Text = "Khóa tài khoản";
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 25);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Tạo tài khoản";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(103, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 25);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa tài khoản";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_phieu_nhap,
            this.colIMP_PhieuNhap,
            this.colSTO_VatTu});
            this.gridView1.Name = "gridView1";
            // 
            // colID_phieu_nhap
            // 
            this.colID_phieu_nhap.FieldName = "ID_phieu_nhap";
            this.colID_phieu_nhap.Name = "colID_phieu_nhap";
            this.colID_phieu_nhap.Visible = true;
            this.colID_phieu_nhap.VisibleIndex = 3;
            // 
            // colIMP_PhieuNhap
            // 
            this.colIMP_PhieuNhap.FieldName = "IMP_PhieuNhap";
            this.colIMP_PhieuNhap.Name = "colIMP_PhieuNhap";
            this.colIMP_PhieuNhap.Visible = true;
            this.colIMP_PhieuNhap.VisibleIndex = 4;
            // 
            // colSTO_VatTu
            // 
            this.colSTO_VatTu.FieldName = "STO_VatTu";
            this.colSTO_VatTu.Name = "colSTO_VatTu";
            this.colSTO_VatTu.Visible = true;
            this.colSTO_VatTu.VisibleIndex = 5;
            // 
            // frmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmQuanLyNguoiDung";
            this.Text = "Quản lý người dùng";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl grdNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView grvNguoiDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_phieu_nhap;
        private DevExpress.XtraGrid.Columns.GridColumn colIMP_PhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colSTO_VatTu;
        private System.Windows.Forms.BindingSource viewNguoiDungBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTai_khoan;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_day_du;
        private DevExpress.XtraGrid.Columns.GridColumn colNhan_vien;
        private DevExpress.XtraGrid.Columns.GridColumn colLan_dang_nhap_cuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colThoi_gian_cho;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colTrang_thai;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKhoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnMoTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btnSetTimeOut;

    }
}