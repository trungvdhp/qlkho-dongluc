namespace QLK_DongLuc.Views.HeThong
{
    partial class frmCauHinh
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenMayChu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ledCoSoDuLieu = new DevExpress.XtraEditors.LookUpEdit();
            this.btnKetNoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnKiemTraKetNoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMayChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCoSoDuLieu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên máy chủ";
            // 
            // txtTenMayChu
            // 
            this.txtTenMayChu.Location = new System.Drawing.Point(108, 21);
            this.txtTenMayChu.Name = "txtTenMayChu";
            this.txtTenMayChu.Size = new System.Drawing.Size(212, 20);
            this.txtTenMayChu.TabIndex = 0;
            this.txtTenMayChu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenMayChu_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(108, 51);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(212, 20);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenDangNhap_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(58, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "";
            this.txtMatKhau.Location = new System.Drawing.Point(108, 81);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtMatKhau.Properties.Mask.EditMask = "[a-zA-Z0-9!#$%&\'()*+,-.:;<=>?@[\\\\\\]{}^_`|~]+";
            this.txtMatKhau.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMatKhau.Properties.MaxLength = 30;
            this.txtMatKhau.Properties.NullValuePrompt = "Nhập mật khẩu ít nhất là 6 ký tự";
            this.txtMatKhau.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(212, 20);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 146);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tên cơ sở dữ liệu";
            // 
            // ledCoSoDuLieu
            // 
            this.ledCoSoDuLieu.Location = new System.Drawing.Point(108, 143);
            this.ledCoSoDuLieu.Name = "ledCoSoDuLieu";
            this.ledCoSoDuLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledCoSoDuLieu.Properties.NullText = "";
            this.ledCoSoDuLieu.Size = new System.Drawing.Size(212, 20);
            this.ledCoSoDuLieu.TabIndex = 4;
            this.ledCoSoDuLieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ledCoSoDuLieu_KeyDown);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(108, 175);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(100, 25);
            this.btnKetNoi.TabIndex = 5;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(220, 175);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(100, 25);
            this.btnHuyBo.TabIndex = 6;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnKiemTraKetNoi
            // 
            this.btnKiemTraKetNoi.Location = new System.Drawing.Point(108, 107);
            this.btnKiemTraKetNoi.Name = "btnKiemTraKetNoi";
            this.btnKiemTraKetNoi.Size = new System.Drawing.Size(212, 25);
            this.btnKiemTraKetNoi.TabIndex = 3;
            this.btnKiemTraKetNoi.Text = "Kiểm tra kết nối đến máy chủ";
            this.btnKiemTraKetNoi.Click += new System.EventHandler(this.btnKiemTraKetNoi_Click);
            // 
            // frmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 214);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnKiemTraKetNoi);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.ledCoSoDuLieu);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtTenMayChu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmCauHinh";
            this.Text = "Cấu hình kết nối cơ sở dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMayChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCoSoDuLieu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenMayChu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit ledCoSoDuLieu;
        private DevExpress.XtraEditors.SimpleButton btnKetNoi;
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        private DevExpress.XtraEditors.SimpleButton btnKiemTraKetNoi;
    }
}