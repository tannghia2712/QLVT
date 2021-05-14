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
    public partial class FrmVatTu : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;

        public FrmVatTu()
        {
            InitializeComponent();
        }


        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FrmVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled = false;
            }
            btnUndo.Enabled = btnGhi.Enabled = gbVT.Enabled = false;
            Program.flagCloseFormVT = true;
        }

        //=======Khu vực Thêm, Xóa, Hiệu chỉnh, Ghi, Undo, Reload, Thoát VẬT TƯ========

        
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVT.Position;
            this.bdsVT.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = vattuGridControl.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = gbVT.Enabled = true;
            Program.flagCloseFormVT = false;
            spnSLT.Value = 0;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVT.Position;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = vattuGridControl.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = gbVT.Enabled = true;
            txtMAVT.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mavt = "";
            DialogResult dr = MessageBox.Show("Bạn muốn xóa vật tư này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    mavt = ((DataRowView)bdsVT[bdsVT.Position])["MAVT"].ToString();
                    bdsVT.RemoveCurrent();
                    this.vattuTableAdapter.Update(this.DS.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư hãy xóa lại! \n" + ex.Message, "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.vattuTableAdapter.Fill(this.DS.Vattu);
                    bdsVT.Position = bdsVT.Find("MAVT", mavt);
                    return;
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkValidate(txtMAVT, "Mã VT không được trống!")) return;
            if (!checkValidate(txtTVT, "Tên vật tư không được trống!")) return;
            if (!checkValidate(txtDVT, "Đơn vị tính không được trống!")) return;
            if (txtMAVT.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã VT không được quá 4 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
                txtMAVT.Focus();
                return;
            }
            else if(txtMAVT.Text.Contains(" "))
            {
                MessageBox.Show("Mã VT không được chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtMAVT.Focus();
                return;
            }
            string query = "DECLARE @result int \n" +
                           "EXEC @result = SP_KiemTraMa " + txtMAVT.Text + ", " + "'MAVT'\n" +
                           "SELECT 'result' = @result";
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            int result = int.Parse(myReader.GetValue(0).ToString());
            myReader.Close();

            if (result == 1)
            {
                MessageBox.Show("Mã vật tư đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Mã vật tư đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                DialogResult dr = MessageBox.Show("Bạn muốn thêm dữ liệu vật tư?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        Program.flagCloseFormVT = true; // Cho phép tắt form vật tư
                        btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = vattuGridControl.Enabled = true;
                        btnGhi.Enabled = btnUndo.Enabled = gbVT.Enabled = true;
                        this.bdsVT.EndEdit();
                        this.vattuTableAdapter.Update(this.DS.Vattu);
                        bdsVT.Position = vitri;
                    }
                    catch (Exception ex)
                    {
                        //Khi Update lỗi thì xóa record vừa thêm trong bds
                        bdsVT.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = vattuGridControl.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = gbVT.Enabled = false;
            Program.flagCloseFormVT = true;
            bdsVT.CancelEdit();
            bdsVT.Position = vitri;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.vattuTableAdapter.Fill(this.DS.Vattu);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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

        private void FrmVatTu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.flagCloseFormVT == false)
            {
                DialogResult dr = MessageBox.Show("Dữ liệu chưa được lưu! \nBạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if ( dr == DialogResult.Yes)
                {
                    Program.flagCloseFormVT = true;
                }
            }
        }

       
    }
}