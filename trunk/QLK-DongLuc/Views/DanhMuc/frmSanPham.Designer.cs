namespace QLK_DongLuc.Views.DanhMuc
{
    partial class frmSanPham
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.cATSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_san_pham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_san_pham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_khach_hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleKhachHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colID_nhan_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleNhanVienKinhDoanh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colChi_phi_lap_dat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sedChiPhiLapDat = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cATKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleNhanVienKinhDoanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedChiPhiLapDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATNhanVienBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.cATSanPhamBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControl_EmbeddedNavigator_ButtonClick);
            this.gridControl.Location = new System.Drawing.Point(13, 63);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.sedChiPhiLapDat,
            this.rleKhachHang,
            this.rleNhanVienKinhDoanh});
            this.gridControl.Size = new System.Drawing.Size(758, 285);
            this.gridControl.TabIndex = 3;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.gridView1});
            this.gridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl_KeyDown);
            // 
            // cATSanPhamBindingSource
            // 
            this.cATSanPhamBindingSource.DataSource = typeof(QLK_DongLuc.Models.CAT_SanPham);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_san_pham,
            this.colTen_san_pham,
            this.colID_khach_hang,
            this.colID_nhan_vien,
            this.colChi_phi_lap_dat});
            this.gridView.GridControl = this.gridControl;
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
            // colMa_san_pham
            // 
            this.colMa_san_pham.Caption = "Mã sản phẩm";
            this.colMa_san_pham.FieldName = "Ma_san_pham";
            this.colMa_san_pham.Name = "colMa_san_pham";
            this.colMa_san_pham.Visible = true;
            this.colMa_san_pham.VisibleIndex = 0;
            // 
            // colTen_san_pham
            // 
            this.colTen_san_pham.Caption = "Tên sản phẩm";
            this.colTen_san_pham.FieldName = "Ten_san_pham";
            this.colTen_san_pham.Name = "colTen_san_pham";
            this.colTen_san_pham.Visible = true;
            this.colTen_san_pham.VisibleIndex = 1;
            // 
            // colID_khach_hang
            // 
            this.colID_khach_hang.Caption = "Khách hàng";
            this.colID_khach_hang.ColumnEdit = this.rleKhachHang;
            this.colID_khach_hang.FieldName = "ID_khach_hang";
            this.colID_khach_hang.Name = "colID_khach_hang";
            this.colID_khach_hang.Visible = true;
            this.colID_khach_hang.VisibleIndex = 2;
            // 
            // rleKhachHang
            // 
            this.rleKhachHang.AutoHeight = false;
            this.rleKhachHang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleKhachHang.Name = "rleKhachHang";
            // 
            // colID_nhan_vien
            // 
            this.colID_nhan_vien.Caption = "Nhân viên kinh doanh";
            this.colID_nhan_vien.ColumnEdit = this.rleNhanVienKinhDoanh;
            this.colID_nhan_vien.FieldName = "ID_nhan_vien";
            this.colID_nhan_vien.Name = "colID_nhan_vien";
            this.colID_nhan_vien.Visible = true;
            this.colID_nhan_vien.VisibleIndex = 3;
            // 
            // rleNhanVienKinhDoanh
            // 
            this.rleNhanVienKinhDoanh.AutoHeight = false;
            this.rleNhanVienKinhDoanh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleNhanVienKinhDoanh.Name = "rleNhanVienKinhDoanh";
            // 
            // colChi_phi_lap_dat
            // 
            this.colChi_phi_lap_dat.Caption = "Chi phí phụ";
            this.colChi_phi_lap_dat.ColumnEdit = this.sedChiPhiLapDat;
            this.colChi_phi_lap_dat.FieldName = "Chi_phi_lap_dat";
            this.colChi_phi_lap_dat.Name = "colChi_phi_lap_dat";
            this.colChi_phi_lap_dat.Visible = true;
            this.colChi_phi_lap_dat.VisibleIndex = 4;
            // 
            // sedChiPhiLapDat
            // 
            this.sedChiPhiLapDat.AutoHeight = false;
            this.sedChiPhiLapDat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.sedChiPhiLapDat.DisplayFormat.FormatString = "N0";
            this.sedChiPhiLapDat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sedChiPhiLapDat.EditFormat.FormatString = "N0";
            this.sedChiPhiLapDat.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sedChiPhiLapDat.Mask.EditMask = "N0";
            this.sedChiPhiLapDat.MaxValue = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.sedChiPhiLapDat.Name = "sedChiPhiLapDat";
            this.sedChiPhiLapDat.NullText = "0";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // cATKhachHangBindingSource
            // 
            this.cATKhachHangBindingSource.DataSource = typeof(QLK_DongLuc.Models.CAT_KhachHang);
            // 
            // cATNhanVienBindingSource
            // 
            this.cATNhanVienBindingSource.DataSource = typeof(QLK_DongLuc.Models.CAT_NhanVien);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 361);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chú thích:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(289, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "CN      : cửa nhựa\r\n";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(150, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "P      : cửa Postdoor\r\n";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(91, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(365, 26);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Mã sản phẩm:  (Cấu trúc: <Loại sản phẩm><Số thứ tự>, VD: P001, CN002)\r\nTrong đó: " +
    "\r\n";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSanPham";
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleNhanVienKinhDoanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedChiPhiLapDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATNhanVienBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource cATSanPhamBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_san_pham;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_san_pham;
        private DevExpress.XtraGrid.Columns.GridColumn colID_khach_hang;
        private System.Windows.Forms.BindingSource cATKhachHangBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID_nhan_vien;
        private DevExpress.XtraGrid.Columns.GridColumn colChi_phi_lap_dat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource cATNhanVienBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit sedChiPhiLapDat;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleKhachHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleNhanVienKinhDoanh;


    }
}