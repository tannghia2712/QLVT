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
    
    public partial class FrmKho : DevExpress.XtraEditors.XtraForm
    {

        string macn = "";
        int vitri = 0;

        public FrmKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FrmKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            macn = ((DataRowView)bdsKho[0])["MACN"].ToString();
            if(Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnUndo.Enabled = false;
            }
            else if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                panelCN.Enabled = false;
            }
            btnGhi.Enabled = btnUndo.Enabled = gbKho.Enabled = false;
            Program.flagCloseFormKho = true;
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
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Fill(this.DS.Kho);
                    macn = ((DataRowView)bdsKho[0])["MACN"].ToString();
                }
            }
        }

        //=======Khu vực Thêm, Xóa, Hiệu chỉnh, Ghi, Undo, Reload, Thoát KHO========

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            this.bdsKho.AddNew();
            txtMACN.Text = macn;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = khoGridControl.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = gbKho.Enabled = true;
            Program.flagCloseFormKho = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = khoGridControl.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = gbKho.Enabled = true;
            Program.flagCloseFormKho = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string makho = "";
            DialogResult dr = MessageBox.Show("Bạn muốn xóa kho này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                try
                {
                    makho = ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString();
                    this.bdsKho.RemoveCurrent();
                    this.khoTableAdapter.Update(this.DS.Kho);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa kho, Hãy thử lại! \n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.khoTableAdapter.Fill(this.DS.Kho);
                    return;
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkValidate(txtMAKHO, "Mã kho không được trống!")) return;
            if (!checkValidate(txtTENKHO, "Tên kho không được trống!")) return;
            if (!checkValidate(txtDIACHI, "Địa chỉ không được trống!")) return;
            
            
            string query = "DECLARE @result int \n" +
                           "EXEC @result = SP_KiemTraMa " + txtMAKHO.Text + ", " + "'MAVT'\n" +
                           "SELECT 'result' = @result";
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            int result = int.Parse(myReader.GetValue(0).ToString());
            myReader.Close();

            if (result == 1)
            {
                MessageBox.Show("Mã kho đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Mã kho đã tồn tại ở CN khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn muốn thêm dữ liệu kho?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        this.bdsKho.EndEdit();
                        this.khoTableAdapter.Update(this.DS.Kho);
                        Program.flagCloseFormKho = true;
                        btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = khoGridControl.Enabled = true;
                        btnGhi.Enabled = btnUndo.Enabled = gbKho.Enabled = false;
                        bdsKho.Position = vitri;
                    }
                    catch (Exception ex)
                    {
                        bdsKho.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = khoGridControl.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = gbKho.Enabled = false;
            this.bdsKho.CancelEdit();   
            Program.flagCloseFormKho = true;
            bdsKho.Position = vitri;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.khoTableAdapter.Fill(this.DS.Kho);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FrmKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.flagCloseFormKho == false)
            {
                DialogResult dr = MessageBox.Show("Dữ liệu chưa được lưu! \nBạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.Yes)
                {
                    Program.flagCloseFormKho = true;
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