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
    public partial class FrmCTNhapXuat : DevExpress.XtraEditors.XtraForm
    {
        public FrmCTNhapXuat()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCTNhapXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmChinh.Enabled = true;
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
            else if (DateTime.Compare(deFromDate.DateTime,deToDate.DateTime)>0)
            {
                MessageBox.Show("Vui lòng chọn thời gian kết thúc > thời gian bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                deToDate.Focus();
            }
            else if (!(cbXuat.Checked || cbNhap.Checked))
            {
                MessageBox.Show("Vui lòng chọn loại phiếu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string loai = (cbNhap.Checked) ? "NHAP" : "XUAT";
                string nhom = Program.mGroup;

                ReportBangKeCTNhapXuat reportBangKeCTNhapXuat = new ReportBangKeCTNhapXuat(deFromDate.DateTime, deToDate.DateTime, nhom, loai);
                ReportPrintTool rpt = new ReportPrintTool(reportBangKeCTNhapXuat);
                reportBangKeCTNhapXuat.ShowPreviewDialog();


            }

        }

        private void cbNhap_CheckedChanged(object sender, EventArgs e)
        {
            cbXuat.Checked = !cbNhap.Checked;
            
        }

        private void cbXuat_CheckedChanged(object sender, EventArgs e)
        {
            cbNhap.Checked = !cbXuat.Checked;
            
        }
    }
}