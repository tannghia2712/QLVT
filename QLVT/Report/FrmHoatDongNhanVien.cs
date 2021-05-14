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
    public partial class FrmHoatDongNhanVien : DevExpress.XtraEditors.XtraForm
    {
       
        private String luong;
        private String macn;
        private String ngaysinh;
        private String diachi;


        public String getngaysinh()
        {
            return ngaysinh;
        }

        public String getdiachi()
        {
            return diachi;
        }
        public FrmHoatDongNhanVien()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Program.FrmDSNV = new FrmDSNV();
            Program.FrmDSNV.Show();
            Program.FrmHoatDongNhanVien.Enabled = false;
        }

        private void FrmHoatDongNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtHoTen.Enabled = false;
        }

       

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnNhanVien.Focus();
            }
            else if (txtHoTen.Text == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnNhanVien.Focus();
            }
            else if (deFromDate.EditValue == null)
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
                ReportBaoCaoHDNV reportBaoCaoHDNV = new ReportBaoCaoHDNV(txtMaNV.Text, deFromDate.DateTime, deToDate.DateTime);
                ReportPrintTool rpt = new ReportPrintTool(reportBaoCaoHDNV);
                reportBaoCaoHDNV.ShowPreviewDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHoatDongNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmChinh.Enabled = true;
        }

        public void setluong(String luong)
        {
            this.luong = luong;
        }

        public void setmacn(String macn)
        {
            this.macn = macn;
        }

        public void setngaysinh(String ngaysinh)
        {
            this.ngaysinh = ngaysinh;
        }

        public void setdiachi(String diachi)
        {
            this.diachi = diachi;
        }

        public void setMaNV(String manv)
        {
            txtMaNV.Text = manv;
        }

        public void setHoten(String hoten)
        {
            txtHoTen.Text = hoten;
        }

        public String getluong()
        {
            return luong;
        }

        public String getmacn()
        {
            return macn;
        }

        public String getHoten()
        {
            return txtHoTen.Text;
        }

        public String getMaNV()
        {
            return txtMaNV.Text;
        }
    }
}