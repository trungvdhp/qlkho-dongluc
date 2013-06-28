namespace QLK_DongLuc.Views.QuanlyKho.QuanLyTonKho
{
	partial class frmTonDauKy
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
			this.dtTo = new DevExpress.XtraEditors.DateEdit();
			this.dtFrom = new DevExpress.XtraEditors.DateEdit();
			this.btnLoadGrid = new DevExpress.XtraEditors.SimpleButton();
			this.ledLoaiVT = new DevExpress.XtraEditors.LookUpEdit();
			this.ledTonDauKy = new DevExpress.XtraEditors.LookUpEdit();
			this.ledKhoVT = new DevExpress.XtraEditors.LookUpEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.gridTonKho = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ledLoaiVT.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ledTonDauKy.Properties)).BeginInit();
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
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51145F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.48855F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 524);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.dtTo);
			this.panelControl1.Controls.Add(this.dtFrom);
			this.panelControl1.Controls.Add(this.btnLoadGrid);
			this.panelControl1.Controls.Add(this.ledLoaiVT);
			this.panelControl1.Controls.Add(this.ledTonDauKy);
			this.panelControl1.Controls.Add(this.ledKhoVT);
			this.panelControl1.Controls.Add(this.labelControl3);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.labelControl5);
			this.panelControl1.Controls.Add(this.labelControl4);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(3, 3);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(833, 90);
			this.panelControl1.TabIndex = 0;
			// 
			// dtTo
			// 
			this.dtTo.EditValue = new System.DateTime(2013, 6, 28, 11, 57, 47, 481);
			this.dtTo.Location = new System.Drawing.Point(298, 9);
			this.dtTo.Name = "dtTo";
			this.dtTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtTo.Properties.Mask.EditMask = "D";
			this.dtTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.dtTo.Size = new System.Drawing.Size(152, 20);
			this.dtTo.TabIndex = 4;
			this.dtTo.EditValueChanged += new System.EventHandler(this.dateRang_EditValueChanged);
			// 
			// dtFrom
			// 
			this.dtFrom.EditValue = new System.DateTime(2013, 6, 28, 11, 57, 34, 257);
			this.dtFrom.Location = new System.Drawing.Point(74, 9);
			this.dtFrom.Name = "dtFrom";
			this.dtFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtFrom.Properties.Mask.EditMask = "D";
			this.dtFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.dtFrom.Size = new System.Drawing.Size(152, 20);
			this.dtFrom.TabIndex = 4;
			this.dtFrom.EditValueChanged += new System.EventHandler(this.dateRang_EditValueChanged);
			// 
			// btnLoadGrid
			// 
			this.btnLoadGrid.Location = new System.Drawing.Point(685, 32);
			this.btnLoadGrid.Name = "btnLoadGrid";
			this.btnLoadGrid.Size = new System.Drawing.Size(75, 23);
			this.btnLoadGrid.TabIndex = 3;
			this.btnLoadGrid.Text = "Load dữ liệu";
			this.btnLoadGrid.Click += new System.EventHandler(this.btnLoadGrid_Click);
			// 
			// ledLoaiVT
			// 
			this.ledLoaiVT.Location = new System.Drawing.Point(514, 35);
			this.ledLoaiVT.Name = "ledLoaiVT";
			this.ledLoaiVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ledLoaiVT.Size = new System.Drawing.Size(152, 20);
			this.ledLoaiVT.TabIndex = 2;
			// 
			// ledTonDauKy
			// 
			this.ledTonDauKy.Location = new System.Drawing.Point(298, 35);
			this.ledTonDauKy.Name = "ledTonDauKy";
			this.ledTonDauKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ledTonDauKy.Size = new System.Drawing.Size(152, 20);
			this.ledTonDauKy.TabIndex = 2;
			this.ledTonDauKy.EditValueChanged += new System.EventHandler(this.ledTonDauKy_EditValueChanged);
			// 
			// ledKhoVT
			// 
			this.ledKhoVT.Location = new System.Drawing.Point(74, 35);
			this.ledKhoVT.Name = "ledKhoVT";
			this.ledKhoVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ledKhoVT.Size = new System.Drawing.Size(152, 20);
			this.ledKhoVT.TabIndex = 2;
			this.ledKhoVT.EditValueChanged += new System.EventHandler(this.ledKhoVT_EditValueChanged);
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(456, 38);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(52, 13);
			this.labelControl3.TabIndex = 1;
			this.labelControl3.Text = "Loại vật tư";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(239, 38);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(53, 13);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Tồn đầu kỳ";
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(245, 12);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(47, 13);
			this.labelControl5.TabIndex = 1;
			this.labelControl5.Text = "Đến ngày";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(28, 12);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(40, 13);
			this.labelControl4.TabIndex = 1;
			this.labelControl4.Text = "Từ ngày";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(50, 38);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(18, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Kho";
			// 
			// gridTonKho
			// 
			this.gridTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridTonKho.Location = new System.Drawing.Point(3, 99);
			this.gridTonKho.MainView = this.gridView1;
			this.gridTonKho.Name = "gridTonKho";
			this.gridTonKho.Size = new System.Drawing.Size(833, 422);
			this.gridTonKho.TabIndex = 1;
			this.gridTonKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridTonKho;
			this.gridView1.Name = "gridView1";
			// 
			// frmTonDauKy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 524);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "frmTonDauKy";
			this.Text = "Tồn đầu kỳ";
			this.Load += new System.EventHandler(this.frmTonKho_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ledLoaiVT.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ledTonDauKy.Properties)).EndInit();
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
		private DevExpress.XtraEditors.LookUpEdit ledTonDauKy;
		private DevExpress.XtraEditors.LookUpEdit ledKhoVT;
		private DevExpress.XtraEditors.SimpleButton btnLoadGrid;
		private DevExpress.XtraEditors.DateEdit dtTo;
		private DevExpress.XtraEditors.DateEdit dtFrom;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl4;
	}
}