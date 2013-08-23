namespace QLK_DongLuc
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.prgStatus = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.lblCopyright = new DevExpress.XtraEditors.LabelControl();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.prgStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // prgStatus
            // 
            this.prgStatus.EditValue = 0;
            this.prgStatus.Location = new System.Drawing.Point(23, 231);
            this.prgStatus.Name = "prgStatus";
            this.prgStatus.Properties.MarqueeAnimationSpeed = 200;
            this.prgStatus.Size = new System.Drawing.Size(404, 12);
            this.prgStatus.TabIndex = 5;
            // 
            // lblCopyright
            // 
            this.lblCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblCopyright.Location = new System.Drawing.Point(23, 286);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(121, 13);
            this.lblCopyright.TabIndex = 6;
            this.lblCopyright.Text = "Copyright © 2012 - 2013";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(23, 212);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(143, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Đang nạp dữ liệu khởi động...";
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.EditValue = ((object)(resources.GetObject("picLogo.EditValue")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Properties.AllowFocused = false;
            this.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Properties.Appearance.Options.UseBackColor = true;
            this.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogo.Properties.ShowMenu = false;
            this.picLogo.Size = new System.Drawing.Size(450, 320);
            this.picLogo.TabIndex = 9;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.prgStatus);
            this.Controls.Add(this.picLogo);
            this.Name = "frmSplashScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.prgStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl prgStatus;
        private DevExpress.XtraEditors.LabelControl lblCopyright;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.PictureEdit picLogo;
    }
}
