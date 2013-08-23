namespace QLK_DongLuc.Views.DanhMuc
{
    partial class frmKhoVT
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
            this.sTOKhoVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grdKhoVatTu = new DevExpress.XtraGrid.GridControl();
            this.grvKhoVatTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_diem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Ten_kho_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Dia_diem_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ID_kho_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sTOKhoVatTuCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sTOKhoVatTuBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKhoVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhoVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten_kho_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dia_diem_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_kho_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKhoVatTuCTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.grdKhoVatTu, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(584, 361);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // grdKhoVatTu
            // 
            this.grdKhoVatTu.DataSource = this.sTOKhoVatTuBindingSource;
            this.grdKhoVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKhoVatTu.Location = new System.Drawing.Point(0, 50);
            this.grdKhoVatTu.MainView = this.grvKhoVatTu;
            this.grdKhoVatTu.Margin = new System.Windows.Forms.Padding(0);
            this.grdKhoVatTu.Name = "grdKhoVatTu";
            this.grdKhoVatTu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.Ten_kho_edit,
            this.Dia_diem_edit,
            this.ID_kho_edit});
            this.grdKhoVatTu.Size = new System.Drawing.Size(584, 311);
            this.grdKhoVatTu.TabIndex = 15;
            this.grdKhoVatTu.UseEmbeddedNavigator = true;
            this.grdKhoVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKhoVatTu});
            this.grdKhoVatTu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdKhoVatTu_KeyDown);
            // 
            // grvKhoVatTu
            // 
            this.grvKhoVatTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_kho,
            this.colTen_kho,
            this.colDia_diem});
            this.grvKhoVatTu.GridControl = this.grdKhoVatTu;
            this.grvKhoVatTu.Name = "grvKhoVatTu";
            this.grvKhoVatTu.NewItemRowText = "Thêm mới dữ liệu tại đây";
            this.grvKhoVatTu.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvKhoVatTu.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvKhoVatTu.OptionsNavigation.AutoFocusNewRow = true;
            this.grvKhoVatTu.OptionsView.EnableAppearanceOddRow = true;
            this.grvKhoVatTu.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvKhoVatTu.OptionsView.ShowGroupPanel = false;
            this.grvKhoVatTu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvKhoVatTu_FocusedRowChanged);
             this.grvKhoVatTu.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvKhoVatTu_ValidateRow);
            // 
            // colID_kho
            // 
            this.colID_kho.AppearanceHeader.Options.UseTextOptions = true;
            this.colID_kho.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID_kho.FieldName = "ID_kho";
            this.colID_kho.Name = "colID_kho";
            // 
            // colTen_kho
            // 
            this.colTen_kho.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_kho.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_kho.Caption = "Tên kho";
            this.colTen_kho.FieldName = "Ten_kho";
            this.colTen_kho.Name = "colTen_kho";
            this.colTen_kho.Visible = true;
            this.colTen_kho.VisibleIndex = 0;
            this.colTen_kho.Width = 188;
            // 
            // colDia_diem
            // 
            this.colDia_diem.AppearanceHeader.Options.UseTextOptions = true;
            this.colDia_diem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDia_diem.Caption = "Địa điểm";
            this.colDia_diem.FieldName = "Dia_diem";
            this.colDia_diem.Name = "colDia_diem";
            this.colDia_diem.OptionsFilter.AllowAutoFilter = false;
            this.colDia_diem.OptionsFilter.AllowFilter = false;
            this.colDia_diem.Visible = true;
            this.colDia_diem.VisibleIndex = 1;
            this.colDia_diem.Width = 188;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // Ten_kho_edit
            // 
            this.Ten_kho_edit.AutoHeight = false;
            this.Ten_kho_edit.Name = "Ten_kho_edit";
            // 
            // Dia_diem_edit
            // 
            this.Dia_diem_edit.AutoHeight = false;
            this.Dia_diem_edit.Name = "Dia_diem_edit";
            // 
            // ID_kho_edit
            // 
            this.ID_kho_edit.AutoHeight = false;
            this.ID_kho_edit.Name = "ID_kho_edit";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.lookUpEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(578, 44);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Kho vật tư đang làm việc";
            // 
            // lookUpEdit
            // 
            this.lookUpEdit.Location = new System.Drawing.Point(251, 22);
            this.lookUpEdit.Name = "lookUpEdit";
            this.lookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit.Size = new System.Drawing.Size(182, 20);
            this.lookUpEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(103, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(142, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lựa chọn kho vật tư làm việc:";
            // 
            // frmKhoVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmKhoVT";
            this.Text = "Danh sách kho vật tư";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhoVT_FormClosing);
            this.Load += new System.EventHandler(this.frmKhoVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTOKhoVatTuBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKhoVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhoVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten_kho_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dia_diem_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_kho_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKhoVatTuCTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sTOKhoVatTuBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraGrid.GridControl grdKhoVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKhoVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colID_kho;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_kho;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_diem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Ten_kho_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Dia_diem_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ID_kho_edit;
        private System.Windows.Forms.BindingSource sTOKhoVatTuCTBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}