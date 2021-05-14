using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVT
{
    public partial class SubFormDDH : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;
        public SubFormDDH()
        {
            InitializeComponent();
        }

        

        private void SubFormDDH_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.datHangBindingSource.DataSource = Program.FrmPhieu.getDatHangBDS();
            

            panelBtn.Enabled = false;
            cTDDHGridControl.Enabled = false;
            dtNgay.Enabled = spnMaNV.Enabled = txtMakho.Enabled = false;
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
                MessageBox.Show("Lỗi chọn kho, vui lòng thử lại!" + ex.Message,"",MessageBoxButtons.OK);
                return;
            }
        }

        

        private void SubFormDDH_Shown(object sender, EventArgs e)
        {
            this.datHangBindingSource.AddNew();
            spnMaNV.Value = int.Parse(Program.username);
            dtNgay.DateTime = DateTime.Now;
            txtMakho.Text = cmbKho.SelectedValue.ToString().Trim();

            cmbKho.SelectedIndex = 1;
            cmbKho.SelectedIndex = 0;

        }

        private void btnTaoDDH_Click(object sender, EventArgs e)
        {
            if (!checkValidate(txtMasoDDH, "Mã đơn đặt hàng không được trống")) return;
            if (!checkValidate(txtNhaCC, "Nhà cung cấp không được trống")) return;


            string query = "DECLARE @result int \n" +
                           "EXEC @result = SP_KiemTraMa " + txtMasoDDH.Text + ", " + "'MasoDDH'\n" +
                           "SELECT 'result' = @result";
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            int result = int.Parse(myReader.GetValue(0).ToString());
            myReader.Close();
            if (result == 1)
            {
                MessageBox.Show("Mã đơn đặt hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Mã đơn đặt hàng đã tồn tại ở chi nhánh khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn tạo đơn đặt hàng?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        this.datHangBindingSource.EndEdit();
                        panelBtn.Enabled = cTDDHGridControl.Enabled = true;
                        gbDDH.Enabled = false;
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
            Program.SubFormCTDDH = new SubFormCTDDH();
            Program.SubFormCTDDH.Show();
            Program.SubFormDDH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xóa chi tiết đặt hàng này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                cTDDHBindingSource.RemoveCurrent();
            }    
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cTDDHBindingSource.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm chi tiết đơn đặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn tạo đơn đặt hàng?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        this.datHangTableAdapter.Update(Program.FrmPhieu.getDataSet().DatHang);
                        this.cTDDHTableAdapter.Update(Program.FrmPhieu.getDataSet().CTDDH);
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


        private void SubFormDDH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(flagSuccess == false)
            {
                DialogResult dr = MessageBox.Show("Dữ liệu chưa được lưu! \nBạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;   
                }
                else if (dr == DialogResult.Yes)
                {
                    Program.FrmPhieu.reload();
                    flagSuccess = true;
                    Program.FrmChinh.Enabled = true;
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
        

        public string getMasoDDH()
        {
            return this.txtMasoDDH.Text;
        }
       

        
        public BindingSource getCTDatHangBDS()
        {
            return this.cTDDHBindingSource;
        }

        
    }
}