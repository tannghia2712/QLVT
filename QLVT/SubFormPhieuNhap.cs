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
    public partial class SubFormPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;
        BindingSource bdsDDH;

        public SubFormPhieuNhap()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void SubFormPhieuNhap_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.DS.CTPN);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);


            this.phieuNhapBindingSource.DataSource = Program.FrmPhieu.getPhieuNhapBDS();
            this.cTPNBindingSource.DataSource = Program.FrmPhieu.getCTPhieuNhapBDS();
            bdsDDH = Program.FrmPhieu.getCTDatHangBDS();

            txtMasoDDH.Enabled = txtMakho.Enabled = dtNgay.Enabled = spnMaNV.Enabled = false;
            cTPNGridControl.Enabled = panelBtn.Enabled = false;
        }

        private void SubFormPhieuNhap_Shown(object sender, EventArgs e)
        {
            this.phieuNhapBindingSource.AddNew();
            dtNgay.Text = DateTime.Now.ToString();
            spnMaNV.Value = int.Parse(Program.username);

            BindingSource tempDDH = Program.FrmPhieu.getDatHangBDS();
            txtMasoDDH.Text = ((DataRowView)tempDDH[tempDDH.Position])["MasoDDH"].ToString().Trim();
            txtMakho.Text = ((DataRowView)tempDDH[tempDDH.Position])["MAKHO"].ToString().Trim();
        }

        private void SubFormPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
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
                    flagSuccess = true;
                    Program.FrmChinh.Enabled = true;
                }
            }   
        }

        

        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            if (!checkValidate(txtMaPN, "Mã phiếu nhập không được trống")) return;

            string query = "DECLARE @result int \n" +
                           "EXEC @result = SP_KiemTraMa " + txtMaPN.Text + ", " + "'MAPN'\n" +
                           "SELECT 'result' = @result";
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            int result = int.Parse(myReader.GetValue(0).ToString());
            myReader.Close();
            if (result == 1)
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Mã phiéu nhập đã tồn tại ở chi nhánh khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Tạo phiếu nhập?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dr == DialogResult.OK)
                {
                    try
                    {
                        this.phieuNhapBindingSource.EndEdit();
                        this.phieuNhapTableAdapter.Update(Program.FrmPhieu.getDataSet().PhieuNhap);
                        panelBtn.Enabled = cTPNGridControl.Enabled = true;
                        gbPN.Enabled = false;
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
            if (bdsDDH.Count == cTPNBindingSource.Count)
            {
                MessageBox.Show("Đơn đặt hàng này đã lập đủ Chi Tiết Phiếu Nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.SubFormCTPN = new SubFormCTPN();
            Program.SubFormCTPN.Show();
            Program.SubFormPN.Enabled = false;
        }

        

        private void btnOK_Click(object sender, EventArgs e)
        {
            flagSuccess = true;
            Program.FrmChinh.Enabled = true;
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

        public string getMaPN()
        {
            return txtMaPN.Text;
        }
        
    }
}