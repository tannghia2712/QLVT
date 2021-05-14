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
    public partial class SubFormCTPN : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;

        public SubFormCTPN()
        {
            InitializeComponent();
        }

        private void cTDDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cTDDHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void SubFormCTPN_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.DS.CTPN);
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.cTDDHBindingSource.DataSource = Program.FrmPhieu.getCTDatHangBDS();
            this.cTPNBindingSource.DataSource = Program.FrmPhieu.getCTPhieuNhapBDS();
            txtMaPN.Enabled = txtMaVT.Enabled = false;
        }

        private void gvCTDDH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if(cTDDHBindingSource.Position != -1)
            {
                txtMaVT.Text = this.gvCTDDH.GetRowCellValue(cTDDHBindingSource.Position, "MAVT").ToString().Trim();
                spnSoluong.Properties.MaxValue = spnSoluong.Value = int.Parse(this.gvCTDDH.GetRowCellValue(cTDDHBindingSource.Position, "SOLUONG").ToString().Trim());
                spnDongia.Value  = int.Parse(this.gvCTDDH.GetRowCellValue(cTDDHBindingSource.Position, "DONGIA").ToString().Trim());
            }
        }

        private void SubFormCTPN_Shown(object sender, EventArgs e)
        {
            this.cTPNBindingSource.AddNew();

            BindingSource tempPN = Program.FrmPhieu.getPhieuNhapBDS();
            txtMaPN.Text = ((DataRowView)tempPN[tempPN.Position])["MAPN"].ToString().Trim();
        }

        private void SubFormCTPN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) cTPNBindingSource.CancelEdit();
            if (Program.SubFormPN.Visible == true)
            {
                Program.SubFormPN.Enabled = true;
            }
            else
            {
                Program.FrmChinh.Enabled = true;
            }
        }
           

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(txtMaPN, "Mã PX không được trống")) return;
            if (!checkValidate(txtMaVT, "Mã VT không được trống")) return;
            if (!checkValidate(spnDongia, "Đơn giá phải lớn hơn 0")) return;
            if (!checkValidate(spnSoluong, "Số lượng phải lớn hơn 0")) return;

            //Kiểm tra trùng CTPN
            int positionMaVT = cTPNBindingSource.Find("MAVT", txtMaVT.Text);
            if (positionMaVT != -1 && (positionMaVT != cTPNBindingSource.Position))
            {
                MessageBox.Show("Chi tiết Đơn Đặt Hàng này đã được lập Chi Tiết Phiếu Nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Thêm chi tiết phiếu nhập?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    string query = "EXEC SP_CapNhatVatTu " + txtMaVT.Text + ", " + spnSoluong.Value + ", 'INCREASE'";
                    SqlDataReader myReader;
                    myReader = Program.ExecSqlDataReader(query);
                    myReader.Close();
                    this.cTPNBindingSource.EndEdit();
                    this.cTPNTableAdapter.Update(Program.FrmPhieu.getDataSet().CTPN);
                    flagSuccess = true;
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}