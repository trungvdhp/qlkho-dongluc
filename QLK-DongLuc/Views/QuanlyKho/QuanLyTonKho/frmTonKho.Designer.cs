namespace QLK_DongLuc.Views.QuanlyKho.QuanLyTonKho
{
	partial class frmTonKho
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
			this.btnLoadGrid = new DevExpress.XtraEditors.SimpleButton();
			this.ledLoaiVT = new DevExpress.XtraEditors.LookUpEdit();
			this.ledNhomVT = new DevExpress.XtraEditors.LookUpEdit();
			this.ledKhoVT = new DevExpress.XtraEditors.LookUpEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.gridTonKho = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ledLoaiVT.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ledNhomVT.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ledKhoVT.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridTonKho)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.gridTonKho, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.74046F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.25954F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 524);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.btnLoadGrid);
			this.panelControl1.Controls.Add(this.ledLoaiVT);
			this.panelControl1.Controls.Add(this.ledNhomVT);
			this.panelControl1.Controls.Add(this.ledKhoVT);
			this.panelControl1.Controls.Add(this.labelControl3);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Location = new System.Drawing.Point(3, 3);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(833, 66);
			this.panelControl1.TabIndex = 0;
			// 
			// btnLoadGrid
			// 
			this.btnLoadGrid.Location = new System.Drawing.Point(659, 18);
			this.btnLoadGrid.Name = "btnLoadGrid";
			this.btnLoadGrid.Size = new System.Drawing.Size(75, 23);
			this.btnLoadGrid.TabIndex = 3;
			this.btnLoadGrid.Text = "Load dữ liệu";
			this.btnLoadGrid.Click += new System.EventHandler(this.btnLoadGrid_Click);
			// 
			// ledLoaiVT
			// 
			this.ledLoaiVT.Location = new System.Drawing.Point(488, 21);
			this.ledLoaiVT.Name = "ledLoaiVT";
			this.ledLoaiVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ledLoaiVT.Size = new System.Drawing.Size(152, 20);
			this.ledLoaiVT.TabIndex = 2;
			// 
			// ledNhomVT
			// 
			this.ledNhomVT.Location = new System.Drawing.Point(272, 21);
			this.ledNhomVT.Name = "ledNhomVT";
			this.ledNhomVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ledNhomVT.Size = new System.Drawing.Size(152, 20);
			this.ledNhomVT.TabIndex = 2;
			this.ledNhomVT.TextChanged += new System.EventHandler(this.ledNhomVT_TextChanged);
			// 
			// ledKhoVT
			// 
			this.ledKhoVT.Location = new System.Drawing.Point(48, 21);
			this.ledKhoVT.Name = "ledKhoVT";
			this.ledKhoVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ledKhoVT.Size = new System.Drawing.Size(152, 20);
			this.ledKhoVT.TabIndex = 2;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(430, 24);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(52, 13);
			this.labelControl3.TabIndex = 1;
			this.labelControl3.Text = "Loại vật tư";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(206, 24);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(60, 13);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Nhóm vật tư";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(24, 24);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(18, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Kho";
			// 
			// gridTonKho
			// 
			this.gridTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridTonKho.Location = new System.Drawing.Point(3, 75);
			this.gridTonKho.MainView = this.gridView1;
			this.gridTonKho.Name = "gridTonKho";
			this.gridTonKho.Size = new System.Drawing.Size(833, 446);
			this.gridTonKho.TabIndex = 1;
			this.gridTonKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridTonKho;
			this.gridView1.Name = "gridView1";
			// 
			// frmTonKho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 524);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "frmTonKho";
			this.Text = "frmTonKho";
			this.Load += new System.EventHandler(this.frmTonKho_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ledLoaiVT.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ledNhomVT.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ledKhoVT.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridTonKho)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraGrid.GridControl gridTonKho;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.LookUpEdit ledLoaiVT;
		private DevExpress.XtraEditors.LookUpEdit ledNhomVT;
		private DevExpress.XtraEditors.LookUpEdit ledKhoVT;
		private DevExpress.XtraEditors.SimpleButton btnLoadGrid;
	}
}