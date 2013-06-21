using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using QLK_DongLuc.Views.DanhMuc;
using QLK_DongLuc.Views.QuanLyKho;


namespace QLK_DongLuc
{
    public partial class frmMain : XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            //Khởi tạo skin
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void OpenForm(DevExpress.XtraEditors.XtraForm frm, DevExpress.XtraTab.XtraTabControl XTabControl)
        {
            foreach (DevExpress.XtraTab.XtraTabPage tab in tabControl.TabPages)
            {
                if (tab.Text == frm.Text)
                {
                    tabControl.SelectedTabPage = tab;
                    return;
                }
            }
            DevExpress.XtraTab.XtraTabPage XTabPage = new DevExpress.XtraTab.XtraTabPage { Text = frm.Text };
            XTabControl.TabPages.Add(XTabPage);
            XTabControl.SelectedTabPage = XTabPage;        
            frm.TopLevel = false;
            frm.Parent = XTabPage;
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }

        private void tabControl_CloseButtonClick(object sender, EventArgs e)
        {// dong tab
            DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            (arg.Page as DevExpress.XtraTab.XtraTabPage).Dispose();
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVatTu frm = new frmVatTu();
            OpenForm(frm, tabControl);
        }

        private void btnNhapKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapKho frm = new frmNhapKho();
            OpenForm(frm, tabControl);
        }
    }
}