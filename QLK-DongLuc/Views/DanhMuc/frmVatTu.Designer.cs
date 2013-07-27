namespace QLK_DongLuc.Views.DanhMuc
{
    partial class frmVatTu
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
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_loai_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleLoaiVatTu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colMa_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDon_vi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colMo_ta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.sTOVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleLoaiVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOVatTuBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_loai_vat_tu,
            this.colMa_vat_tu,
            this.colTen_vat_tu,
            this.colDon_vi,
            this.colMo_ta});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupPanelText = "Kéo tiêu đề cột vào đây để nhóm theo cột đó";
            this.gridView.Name = "gridView";
            this.gridView.NewItemRowText = "Thêm mới dữ liệu tại đây";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsView.EnableAppearanceOddRow = true;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView_InvalidRowException);
            this.gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            // 
            // colID_loai_vat_tu
            // 
            this.colID_loai_vat_tu.Caption = "Loại vật tư";
            this.colID_loai_vat_tu.ColumnEdit = this.rleLoaiVatTu;
            this.colID_loai_vat_tu.FieldName = "ID_loai_vat_tu";
            this.colID_loai_vat_tu.Name = "colID_loai_vat_tu";
            this.colID_loai_vat_tu.Visible = true;
            this.colID_loai_vat_tu.VisibleIndex = 0;
            // 
            // rleLoaiVatTu
            // 
            this.rleLoaiVatTu.AutoHeight = false;
            this.rleLoaiVatTu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleLoaiVatTu.Name = "rleLoaiVatTu";
            // 
            // colMa_vat_tu
            // 
            this.colMa_vat_tu.Caption = "Mã vật tư";
            this.colMa_vat_tu.FieldName = "Ma_vat_tu";
            this.colMa_vat_tu.Name = "colMa_vat_tu";
            this.colMa_vat_tu.Visible = true;
            this.colMa_vat_tu.VisibleIndex = 2;
            // 
            // colTen_vat_tu
            // 
            this.colTen_vat_tu.Caption = "Vật tư - Chủng loại";
            this.colTen_vat_tu.FieldName = "Ten_vat_tu";
            this.colTen_vat_tu.Name = "colTen_vat_tu";
            this.colTen_vat_tu.Visible = true;
            this.colTen_vat_tu.VisibleIndex = 1;
            // 
            // colDon_vi
            // 
            this.colDon_vi.Caption = "Khẩu độ";
            this.colDon_vi.ColumnEdit = this.repositoryItemSpinEdit2;
            this.colDon_vi.FieldName = "Don_vi";
            this.colDon_vi.Name = "colDon_vi";
            this.colDon_vi.Visible = true;
            this.colDon_vi.VisibleIndex = 3;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit2.MaxLength = 10;
            this.repositoryItemSpinEdit2.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            this.repositoryItemSpinEdit2.NullValuePrompt = "Nhập khẩu độ";
            this.repositoryItemSpinEdit2.NullValuePromptShowForEmptyValue = true;
            // 
            // colMo_ta
            // 
            this.colMo_ta.Caption = "Diễn giải";
            this.colMo_ta.FieldName = "Mo_ta";
            this.colMo_ta.Name = "colMo_ta";
            this.colMo_ta.Visible = true;
            this.colMo_ta.VisibleIndex = 4;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.sTOVatTuBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControl_EmbeddedNavigator_ButtonClick);
            this.gridControl.Location = new System.Drawing.Point(13, 83);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rleLoaiVatTu,
            this.repositoryItemSpinEdit2});
            this.gridControl.Size = new System.Drawing.Size(758, 265);
            this.gridControl.TabIndex = 3;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl_KeyDown);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 361);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chú thích:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(91, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(301, 26);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Chủng loại: là tên của vật tư (VD: Chốt nhựa, Chốt đồng,  ...) \r\n                " +
    "   hay chủng loại của Nan cửa (VD: L1.0, L1.2, ...)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nếu là vật tư thì không cần nhập khẩu độ, ngược lại\r\nNếu là chủng loại của Nan củ" +
    "a thì phải nhập khẩu độ (3.2, 3.3, ...)";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(91, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(264, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Diễn giải: là ghi chú, giải thích về  vật tư hay chủng loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "(Bắt buộc phải nhập)";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(91, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(303, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Loại vật tư: là tên của loại vật tư (VD: Chốt, Nan cửa cuốn ...) ";
            // 
            // frmVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmVatTu";
            this.Text = "Danh sách vật tư - chủng loại";
            this.Load += new System.EventHandler(this.frmVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleLoaiVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOVatTuBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_loai_vat_tu;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_vat_tu;
        private DevExpress.XtraGrid.Columns.GridColumn colDon_vi;
        private DevExpress.XtraGrid.Columns.GridColumn colMo_ta;
        private System.Windows.Forms.BindingSource sTOVatTuBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_vat_tu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleLoaiVatTu;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;


    }
}