namespace QLK_DongLuc.Views.HeThong
{
    partial class frmVaiTro
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
            this.grdVaiTro = new DevExpress.XtraGrid.GridControl();
            this.sYSVaiTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvVaiTro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTen_vai_tro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMo_ta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Ten_kho_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Dia_diem_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ID_kho_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdVaiTro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSVaiTroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVaiTro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten_kho_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dia_diem_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_kho_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdVaiTro
            // 
            this.grdVaiTro.DataSource = this.sYSVaiTroBindingSource;
            this.grdVaiTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVaiTro.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.grdVaiTro_EmbeddedNavigator_ButtonClick);
            this.grdVaiTro.Location = new System.Drawing.Point(0, 0);
            this.grdVaiTro.MainView = this.grvVaiTro;
            this.grdVaiTro.Name = "grdVaiTro";
            this.grdVaiTro.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.Ten_kho_edit,
            this.Dia_diem_edit,
            this.ID_kho_edit,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemGridLookUpEdit1});
            this.grdVaiTro.Size = new System.Drawing.Size(695, 407);
            this.grdVaiTro.TabIndex = 4;
            this.grdVaiTro.UseEmbeddedNavigator = true;
            this.grdVaiTro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvVaiTro});
            this.grdVaiTro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdVaiTro_KeyDown);
            // 
            // sYSVaiTroBindingSource
            // 
            this.sYSVaiTroBindingSource.DataSource = typeof(QLK_DongLuc.Models.SYS_VaiTro);
            // 
            // grvVaiTro
            // 
            this.grvVaiTro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTen_vai_tro,
            this.colMo_ta});
            this.grvVaiTro.GridControl = this.grdVaiTro;
            this.grvVaiTro.GroupPanelText = "Kéo tiêu đề cột vào đây để nhóm theo cột";
            this.grvVaiTro.Name = "grvVaiTro";
            this.grvVaiTro.NewItemRowText = "Thêm mới dữ liệu tại đây";
            this.grvVaiTro.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvVaiTro.OptionsNavigation.AutoFocusNewRow = true;
            this.grvVaiTro.OptionsView.EnableAppearanceOddRow = true;
            this.grvVaiTro.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvVaiTro.OptionsView.ShowGroupPanel = false;
            this.grvVaiTro.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView_InvalidRowException);
            this.grvVaiTro.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            // 
            // colTen_vai_tro
            // 
            this.colTen_vai_tro.Caption = "Tên vai trò";
            this.colTen_vai_tro.FieldName = "Ten_vai_tro";
            this.colTen_vai_tro.Name = "colTen_vai_tro";
            this.colTen_vai_tro.Visible = true;
            this.colTen_vai_tro.VisibleIndex = 0;
            // 
            // colMo_ta
            // 
            this.colMo_ta.Caption = "Mô tả";
            this.colMo_ta.FieldName = "Mo_ta";
            this.colMo_ta.Name = "colMo_ta";
            this.colMo_ta.Visible = true;
            this.colMo_ta.VisibleIndex = 1;
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
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Ten_nhom_vat_tu";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID_nhom_vat_tu";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Ten_nhom_vat_tu";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemGridLookUpEdit1.ValueMember = "ID_nhom_vat_tu";
            this.repositoryItemGridLookUpEdit1.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Danh sách nhóm vật tư";
            this.gridColumn1.FieldName = "Ten_nhom_vat_tu";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // frmVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 407);
            this.Controls.Add(this.grdVaiTro);
            this.Name = "frmVaiTro";
            this.Text = "Quản lý vai trò người dùng";
            this.Load += new System.EventHandler(this.frmVaiTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVaiTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSVaiTroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVaiTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten_kho_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dia_diem_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_kho_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdVaiTro;
        private System.Windows.Forms.BindingSource sYSVaiTroBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView grvVaiTro;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_vai_tro;
        private DevExpress.XtraGrid.Columns.GridColumn colMo_ta;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Ten_kho_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Dia_diem_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ID_kho_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}