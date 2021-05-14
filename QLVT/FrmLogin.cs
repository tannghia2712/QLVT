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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);
            tENCNComboBox.SelectedIndex = 1;
            tENCNComboBox.SelectedIndex = 0;
        }



        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tENCNComboBox.SelectedValue != null)
            {
                Program.servername = tENCNComboBox.SelectedValue.ToString();
            }
                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            executeLogin();
        }

        private void btnDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) executeLogin();
        }

        private void executeLogin()
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;
            Program.mChinhanh = tENCNComboBox.SelectedIndex;
            Program.bds_dspm = bdsDSPM;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            SqlDataReader myReader;

            String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();

            Program.username = myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            myReader.Close();
            Program.conn.Close();
            Program.FrmChinh = new FrmMain();
            Program.FrmChinh.Activate();
            Program.FrmChinh.Show();
            Program.FrmChinh.MANV.Text = "Mã nhân viên: " + Program.username;
            Program.FrmChinh.HOTEN.Text = "Họ tên: " + Program.mHoten;
            Program.FrmChinh.NHOM.Text = "Nhóm: " + Program.mGroup;
            
            this.Visible = false;
        } 

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) executeLogin();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) executeLogin();
        }
    }
}