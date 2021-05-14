using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;
using QLVT.Report;

namespace QLVT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLVT_DATHANG";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;
        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static FrmMain FrmChinh;
        public static FrmLogin FrmLogin;
        public static FrmNhanVien FrmNhanVien;
        public static FrmVatTu FrmVatTu;
        public static FrmKho FrmKho;
        public static FrmPhieu FrmPhieu;
        public static FrmTaoTaiKhoan FrmTaoTaiKhoan;
        public static FrmCTNhapXuat FrmCTNhapXuat;
        public static FrmHoatDongNhanVien FrmHoatDongNhanVien;
        public static FrmDSNV FrmDSNV;
        public static FrmChiNhanh FrmChiNhanh;
        public static FrmTongHopNhapXuat FrmTongHopNhapXuat;
        public static SubFormDDH SubFormDDH;
        public static SubFormCTDDH SubFormCTDDH;
        public static SubFormPhieuNhap SubFormPN;
        public static SubFormCTPN SubFormCTPN;
        public static SubFormPX SubFormPX;
        public static SubFormCTPX SubFormCTPX;

        public static bool flagCloseFormNV;
        public static bool flagCloseFormVT;
        public static bool flagCloseFormKho;


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại username và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); 
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin = new FrmLogin();
            Application.Run(FrmLogin);
        }
    }
}
