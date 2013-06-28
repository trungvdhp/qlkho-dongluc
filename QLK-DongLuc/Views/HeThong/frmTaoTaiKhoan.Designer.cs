namespace QLK_DongLuc.Views.HeThong
{
    partial class frmTaoTaiKhoan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tedThoiGianCho = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhauXacNhan = new DevExpress.XtraEditors.TextEdit();
            this.chkKichHoatTaiKhoan = new DevExpress.XtraEditors.CheckEdit();
            this.ledNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDayDu = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkNhanVien = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnLamLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaoTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedThoiGianCho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauXacNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkKichHoatTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDayDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 224);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tedThoiGianCho);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtMatKhauXacNhan);
            this.panelControl1.Controls.Add(this.chkKichHoatTaiKhoan);
            this.panelControl1.Controls.Add(this.ledNhanVien);
            this.panelControl1.Controls.Add(this.txtMatKhau);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.txtTenDayDu);
            this.panelControl1.Controls.Add(this.txtTenDangNhap);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.chkNhanVien);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(382, 184);
            this.panelControl1.TabIndex = 0;
            // 
            // tedThoiGianCho
            // 
            this.tedThoiGianCho.EditValue = new System.DateTime(2013, 6, 28, 8, 0, 0, 0);
            this.tedThoiGianCho.Location = new System.Drawing.Point(110, 156);
            this.tedThoiGianCho.Name = "tedThoiGianCho";
            this.tedThoiGianCho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tedThoiGianCho.Properties.Mask.EditMask = "HH:mm";
            this.tedThoiGianCho.Size = new System.Drawing.Size(133, 20);
            this.tedThoiGianCho.TabIndex = 6;
            this.tedThoiGianCho.ToolTip = "Sau giờ:phút thì tài khoản đang đăng nhập sẽ tự động đăng xuất";
            this.tedThoiGianCho.Leave += new System.EventHandler(this.tedThoiGianCho_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 159);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Thời gian chờ";
            // 
            // txtMatKhauXacNhan
            // 
            this.txtMatKhauXacNhan.EditValue = "";
            this.txtMatKhauXacNhan.Location = new System.Drawing.Point(110, 125);
            this.txtMatKhauXacNhan.Name = "txtMatKhauXacNhan";
            this.txtMatKhauXacNhan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtMatKhauXacNhan.Properties.Mask.EditMask = "[a-zA-Z0-9!#$%&\'()*+,-.:;<=>?@[\\\\\\]{}^_`|~]+";
            this.txtMatKhauXacNhan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMatKhauXacNhan.Properties.MaxLength = 30;
            this.txtMatKhauXacNhan.Properties.NullValuePrompt = "Nhập lại mật khẩu";
            this.txtMatKhauXacNhan.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtMatKhauXacNhan.Properties.PasswordChar = '*';
            this.txtMatKhauXacNhan.Size = new System.Drawing.Size(254, 20);
            this.txtMatKhauXacNhan.TabIndex = 5;
            this.txtMatKhauXacNhan.Leave += new System.EventHandler(this.txtMatKhauXacNhan_Leave);
            // 
            // chkKichHoatTaiKhoan
            // 
            this.chkKichHoatTaiKhoan.EditValue = true;
            this.chkKichHoatTaiKhoan.Location = new System.Drawing.Point(249, 157);
            this.chkKichHoatTaiKhoan.Name = "chkKichHoatTaiKhoan";
            this.chkKichHoatTaiKhoan.Properties.Caption = "Kích hoạt tài khoản";
            this.chkKichHoatTaiKhoan.Size = new System.Drawing.Size(115, 19);
            this.chkKichHoatTaiKhoan.TabIndex = 7;
            // 
            // ledNhanVien
            // 
            this.ledNhanVien.Location = new System.Drawing.Point(110, 40);
            this.ledNhanVien.Name = "ledNhanVien";
            this.ledNhanVien.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ledNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledNhanVien.Properties.NullText = "";
            this.ledNhanVien.Properties.EditValueChanged += new System.EventHandler(this.ledNhanVienNhap_Properties_EditValueChanged);
            this.ledNhanVien.Size = new System.Drawing.Size(254, 20);
            this.ledNhanVien.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "";
            this.txtMatKhau.Location = new System.Drawing.Point(110, 99);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtMatKhau.Properties.Mask.EditMask = "[a-zA-Z0-9!#$%&\'()*+,-.:;<=>?@[\\\\\\]{}^_`|~]+";
            this.txtMatKhau.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMatKhau.Properties.MaxLength = 30;
            this.txtMatKhau.Properties.NullValuePrompt = "Nhập mật khẩu ít nhất là 6 ký tự";
            this.txtMatKhau.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(254, 20);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.ToolTip = "Mật khẩu mặc định là:1234a@";
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(19, 102);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Mật khẩu";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(19, 128);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(85, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Nhập lại mật khẩu";
            // 
            // txtTenDayDu
            // 
            this.txtTenDayDu.Location = new System.Drawing.Point(110, 66);
            this.txtTenDayDu.Name = "txtTenDayDu";
            this.txtTenDayDu.Properties.MaxLength = 50;
            this.txtTenDayDu.Properties.NullValuePrompt = "Nhập tên đầy đủ";
            this.txtTenDayDu.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTenDayDu.Size = new System.Drawing.Size(254, 20);
            this.txtTenDayDu.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtTenDangNhap.Location = new System.Drawing.Point(110, 14);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTenDangNhap.Properties.Mask.EditMask = "[a-zA-Z0-9_\\-\\.]+";
            this.txtTenDangNhap.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTenDangNhap.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTenDangNhap.Properties.MaxLength = 30;
            this.txtTenDangNhap.Properties.NullValuePrompt = "Nhập tên đăng nhập ít nhất 3 ký tự";
            this.txtTenDangNhap.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(254, 20);
            this.txtTenDangNhap.TabIndex = 0;
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTenDangNhap_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên đầy đủ";
            // 
            // chkNhanVien
            // 
            this.chkNhanVien.EditValue = true;
            this.chkNhanVien.Location = new System.Drawing.Point(17, 41);
            this.chkNhanVien.Name = "chkNhanVien";
            this.chkNhanVien.Properties.Caption = "Nhân viên";
            this.chkNhanVien.Size = new System.Drawing.Size(74, 19);
            this.chkNhanVien.TabIndex = 1;
            this.chkNhanVien.CheckedChanged += new System.EventHandler(this.chkNhanVien_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnLamLai);
            this.panelControl2.Controls.Add(this.btnTaoTaiKhoan);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 184);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(382, 40);
            this.panelControl2.TabIndex = 1;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(188, 7);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(85, 23);
            this.btnLamLai.TabIndex = 8;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(279, 7);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(85, 23);
            this.btnTaoTaiKhoan.TabIndex = 9;
            this.btnTaoTaiKhoan.Text = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 224);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaoTaiKhoan";
            this.Text = "Tạo tài khoản người dùng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTaoTaiKhoan_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedThoiGianCho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauXacNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkKichHoatTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDayDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TimeEdit tedThoiGianCho;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMatKhauXacNhan;
        private DevExpress.XtraEditors.CheckEdit chkKichHoatTaiKhoan;
        private DevExpress.XtraEditors.LookUpEdit ledNhanVien;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTenDayDu;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnTaoTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btnLamLai;
    }
}