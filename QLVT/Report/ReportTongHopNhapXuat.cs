using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Data;

namespace QLVT.Report
{
    public partial class ReportTongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportTongHopNhapXuat(DateTime FromDate, DateTime ToDate)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = FromDate.ToString("yyyy-MM-dd");
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ToDate.ToString("yyyy-MM-dd");
            this.sqlDataSource1.Fill();

            lbNgayThang.Text = "Từ ngày " + FromDate.ToString("dd/MM/yyyy") + " - " + "Đến ngày " + ToDate.ToString("dd/MM/yyyy");
            BindingSource bdsCN = Program.bds_dspm;
            lbCN.Text = ((DataRowView)bdsCN[bdsCN.Position])["TENCN"].ToString();
        }

    }
}
