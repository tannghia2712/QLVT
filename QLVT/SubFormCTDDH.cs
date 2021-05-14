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

namespace QLVT
{
    public partial class SubFormCTDDH : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;

        public SubFormCTDDH()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void SubFormCTDDH_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            this.cTDDHBindingSource.DataSource = Program.SubFormDDH.getCTDatHangBDS();

            txtMasoDDH.Enabled = false;
            txtMaVT.Enabled = false;
        }

        private void SubFormCTDDH_Shown(object sender, EventArgs e)
        {
            this.cTDDHBindingSource.AddNew();

            txtMasoDDH.Text = Program.SubFormDDH.getMasoDDH();
            spnSoluong.Value = 1;
            spnDongia.Value = 0;
        }

        private void gvVT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaVT.Text = this.gvVT.GetRowCellValue(vattuBindingSource.Position,"MAVT").ToString().Trim();
        }

        private void SubFormCTDDH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) cTDDHBindingSource.CancelEdit();
            Program.SubFormDDH.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(txtMaVT, "Mã VT không được trống")) return;
            if (!checkValidate(spnDongia, "Đơn giá phải lớn hơn 0")) return;
            if (!checkValidate(spnSoluong, "Số lượng phải lớn hơn 0")) return;

            //Kiểm tra trùng CTDDH
            int positionMaVT = cTDDHBindingSource.Find("MAVT", txtMaVT.Text);
            if (positionMaVT != -1 && (positionMaVT != cTDDHBindingSource.Position))
            {
                MessageBox.Show("Trùng Mã số DDH & Mã VT của chi tiết Đơn Đặt Hàng khác!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Thêm vật tư vào đơn đặt hàng?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    this.cTDDHBindingSource.EndEdit();

                    flagSuccess = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Lỗi cho New lại cái mới(nếu không dữ liệu lúc này là Position của phần tử cuối)
                    this.cTDDHBindingSource.AddNew();
                    txtMaVT.Text = gvVT.GetRowCellValue(vattuBindingSource.Position, "MAVT").ToString().Trim();
                    spnSoluong.Value = 1;
                    spnDongia.Value = 0;
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