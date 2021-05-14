using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Windows.Forms;

namespace QLVT.Report
{
    public partial class ReportDSNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSNhanVien()
        {
            InitializeComponent();
        }

        private void ReportDSNhanVien_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BindingSource bdsCN = Program.bds_dspm;
            lbCN.Text = ((DataRowView)bdsCN[bdsCN.Position])["TENCN"].ToString();
        }
    }
}
