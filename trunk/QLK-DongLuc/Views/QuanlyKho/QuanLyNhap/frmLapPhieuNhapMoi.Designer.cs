namespace QLK_DongLuc.Views.QuanlyKho.QuanLyNhap
{
    partial class frmLapPhieuNhapMoi
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
            this.grdPhieuNhapCT = new DevExpress.XtraGrid.GridControl();
            this.iMPPhieuNhapCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvPhieuNhapCT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSo_luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDon_gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ledKhoNhap = new DevExpress.XtraEditors.LookUpEdit();
            this.ledNhanVienNhap = new DevExpress.XtraEditors.LookUpEdit();
            this.mmoGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnThemVatTuMoi = new DevExpress.XtraEditors.SimpleButton();
            this.ledNhaCungCap = new DevExpress.XtraEditors.LookUpEdit();
            this.dteNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.txtChungTuNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuNhapCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMPPhieuNhapCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuNhapCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledKhoNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhanVienNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayNhap.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChungTuNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grdPhieuNhapCT, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 488);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grdPhieuNhapCT
            // 
            this.grdPhieuNhapCT.DataSource = this.iMPPhieuNhapCTBindingSource;
            this.grdPhieuNhapCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPhieuNhapCT.Location = new System.Drawing.Point(3, 186);
            this.grdPhieuNhapCT.MainView = this.grvPhieuNhapCT;
            this.grdPhieuNhapCT.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.grdPhieuNhapCT.Name = "grdPhieuNhapCT";
            this.grdPhieuNhapCT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemSpinEdit1});
            this.grdPhieuNhapCT.Size = new System.Drawing.Size(784, 299);
            this.grdPhieuNhapCT.TabIndex = 2;
            this.grdPhieuNhapCT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPhieuNhapCT});
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
            this.colSo_luong,
            this.colDon_gia});
            this.grvPhieuNhapCT.GridControl = this.grdPhieuNhapCT;
            this.grvPhieuNhapCT.Name = "grvPhieuNhapCT";
            this.grvPhieuNhapCT.NewItemRowText = "Nhấn vào đây để thêm chi tiết phiếu nhập";
            this.grvPhieuNhapCT.OptionsCustomization.AllowFilter = false;
            this.grvPhieuNhapCT.OptionsCustomization.AllowGroup = false;
            this.grvPhieuNhapCT.OptionsCustomization.AllowSort = false;
            this.grvPhieuNhapCT.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.grvPhieuNhapCT.OptionsView.ShowGroupPanel = false;
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
            // colDon_gia
            // 
            this.colDon_gia.Caption = "Đơn giá";
            this.colDon_gia.FieldName = "Don_gia";
            this.colDon_gia.Name = "colDon_gia";
            this.colDon_gia.Visible = true;
            this.colDon_gia.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.btnLamLai);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 35);
            this.panelControl1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(237, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 25);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(85, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(70, 25);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(161, 5);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(70, 25);
            this.btnLamLai.TabIndex = 0;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(9, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 25);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(790, 145);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ledKhoNhap);
            this.groupControl1.Controls.Add(this.ledNhanVienNhap);
            this.groupControl1.Controls.Add(this.mmoGhiChu);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(389, 142);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin đối tượng nhập";
            // 
            // ledKhoNhap
            // 
            this.ledKhoNhap.Location = new System.Drawing.Point(95, 59);
            this.ledKhoNhap.Name = "ledKhoNhap";
            this.ledKhoNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledKhoNhap.Properties.NullText = "";
            this.ledKhoNhap.Size = new System.Drawing.Size(280, 20);
            this.ledKhoNhap.TabIndex = 1;
            // 
            // ledNhanVienNhap
            // 
            this.ledNhanVienNhap.Location = new System.Drawing.Point(95, 30);
            this.ledNhanVienNhap.Name = "ledNhanVienNhap";
            this.ledNhanVienNhap.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ledNhanVienNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledNhanVienNhap.Properties.NullText = "";
            this.ledNhanVienNhap.Size = new System.Drawing.Size(280, 20);
            this.ledNhanVienNhap.TabIndex = 1;
            // 
            // mmoGhiChu
            // 
            this.mmoGhiChu.Location = new System.Drawing.Point(95, 87);
            this.mmoGhiChu.Name = "mmoGhiChu";
            this.mmoGhiChu.Size = new System.Drawing.Size(280, 48);
            this.mmoGhiChu.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 92);
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnThemVatTuMoi);
            this.groupControl2.Controls.Add(this.ledNhaCungCap);
            this.groupControl2.Controls.Add(this.dteNgayNhap);
            this.groupControl2.Controls.Add(this.txtChungTuNhap);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(398, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(389, 142);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Thông tin chứng từ nhà cung cấp";
            // 
            // btnThemVatTuMoi
            // 
            this.btnThemVatTuMoi.Location = new System.Drawing.Point(94, 113);
            this.btnThemVatTuMoi.Name = "btnThemVatTuMoi";
            this.btnThemVatTuMoi.Size = new System.Drawing.Size(280, 25);
            this.btnThemVatTuMoi.TabIndex = 0;
            this.btnThemVatTuMoi.Text = "Thêm danh mục vật tư mới";
            this.btnThemVatTuMoi.Click += new System.EventHandler(this.btnThemVatTuMoi_Click);
            // 
            // ledNhaCungCap
            // 
            this.ledNhaCungCap.Location = new System.Drawing.Point(94, 58);
            this.ledNhaCungCap.Name = "ledNhaCungCap";
            this.ledNhaCungCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledNhaCungCap.Properties.NullText = "";
            this.ledNhaCungCap.Size = new System.Drawing.Size(280, 20);
            this.ledNhaCungCap.TabIndex = 1;
            // 
            // dteNgayNhap
            // 
            this.dteNgayNhap.EditValue = new System.DateTime(2013, 6, 27, 9, 30, 22, 0);
            this.dteNgayNhap.Location = new System.Drawing.Point(94, 87);
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
            this.dteNgayNhap.TabIndex = 5;
            // 
            // txtChungTuNhap
            // 
            this.txtChungTuNhap.Location = new System.Drawing.Point(94, 30);
            this.txtChungTuNhap.Name = "txtChungTuNhap";
            this.txtChungTuNhap.Size = new System.Drawing.Size(280, 20);
            this.txtChungTuNhap.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 90);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 13);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Ngày nhập";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 33);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Chứng từ nhập";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Nhà cung cấp";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.NullValuePrompt = "Nhập số lượng vật tư nhập";
            this.repositoryItemSpinEdit1.NullValuePromptShowForEmptyValue = true;
            // 
            // frmLapPhieuNhapMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLapPhieuNhapMoi";
            this.Text = "Lập phiếu nhập mới";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuNhapCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMPPhieuNhapCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuNhapCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledKhoNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhanVienNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayNhap.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChungTuNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnLamLai;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.GridControl grdPhieuNhapCT;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPhieuNhapCT;
        private DevExpress.XtraGrid.Columns.GridColumn colID_vat_tu;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_luong;
        private DevExpress.XtraGrid.Columns.GridColumn colDon_gia;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit ledNhanVienNhap;
        private DevExpress.XtraEditors.MemoEdit mmoGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.DateEdit dteNgayNhap;
        private DevExpress.XtraEditors.TextEdit txtChungTuNhap;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit ledKhoNhap;
        private DevExpress.XtraEditors.LookUpEdit ledNhaCungCap;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource iMPPhieuNhapCTBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnThemVatTuMoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
    }
}