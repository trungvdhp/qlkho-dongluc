namespace QLK_DongLuc.Views.QuanlyKho.QuanLyNhap
{
    partial class frmNhapLai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapLai));
            this.grdPhieuNhapCT = new DevExpress.XtraGrid.GridControl();
            this.iMPPhieuNhapCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvPhieuNhapCT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSo_luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.pnlCommandButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnXacThuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.tblLapPhieuNhapMoi = new System.Windows.Forms.TableLayoutPanel();
            this.grbThongTinDoiTuongNhap = new DevExpress.XtraEditors.GroupControl();
            this.ledKhoNhap = new DevExpress.XtraEditors.LookUpEdit();
            this.ledNhanVienNhap = new DevExpress.XtraEditors.LookUpEdit();
            this.mmoGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dteNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuNhapCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMPPhieuNhapCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuNhapCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCommandButtons)).BeginInit();
            this.pnlCommandButtons.SuspendLayout();
            this.tblLapPhieuNhapMoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbThongTinDoiTuongNhap)).BeginInit();
            this.grbThongTinDoiTuongNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledKhoNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhanVienNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayNhap.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPhieuNhapCT
            // 
            this.grdPhieuNhapCT.DataSource = this.iMPPhieuNhapCTBindingSource;
            this.grdPhieuNhapCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPhieuNhapCT.Location = new System.Drawing.Point(3, 148);
            this.grdPhieuNhapCT.MainView = this.grvPhieuNhapCT;
            this.grdPhieuNhapCT.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.grdPhieuNhapCT.Name = "grdPhieuNhapCT";
            this.grdPhieuNhapCT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemSpinEdit1});
            this.grdPhieuNhapCT.Size = new System.Drawing.Size(769, 309);
            this.grdPhieuNhapCT.TabIndex = 2;
            this.grdPhieuNhapCT.Tag = "Lưới nhập các chi tiết vật tư của phiếu nhập mới";
            this.grdPhieuNhapCT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPhieuNhapCT});
            this.grdPhieuNhapCT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdPhieuNhapCT_KeyDown);
            // 
            // iMPPhieuNhapCTBindingSource
            // 
            this.iMPPhieuNhapCTBindingSource.DataSource = typeof(QLK_DongLuc.Models.IMP_PhieuNhapCT);
            // 
            // grvPhieuNhapCT
            // 
            this.grvPhieuNhapCT.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grvPhieuNhapCT.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvPhieuNhapCT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_vat_tu,
            this.colSo_luong});
            this.grvPhieuNhapCT.GridControl = this.grdPhieuNhapCT;
            this.grvPhieuNhapCT.Name = "grvPhieuNhapCT";
            this.grvPhieuNhapCT.NewItemRowText = "Nhấn vào đây để thêm chi tiết phiếu nhập";
            this.grvPhieuNhapCT.OptionsCustomization.AllowFilter = false;
            this.grvPhieuNhapCT.OptionsCustomization.AllowGroup = false;
            this.grvPhieuNhapCT.OptionsCustomization.AllowSort = false;
            this.grvPhieuNhapCT.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvPhieuNhapCT.OptionsView.ShowGroupPanel = false;
            this.grvPhieuNhapCT.Tag = "Khung nhìn các chi tiết vật tư của phiếu nhập mới";
            this.grvPhieuNhapCT.ViewCaption = "Phiếu nhập chi tiết";
            this.grvPhieuNhapCT.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvPhieuNhapCT_ValidateRow);
            // 
            // colID_vat_tu
            // 
            this.colID_vat_tu.Caption = "Vật tư";
            this.colID_vat_tu.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colID_vat_tu.FieldName = "ID_vat_tu";
            this.colID_vat_tu.Name = "colID_vat_tu";
            this.colID_vat_tu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colID_vat_tu.Visible = true;
            this.colID_vat_tu.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // colSo_luong
            // 
            this.colSo_luong.Caption = "Số lượng";
            this.colSo_luong.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colSo_luong.FieldName = "So_luong";
            this.colSo_luong.Name = "colSo_luong";
            this.colSo_luong.Visible = true;
            this.colSo_luong.VisibleIndex = 1;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.DisplayFormat.FormatString = "N2";
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatString = "N2";
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit1.Mask.EditMask = "N2";
            this.repositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemSpinEdit1.MaxLength = 12;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            1215752192,
            23,
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
            // pnlCommandButtons
            // 
            this.pnlCommandButtons.Controls.Add(this.btnXacThuc);
            this.pnlCommandButtons.Controls.Add(this.btnThoat);
            this.pnlCommandButtons.Controls.Add(this.btnIn);
            this.pnlCommandButtons.Controls.Add(this.btnLamLai);
            this.pnlCommandButtons.Controls.Add(this.btnLuu);
            this.pnlCommandButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommandButtons.Location = new System.Drawing.Point(3, 3);
            this.pnlCommandButtons.Name = "pnlCommandButtons";
            this.pnlCommandButtons.Size = new System.Drawing.Size(769, 35);
            this.pnlCommandButtons.TabIndex = 3;
            this.pnlCommandButtons.Tag = "Cácthao tác";
            // 
            // btnXacThuc
            // 
            this.btnXacThuc.Image = global::QLK_DongLuc.Properties.Resources.button_accept;
            this.btnXacThuc.Location = new System.Drawing.Point(85, 5);
            this.btnXacThuc.Name = "btnXacThuc";
            this.btnXacThuc.Size = new System.Drawing.Size(75, 25);
            this.btnXacThuc.TabIndex = 5;
            this.btnXacThuc.Text = "Xác thực";
            this.btnXacThuc.Click += new System.EventHandler(this.btnXacThuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(319, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 25);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(166, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(70, 25);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Image = ((System.Drawing.Image)(resources.GetObject("btnLamLai.Image")));
            this.btnLamLai.Location = new System.Drawing.Point(242, 5);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(70, 25);
            this.btnLamLai.TabIndex = 3;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(9, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 25);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tblLapPhieuNhapMoi
            // 
            this.tblLapPhieuNhapMoi.ColumnCount = 1;
            this.tblLapPhieuNhapMoi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLapPhieuNhapMoi.Controls.Add(this.grbThongTinDoiTuongNhap, 0, 1);
            this.tblLapPhieuNhapMoi.Controls.Add(this.grdPhieuNhapCT, 0, 2);
            this.tblLapPhieuNhapMoi.Controls.Add(this.pnlCommandButtons, 0, 0);
            this.tblLapPhieuNhapMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLapPhieuNhapMoi.Location = new System.Drawing.Point(0, 0);
            this.tblLapPhieuNhapMoi.Name = "tblLapPhieuNhapMoi";
            this.tblLapPhieuNhapMoi.RowCount = 3;
            this.tblLapPhieuNhapMoi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tblLapPhieuNhapMoi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tblLapPhieuNhapMoi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLapPhieuNhapMoi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLapPhieuNhapMoi.Size = new System.Drawing.Size(775, 460);
            this.tblLapPhieuNhapMoi.TabIndex = 1;
            this.tblLapPhieuNhapMoi.Tag = "Bảng khung bố trí các nhóm dữ liệu nhập";
            // 
            // grbThongTinDoiTuongNhap
            // 
            this.grbThongTinDoiTuongNhap.Controls.Add(this.dteNgayNhap);
            this.grbThongTinDoiTuongNhap.Controls.Add(this.labelControl7);
            this.grbThongTinDoiTuongNhap.Controls.Add(this.ledKhoNhap);
            this.grbThongTinDoiTuongNhap.Controls.Add(this.ledNhanVienNhap);
            this.grbThongTinDoiTuongNhap.Controls.Add(this.mmoGhiChu);
            this.grbThongTinDoiTuongNhap.Controls.Add(this.labelControl4);
            this.grbThongTinDoiTuongNhap.Controls.Add(this.labelControl3);
            this.grbThongTinDoiTuongNhap.Controls.Add(this.labelControl2);
            this.grbThongTinDoiTuongNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTinDoiTuongNhap.Location = new System.Drawing.Point(3, 41);
            this.grbThongTinDoiTuongNhap.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.grbThongTinDoiTuongNhap.Name = "grbThongTinDoiTuongNhap";
            this.grbThongTinDoiTuongNhap.Size = new System.Drawing.Size(769, 104);
            this.grbThongTinDoiTuongNhap.TabIndex = 4;
            this.grbThongTinDoiTuongNhap.Text = "Thông tin đối tượng nhập";
            // 
            // ledKhoNhap
            // 
            this.ledKhoNhap.Location = new System.Drawing.Point(95, 59);
            this.ledKhoNhap.Name = "ledKhoNhap";
            this.ledKhoNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledKhoNhap.Properties.NullText = "";
            this.ledKhoNhap.Properties.NullValuePrompt = "Chọn kho nhập";
            this.ledKhoNhap.Properties.NullValuePromptShowForEmptyValue = true;
            this.ledKhoNhap.Size = new System.Drawing.Size(280, 20);
            this.ledKhoNhap.TabIndex = 2;
            // 
            // ledNhanVienNhap
            // 
            this.ledNhanVienNhap.Location = new System.Drawing.Point(95, 30);
            this.ledNhanVienNhap.Name = "ledNhanVienNhap";
            this.ledNhanVienNhap.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ledNhanVienNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledNhanVienNhap.Properties.NullText = "";
            this.ledNhanVienNhap.Properties.NullValuePrompt = "Chọn nhân viên nhập";
            this.ledNhanVienNhap.Properties.NullValuePromptShowForEmptyValue = true;
            this.ledNhanVienNhap.Size = new System.Drawing.Size(280, 20);
            this.ledNhanVienNhap.TabIndex = 1;
            // 
            // mmoGhiChu
            // 
            this.mmoGhiChu.Location = new System.Drawing.Point(468, 59);
            this.mmoGhiChu.Name = "mmoGhiChu";
            this.mmoGhiChu.Size = new System.Drawing.Size(280, 40);
            this.mmoGhiChu.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(401, 62);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ghi chú";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Kho nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nhân viên nhập";
            // 
            // dteNgayNhap
            // 
            this.dteNgayNhap.EditValue = new System.DateTime(2013, 6, 27, 9, 30, 22, 0);
            this.dteNgayNhap.Location = new System.Drawing.Point(468, 30);
            this.dteNgayNhap.Name = "dteNgayNhap";
            this.dteNgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayNhap.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dteNgayNhap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteNgayNhap.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.dteNgayNhap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteNgayNhap.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dteNgayNhap.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteNgayNhap.Properties.NullDate = "";
            this.dteNgayNhap.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteNgayNhap.Size = new System.Drawing.Size(280, 20);
            this.dteNgayNhap.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(401, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Ngày nhập";
            // 
            // frmLapPhieuNhapLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 460);
            this.Controls.Add(this.tblLapPhieuNhapMoi);
            this.Name = "frmLapPhieuNhapLai";
            this.Text = "Lập phiếu nhập lại";
            this.Load += new System.EventHandler(this.frmLapPhieuNhapLai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuNhapCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMPPhieuNhapCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuNhapCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCommandButtons)).EndInit();
            this.pnlCommandButtons.ResumeLayout(false);
            this.tblLapPhieuNhapMoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbThongTinDoiTuongNhap)).EndInit();
            this.grbThongTinDoiTuongNhap.ResumeLayout(false);
            this.grbThongTinDoiTuongNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledKhoNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhanVienNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayNhap.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayNhap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdPhieuNhapCT;
        private System.Windows.Forms.BindingSource iMPPhieuNhapCTBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPhieuNhapCT;
        private DevExpress.XtraGrid.Columns.GridColumn colID_vat_tu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_luong;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.PanelControl pnlCommandButtons;
        private DevExpress.XtraEditors.SimpleButton btnXacThuc;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnLamLai;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.TableLayoutPanel tblLapPhieuNhapMoi;
        private DevExpress.XtraEditors.GroupControl grbThongTinDoiTuongNhap;
        private DevExpress.XtraEditors.LookUpEdit ledKhoNhap;
        private DevExpress.XtraEditors.LookUpEdit ledNhanVienNhap;
        private DevExpress.XtraEditors.MemoEdit mmoGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dteNgayNhap;
        private DevExpress.XtraEditors.LabelControl labelControl7;


    }
}