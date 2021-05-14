using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QLVT.Report
{
    public partial class FrmTongHopNhapXuat : DevExpress.XtraEditors.XtraForm
    {
        public FrmTongHopNhapXuat()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (deFromDate.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn khoảng thời gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                deFromDate.Focus();
            }
            else if (deToDate.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn khoảng thời gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                deToDate.Focus();
            }
            else if (DateTime.Compare(deFromDate.DateTime, deToDate.DateTime) > 0)
            {
                MessageBox.Show("Vui lòng chọn thời gian kết thúc > thời gian bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                deToDate.Focus();
            }
            else
            {
                ReportTongHopNhapXuat reportTongHopNhapXuat = new ReportTongHopNhapXuat(deFromDate.DateTime, deToDate.DateTime);
                ReportPrintTool rpt = new ReportPrintTool(reportTongHopNhapXuat);
                reportTongHopNhapXuat.ShowPreviewDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTongHopNhapXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmChinh.Enabled = true;
        }
    }
}