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

namespace QLVT.Report
{
    public partial class FrmDSNV : DevExpress.XtraEditors.XtraForm
    {
        public FrmDSNV()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FrmDSNV_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;
                label1.Enabled = false;
            }
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
                else
                {
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                }
            }
        }

        private void FrmDSNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmHoatDongNhanVien.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Program.FrmHoatDongNhanVien != null)
            {
                Program.FrmHoatDongNhanVien.setMaNV(((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MANV"].ToString());
                Program.FrmHoatDongNhanVien.setHoten(((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["HO"].ToString() + " " +
                                                                    ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["TEN"]);
                Program.FrmHoatDongNhanVien.setluong(((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["LUONG"].ToString());
                Program.FrmHoatDongNhanVien.setdiachi(((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["DIACHI"].ToString());
                Program.FrmHoatDongNhanVien.setmacn(((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MACN"].ToString());
                Program.FrmHoatDongNhanVien.setngaysinh(((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["NGAYSINH"].ToString());

            }
            this.Close();
        }
    }
}