using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLVT.Report;
using DevExpress.XtraReports.UI;

namespace QLVT
{


    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                Program.FrmNhanVien = new FrmNhanVien();
                Program.FrmNhanVien.MdiParent = this;
                Program.FrmNhanVien.Show();
            }

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "USER")
                btnTaoTaiKhoan.Enabled = false;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmLogin));
            if (frm != null) frm.Activate();
            else
            {
                Program.FrmLogin = new FrmLogin();
                Program.FrmLogin.MdiParent = this;
                Program.FrmLogin.Show();
            }
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmVatTu));
            if (frm != null) frm.Activate();
            else
            {
                Program.FrmVatTu = new FrmVatTu();
                Program.FrmVatTu.MdiParent = this;
                Program.FrmVatTu.Show();
            }
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmKho));
            if (frm != null) frm.Activate();
            else
            {
                Program.FrmKho = new FrmKho();
                Program.FrmKho.MdiParent = this;
                Program.FrmKho.Show();
            }
        }

        private void btnPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmPhieu));
            if (frm != null) frm.Activate();
            else
            {
                Program.FrmPhieu = new FrmPhieu();
                Program.FrmPhieu.MdiParent = this;
                Program.FrmPhieu.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                Program.FrmTaoTaiKhoan = new FrmTaoTaiKhoan();
                Program.FrmTaoTaiKhoan.MdiParent = this;
                Program.FrmTaoTaiKhoan.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((Program.flagCloseFormNV == false && Program.FrmNhanVien != null) || (Program.flagCloseFormVT == false && Program.FrmVatTu != null)
                || (Program.flagCloseFormKho == false && Program.FrmKho != null))
            {
                e.Cancel = true;
                return;
            }
            Program.FrmLogin.Visible = true;
        }

        private void btnRP_DSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "CONGTY")
            {
                Program.FrmChiNhanh = new FrmChiNhanh();
                Program.FrmChiNhanh.Show();
                Program.FrmChinh.Enabled = false;
            }
            else
            {
                ReportDSNhanVien reportDSNhanVien = new ReportDSNhanVien();
                ReportPrintTool rpt = new ReportPrintTool(reportDSNhanVien);
                reportDSNhanVien.ShowPreviewDialog();
            }
            
        }

        private void btnRP_DSVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportDSVatTu reportDSVatTu = new ReportDSVatTu();
            ReportPrintTool rpt = new ReportPrintTool(reportDSVatTu);
            reportDSVatTu.ShowPreviewDialog();
        }

        private void btnRP_DSDDHChuacoPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportDSDDHChuaCoPN reportDSDDHChuaCoPN = new ReportDSDDHChuaCoPN();
            ReportPrintTool rpt = new ReportPrintTool(reportDSDDHChuaCoPN);
            reportDSDDHChuaCoPN.ShowPreviewDialog();
        }

        private void btnRP_HDNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FrmHoatDongNhanVien = new FrmHoatDongNhanVien();
            Program.FrmHoatDongNhanVien.Show();
            Program.FrmChinh.Enabled = false;
        }



        private void btnRP_BangKeCTNhapXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FrmCTNhapXuat = new FrmCTNhapXuat();
            Program.FrmCTNhapXuat.Show();
            Program.FrmChinh.Enabled = false;
        }

        private void btnRP_TongHopNhapXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FrmTongHopNhapXuat = new FrmTongHopNhapXuat();
            Program.FrmTongHopNhapXuat.Show();
            Program.FrmChinh.Enabled = false;
        }
    }
}
