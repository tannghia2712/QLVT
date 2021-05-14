using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Windows.Forms;

namespace QLVT.Report
{
    public partial class ReportBangKeCTNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBangKeCTNhapXuat()
        {
            InitializeComponent();
        }

       

        public ReportBangKeCTNhapXuat(DateTime fromDate, DateTime toDate, string nhom, string loai)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = fromDate.ToString("yyyy-MM-dd"); 
            this.sqlDataSource1.Queries[0].Parameters[1].Value = toDate.ToString("yyyy-MM-dd"); 
            this.sqlDataSource1.Queries[0].Parameters[2].Value = nhom;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = loai;
            this.sqlDataSource1.Fill();

            lbTitle.Text += (loai == "NHAP") ? "NHẬP" : "XUẤT";
            lbNgayThang.Text = "Từ ngày " + fromDate.ToString("dd/MM/yyyy") + " - Đến ngày " + toDate.ToString("dd-MM-yyyy");

            if (Program.mGroup == "CONGTY")
            {
                lbCN.Text = "Chi Nhánh 1 - Chi Nhánh 2";
            }
            else
            {
                BindingSource bdsCN = Program.bds_dspm;
                lbCN.Text = (((DataRowView)bdsCN[bdsCN.Position])["TENCN"].ToString());
            }



        }

      
    }
}
