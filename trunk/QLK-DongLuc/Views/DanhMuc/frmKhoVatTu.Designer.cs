namespace QLK_DongLuc.Views.DanhMuc
{
    partial class frmKhoVatTu
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_diem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Ten_kho_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Dia_diem_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ID_kho_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKhoVatTuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten_kho_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dia_diem_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_kho_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // sTOKhoVatTuBindingSource
            // 
            this.sTOKhoVatTuBindingSource.DataSource = typeof(QLK_DongLuc.Models.STO_KhoVatTu);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.sTOKhoVatTuBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.Ten_kho_edit,
            this.Dia_diem_edit,
            this.ID_kho_edit});
            this.gridControl.Size = new System.Drawing.Size(784, 361);
            this.gridControl.TabIndex = 2;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl_KeyDown);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_kho,
            this.colTen_kho,
            this.colDia_diem});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.NewItemRowText = "Thêm mới dữ liệu tại đây";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.EnableAppearanceOddRow = true;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
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
            // 
            // colDia_diem
            // 
            this.colDia_diem.AppearanceHeader.Options.UseTextOptions = true;
            this.colDia_diem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDia_diem.Caption = "Địa điểm";
            this.colDia_diem.FieldName = "Dia_diem";
            this.colDia_diem.Name = "colDia_diem";
            this.colDia_diem.Visible = true;
            this.colDia_diem.VisibleIndex = 1;
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
            // frmKhoVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.gridControl);
            this.Name = "frmKhoVatTu";
            this.Text = "Danh sách kho vật tư";
            this.Load += new System.EventHandler(this.frmKhoVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTOKhoVatTuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten_kho_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dia_diem_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_kho_edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sTOKhoVatTuBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID_kho;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_kho;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_diem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Ten_kho_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Dia_diem_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ID_kho_edit;

    }
}