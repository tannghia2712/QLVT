using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace QLVT
{
    public partial class SubFormCTPX : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;

        public SubFormCTPX()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void SubFormCTPX_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.DS.CTPX);
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            this.cTPXBindingSource.DataSource = Program.SubFormPX.getCTPXBDS();

            txtMaPX.Enabled = txtMaVT.Enabled = false;
        }

        private void SubFormCTPX_Shown(object sender, EventArgs e)
        {
            this.cTPXBindingSource.AddNew();

            txtMaPX.Text = Program.SubFormPX.getMaPX();
            spnSoluong.Value = 1;
        }

        private void gvVT_Click(object sender, EventArgs e)
        {
            if (vattuBindingSource.Position != -1) //Trường hợp không có dữ liệu
            {
                int soluong = int.Parse(gvVT.GetRowCellValue(vattuBindingSource.Position, "SOLUONGTON").ToString().Trim());
                if (soluong <= 0)
                {
                    MessageBox.Show("Vật Tư không còn hàng. Vui lòng kiểm tra lại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    spnSoluong.Properties.MaxValue = int.Parse(gvVT.GetRowCellValue(vattuBindingSource.Position, "SOLUONGTON").ToString().Trim());
                    spnSoluong.Properties.MinValue = 1;
                    txtMaVT.Text = gvVT.GetRowCellValue(vattuBindingSource.Position, "MAVT").ToString().Trim();
                }

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(txtMaPX, "Mã PX không được trống")) return;
            if(!checkValidate(txtMaVT,"Mã VT không được trống")) return;
            if (!checkValidate(spnDongia, "Đơn giá phải lớn hơn 0")) return;
            if (!checkValidate(spnSoluong, "Số lượng phải lớn hơn 0")) return;
            //Kiểm tra trùng CTPX
            int positionMaVT = cTPXBindingSource.Find("MAVT", txtMaVT.Text);
            if (positionMaVT != -1 && (positionMaVT != cTPXBindingSource.Position))
            {
                MessageBox.Show("Trùng Mã số PX & Mã VT của chi tiết PX khác!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Thêm chi tiết phiếu xuất?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                try
                {
                    string query = "EXEC SP_CapNhatVatTu " + txtMaVT.Text + ", " + spnSoluong.Value + ", 'DECREASE'";
                    SqlDataReader myReader;
                    myReader = Program.ExecSqlDataReader(query);
                    myReader.Close();
                    this.cTPXBindingSource.EndEdit();
                    flagSuccess = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        

        private void SubFormCTPX_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) cTPXBindingSource.CancelEdit();
            Program.SubFormPX.Enabled = true;
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
            if (sp.Value <= 0)
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sp.Focus();
                return false;
            }
            return true;
        }

        
    }
}