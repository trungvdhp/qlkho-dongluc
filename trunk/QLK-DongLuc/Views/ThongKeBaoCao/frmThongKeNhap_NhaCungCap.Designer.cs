namespace QLK_DongLuc.Views.ThongKeBaoCao
{
    partial class frmThongKeNhap_NhaCungCap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ledNhaCungCap = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.dteDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.dteTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.printControl = new DevExpress.XtraPrinting.Control.PrintControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ledNhaCungCap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.dteDenNgay);
            this.panel1.Controls.Add(this.dteTuNgay);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 37);
            this.panel1.TabIndex = 2;
            // 
            // ledNhaCungCap
            // 
            this.ledNhaCungCap.Location = new System.Drawing.Point(94, 9);
            this.ledNhaCungCap.Name = "ledNhaCungCap";
            this.ledNhaCungCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledNhaCungCap.Size = new System.Drawing.Size(116, 20);
            this.ledNhaCungCap.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nhà cung cấp:";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QLK_DongLuc.Properties.Resources.button_search;
            this.btnThoat.Location = new System.Drawing.Point(696, 9);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 20);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.ToolTip = "Tìm kiếm phiếu nhập theo ngày nhập kho";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::QLK_DongLuc.Properties.Resources.button_search;
            this.btnIn.Location = new System.Drawing.Point(615, 9);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 20);
            this.btnIn.TabIndex = 21;
            this.btnIn.Text = "In";
            this.btnIn.ToolTip = "Tìm kiếm phiếu nhập theo ngày nhập kho";
            this.btnIn.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dteDenNgay
            // 
            this.dteDenNgay.EditValue = new System.DateTime(2013, 6, 27, 9, 30, 22, 0);
            this.dteDenNgay.Location = new System.Drawing.Point(438, 9);
            this.dteDenNgay.Name = "dteDenNgay";
            this.dteDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDenNgay.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dteDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDenNgay.Properties.EditFormat.FormatString = "MM/dd/yyyy";
            this.dteDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteDenNgay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteDenNgay.Properties.NullDate = "";
            this.dteDenNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDenNgay.Size = new System.Drawing.Size(90, 20);
            this.dteDenNgay.TabIndex = 17;
            // 
            // dteTuNgay
            // 
            this.dteTuNgay.EditValue = new System.DateTime(2013, 6, 27, 9, 30, 22, 0);
            this.dteTuNgay.Location = new System.Drawing.Point(278, 9);
            this.dteTuNgay.Name = "dteTuNgay";
            this.dteTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dteTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteTuNgay.Properties.EditFormat.FormatString = "MM/dd/yyyy";
            this.dteTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteTuNgay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteTuNgay.Properties.NullDate = "";
            this.dteTuNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteTuNgay.Size = new System.Drawing.Size(90, 20);
            this.dteTuNgay.TabIndex = 16;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::QLK_DongLuc.Properties.Resources.button_search;
            this.btnTimKiem.Location = new System.Drawing.Point(534, 9);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 20);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Xem";
            this.btnTimKiem.ToolTip = "Tìm kiếm phiếu nhập theo ngày nhập kho";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Từ ngày:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.printControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 380);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // printControl
            // 
            this.printControl.BackColor = System.Drawing.Color.Empty;
            this.printControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printControl.ForeColor = System.Drawing.Color.Empty;
            this.printControl.IsMetric = false;
            this.printControl.Location = new System.Drawing.Point(3, 40);
            this.printControl.Name = "printControl";
            this.printControl.Size = new System.Drawing.Size(778, 337);
            this.printControl.TabIndex = 3;
            this.printControl.TooltipFont = new System.Drawing.Font("Tahoma", 8.25F);
            // 
            // frmThongKeNhap_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 380);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmThongKeNhap_NhaCungCap";
            this.Text = "Thống kê nhập theo nhà cung cấp";
            this.Load += new System.EventHandler(this.frmThongKeNhap_NhaCungCap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.DateEdit dteDenNgay;
        private DevExpress.XtraEditors.DateEdit dteTuNgay;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit ledNhaCungCap;
        private DevExpress.XtraPrinting.Control.PrintControl printControl;

    }
}