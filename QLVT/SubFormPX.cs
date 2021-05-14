using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVT
{
    public partial class SubFormPX : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;

        public SubFormPX()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuXuatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void SubFormPX_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.DS.CTPX);
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            this.phieuXuatBindingSource.DataSource = Program.FrmPhieu.getPhieuXuatBDS();

            panelBtn.Enabled = cTPXGridControl.Enabled = false;
            txtMakho.Enabled = spnMANV.Enabled = dtNgay.Enabled = false;
        }

        private void cmbKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbKho.SelectedValue != null && txtMakho.Text != cmbKho.SelectedValue.ToString())
                    txtMakho.Text = cmbKho.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn kho, vui lòng thử lại!" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void SubFormPX_Shown(object sender, EventArgs e)
        {
            phieuXuatBindingSource.AddNew();
            spnMANV.Value = int.Parse(Program.username);
            dtNgay.DateTime = DateTime.Now;
            txtMakho.Text = cmbKho.SelectedValue.ToString().Trim();

            cmbKho.SelectedIndex = 1;
            cmbKho.SelectedIndex = 0;
        }

        private void SubFormPX_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (flagSuccess == false)
            {
                DialogResult dr = MessageBox.Show("Dữ liệu chưa được lưu! \nBạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    
                    e.Cancel = true;
                }
                else if (dr == DialogResult.Yes)
                {
                    int count = this.cTPXBindingSource.Count;
                    if (count > 0)
                    {
                        updateVT(count);
                    }

                    Program.FrmPhieu.reload();
                    flagSuccess = true;
                    Program.FrmChinh.Enabled = true;
                }
            }
        }

        private void btnTaoPX_Click(object sender, EventArgs e)
        {
            if (!checkValidate(txtMaPX, "Mã phiếu xuất không được trống")) return;
            if (!checkValidate(txtHotenKH, "Họ tên khách hàng không được trống")) return;


            string query = "DECLARE @result int \n" +
                           "EXEC @result = SP_KiemTraMa " + txtMaPX.Text + ", " + "'MAPX'\n" +
                           "SELECT 'result' = @result";
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            int result = int.Parse(myReader.GetValue(0).ToString());
            myReader.Close();
            if (result == 1)
            {
                MessageBox.Show("Mã phiếu xuất đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Mã phiếu xuất đã tồn tại ở chi nhánh khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn tạo phiếu xuất?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        this.phieuXuatBindingSource.EndEdit();
                        panelBtn.Enabled = cTPXGridControl.Enabled = true;
                        gbPX.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Program.SubFormCTPX = new SubFormCTPX();
            Program.SubFormCTPX.Show();
            Program.SubFormPX.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xóa chi tiết phiếu xuất này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                //update lại vt khi xóa chi tiết
                string mavt = this.gvCTPX.GetRowCellValue(cTPXBindingSource.Position, "MAVT").ToString().Trim();
                int soluong = int.Parse(this.gvCTPX.GetRowCellValue(cTPXBindingSource.Position, "SOLUONG").ToString().Trim());
                string query = "EXEC SP_CapNhatVatTu " + mavt + ", " + soluong + ", 'INCREASE'";
                SqlDataReader myReader;
                myReader = Program.ExecSqlDataReader(query);
                myReader.Close();
                cTPXBindingSource.RemoveCurrent();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cTPXBindingSource.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm chi tiết phiếu xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn tạo phiếu?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        this.phieuXuatTableAdapter.Update(Program.FrmPhieu.getDataSet().PhieuXuat);
                        this.cTPXTableAdapter.Update(Program.FrmPhieu.getDataSet().CTPX);
                        flagSuccess = true;
                        Program.FrmChinh.Enabled = true;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Update số lượng VT lại khi tắt form đột ngột
        private void updateVT(int n)
        {
            for(int i = 0; i<n;i++)
            {
                string mavt = this.gvCTPX.GetRowCellValue(i, "MAVT").ToString().Trim();
                int soluong = int.Parse(this.gvCTPX.GetRowCellValue(i, "SOLUONG").ToString().Trim());
                string query = "EXEC SP_CapNhatVatTu " + mavt + ", " + soluong + ", 'INCREASE'"; 
                SqlDataReader myReader;
                myReader = Program.ExecSqlDataReader(query);
                myReader.Close();
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

        public BindingSource getCTPXBDS()
        {
            return this.cTPXBindingSource;
        }

        public string getMaPX()
        {
            return txtMaPX.Text;
        }
    }
}