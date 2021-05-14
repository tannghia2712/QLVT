using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FrmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string macn = "";
        public FrmNhanVien()
        {
            InitializeComponent();
        }


        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            
            DS.EnforceConstraints = false;           
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.DS.CTPX);
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.DS.CTPN);
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);

            macn = ((DataRowView)bdsNV[0])["MACN"].ToString(); //Cập nhật tự động vào label MACN khi tạo mới
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = false;
                btnGhi.Enabled = btnChuyenCN.Enabled = btnUndo.Enabled = false;
            }   
            else if (Program.mGroup == "CHINHANH")
            {
                panelCN.Enabled = false;
            }
            else if (Program.mGroup == "USER")
            {
                panelCN.Enabled = btnChuyenCN.Enabled = false;
            }
            btnUndo.Enabled = btnGhi.Enabled = gbNV.Enabled = false;

            Program.flagCloseFormNV = true; //Khi load bật cho phép có thể đóng form
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

        //=======Khu vực Thêm, Xóa, Hiệu chỉnh, Ghi, Undo, Reload, Thoát Nhân Viên========
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            gbNV.Enabled = true;
            bdsNV.AddNew();
            spnMANV.Value = newMANV();
            txtMACN.Text = macn;
            txtLUONG.Value = 4000000;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenCN.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            trangThaiXoaCheckBox.Enabled = nhanVienGridControl.Enabled = false;
            Program.flagCloseFormNV = false;    //Bật cờ lên để chặn tắt Form đột ngột khi nhập liệu
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            gbNV.Enabled = true;
            spnMANV.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = nhanVienGridControl.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = trangThaiXoaCheckBox.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkValidate(spnMANV, "Mã NV không được trống!")) return;
            if (!checkValidate(txtHO, "Họ không được trống!")) return;
            if (!checkValidate(txtTEN, "Tên không được trống!")) return;
            if (!checkValidate(txtDIACHI, "Địa chỉ không được trống!")) return;
            if (dtNGAYSINH.Text.Equals(""))
            {
                MessageBox.Show("Ngày sinh không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNGAYSINH.Focus();
                return;
            }

            string query = "DECLARE @result int \n" +
                           "EXEC @result = SP_KiemTraMa " + spnMANV.Value + ", " + "'MANV'\n" +
                           "SELECT 'result' = @result";
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            int result = int.Parse(myReader.GetValue(0).ToString());
            myReader.Close();

            if (result == 1)
            {
                MessageBox.Show("Mã NV đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Mã NV đã tồn tại ở chi nhánh khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                DialogResult dr = MessageBox.Show("Bạn muốn thêm dữ liệu nhân viên?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        Program.flagCloseFormNV = true; // Cho phép tắt form NV
                        btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenCN.Enabled = nhanVienGridControl.Enabled = true;
                        btnUndo.Enabled = gbNV.Enabled = btnGhi.Enabled = false;
                        this.bdsNV.EndEdit();
                        this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                        bdsNV.Position = vitri;
                    }
                    catch (Exception ex)
                    {
                        //Khi Update database lỗi thì xóa record vừa thêm trong bds
                        bdsNV.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int manv = 0;
            if (bdsPN.Count > 0 || bdsPX.Count > 0 || bdsDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu!", "", MessageBoxButtons.OK);
                return;
            }
            
            DialogResult dr = MessageBox.Show("Bạn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                    bdsNV.RemoveCurrent();
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên hãy xóa lại! \n" + ex.Message, "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenCN.Enabled = nhanVienGridControl.Enabled = true;
            btnUndo.Enabled = gbNV.Enabled = btnGhi.Enabled = false;
            Program.flagCloseFormNV = true;
            bdsNV.CancelEdit();
            bdsNV.Position = vitri;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            this.cTPXTableAdapter.Fill(this.DS.CTPX);
            this.cTPNTableAdapter.Fill(this.DS.CTPN);
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FrmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.flagCloseFormNV == false)
            {
                DialogResult dr = MessageBox.Show("Dữ liệu chưa được lưu! \nBạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.Yes)
                {
                    Program.flagCloseFormNV = true;
                }
            }
        }

        //=========== Tạo mã nv ===========
        public static int newMANV()
        {
            SqlDataReader myReader = null;
            string query = "SELECT * FROM ListMANV ORDER BY MANV";
            List<int> list = new List<int>();
            try
            {
                myReader = Program.ExecSqlDataReader(query);
                while (myReader.Read())
                {
                    list.Add(myReader.GetInt32(0));
                }
                myReader.Close();

                for (int i = 1; i <= list[list.Count - 1]; i++)
                {
                    if (list.BinarySearch(i) < 0) return i; //Tìm thấy số âm tức số đó chưa tồn tại. Nhận số đó là ID mới
                }
                return list[(list.Count - 1)] + 1;    //Nếu duyệt từ bé đến lớn trong dãy không có MANV mới sẽ +1 lên
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm Mã Nhân Viên mới! \n" + ex.Message, "Notification", MessageBoxButtons.OK);
                myReader.Close();
            }
            return -1;  //Không tìm thấy trả -1 đánh dấu Dừng chương trình
        }


        //================Các Method hỗ trợ================
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
        private bool checkValidate(SpinEdit sp, string str)
        {
            if (sp.Value == 0)
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sp.Focus();
                return false;
            }
            return true;
        }

        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vitriNV = bdsNV.Find("MANV", spnMANV.Value);
            int trangthaixoaNV = int.Parse(((DataRowView)bdsNV[vitriNV])["TrangThaiXoa"].ToString());
            if (trangthaixoaNV == 1)
            {
                MessageBox.Show("Nhân Viên này đã bị xóa hoặc chuyển chi nhánh. Vui lòng chọn nhân viên khác!\n", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (spnMANV.Value == int.Parse(Program.username))
            {
                MessageBox.Show("Tài khoản Nhân Viên đang được đăng nhập không thể chuyển chi nhánh. Vui lòng chọn nhân viên khác!\n", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn chuyển nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                vitri = bdsNV.Position;
                string query = "DECLARE @result int \n" +
                               "EXEC @result = SP_ChuyenCN " + spnMANV.Value + 
                               "SELECT 'result' = @result";
                SqlDataReader myReader;
                myReader = Program.ExecSqlDataReader(query);
                myReader.Read();
                int result = int.Parse(myReader.GetValue(0).ToString());
                myReader.Close();
                if (result == -1)    //Trường hợp thất bại
                {
                    MessageBox.Show("Chuyển Chi nhánh thất bại! Dữ liệu đã được Roolback!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == -3)
                {
                    MessageBox.Show("Xóa Login không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == -4)
                {
                    MessageBox.Show("Xóa User không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 0)    
                {
                    MessageBox.Show("Chuyển chi nhánh thành công!" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                bdsNV.Position = vitri;
            }
        }
    }
}