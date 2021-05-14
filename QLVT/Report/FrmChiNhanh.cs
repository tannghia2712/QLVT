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
    public partial class FrmChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        public FrmChiNhanh()
        {
            InitializeComponent();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportDSNhanVien reportDSNhanVien = new ReportDSNhanVien();
            ReportPrintTool rpt = new ReportPrintTool(reportDSNhanVien);
            reportDSNhanVien.ShowPreviewDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbChiNhanh.ValueMember != "")   //Xử lý trường hợp Event autorun khi vừa khởi chạy project
            {
                if (this.cmbChiNhanh.SelectedValue != null && Program.servername != this.cmbChiNhanh.SelectedValue.ToString())
                    Program.servername = cmbChiNhanh.SelectedValue.ToString();

                if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }

                if (Program.KetNoi() == 0)
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
        }

        private void FrmChiNhanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmChinh.Enabled = true;
        }
    }
}