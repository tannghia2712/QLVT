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
using System.Data.SqlClient;

namespace QLVT
{
    public partial class FrmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public FrmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FrmTaoTaiKhoan_Load(object sender, EventArgs e)
        {

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            DS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            txtUser.Enabled = false;
            if(Program.mGroup == "CONGTY")
            {
                cbChinhanh.Enabled = cbUser.Enabled = false;
            }
            else if(Program.mGroup == "CHINHANH")
            {
                panelCN.Enabled = false;
                cbCongty.Enabled = false;
            }    
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(txtTK, "Tài khoản không được trống!")) return;
            if (!checkValidate(txtMK, "Mật khẩu không được trống!")) return;
            if (!checkValidate(txtKTMK, "Xác nhận mk không được trống!")) return;
            if (!checkValidate(txtUser, "Chọn nhân viên bạn muốn tạo tài khoản")) return;
            if (txtMK.Text != txtKTMK.Text)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!(cbChinhanh.Checked || cbCongty.Checked || cbUser.Checked))
            {
                MessageBox.Show("Chọn role cho tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtTK.Text.Contains(" "))
            {
                MessageBox.Show("Tài khoản không được chứa khoản trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string role = (cbCongty.Checked) ? "CONGTY": ((cbChinhanh.Checked) ? "CHINHANH" : "USER");
            string query = "DECLARE @result int " +
                           "EXEC @result = SP_TAOTAIKHOAN " +
                           " @LGNAME = N'" + txtUser.Text + "', " +
                           " @PASS = N'" + txtMK.Text + "', " +
                           " @USERNAME = N'" + txtUser.Text + "', " +
                           " @ROLE = N'" + role + "' " +
                           " SELECT 'result' = @result ";

            SqlDataReader myReader = null;
            myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            int result = int.Parse(myReader.GetValue(0).ToString());
            myReader.Close();
            if (result == 1 )
            {
                MessageBox.Show("Tài khoản bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTK.Focus();
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Nhân viên đã có tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(result == 0)
            {

                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Text = string.Empty;
                txtMK.Text = string.Empty;
                txtKTMK.Text = string.Empty;
                txtUser.Text = string.Empty;
                cbCongty.Checked = cbChinhanh.Checked = cbUser.Checked = false;
                txtTK.Focus();
            }
            

        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.Properties.UseSystemPasswordChar = (cbShow.Checked) ? false : true;
        }

        private void gvNV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtUser.Text = gvNV.GetRowCellValue(nhanVienBindingSource.Position, "MANV").ToString().Trim();
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
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                }
            }
        }

        private bool checkValidate(TextEdit te, string str)
        {
            if (te.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                te.Focus();
                return false;
            }
            return true;
        }

        
    }
}