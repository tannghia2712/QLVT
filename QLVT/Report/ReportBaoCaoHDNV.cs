using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Data;

namespace QLVT.Report
{
    public partial class ReportBaoCaoHDNV : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBaoCaoHDNV(string manv, DateTime FromDate, DateTime ToDate)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = int.Parse(manv);
            this.sqlDataSource1.Queries[0].Parameters[1].Value = FromDate.ToString("yyyy-MM-dd");
            this.sqlDataSource1.Queries[0].Parameters[2].Value = ToDate.ToString("yyyy-MM-dd");
            this.sqlDataSource1.Queries[1].Parameters[0].Value = int.Parse(manv);
            this.sqlDataSource1.Queries[1].Parameters[1].Value = FromDate.ToString("yyyy-MM-dd");
            this.sqlDataSource1.Queries[1].Parameters[2].Value = ToDate.ToString("yyyy-MM-dd");
            this.sqlDataSource1.Queries[2].Parameters[0].Value = int.Parse(manv);
            this.sqlDataSource1.Queries[2].Parameters[1].Value = FromDate.ToString("yyyy-MM-dd");
            this.sqlDataSource1.Queries[2].Parameters[2].Value = ToDate.ToString("yyyy-MM-dd");
            this.sqlDataSource1.Fill();

            lbNgayThang.Text = "Từ ngày " + FromDate.ToString("dd/MM/yyyy") + " - " + "Đến ngày " + ToDate.ToString("dd/MM/yyyy");
            lbManv.Text = manv;
            lbHoten.Text = Program.FrmHoatDongNhanVien.getHoten();
            lbNgaysinh.Text = Program.FrmHoatDongNhanVien.getngaysinh();
            lbMacn.Text = Program.FrmHoatDongNhanVien.getmacn();
            lbLuong.Text = Program.FrmHoatDongNhanVien.getluong();
            lbDiachi.Text = Program.FrmHoatDongNhanVien.getdiachi();
        }

    }
}
