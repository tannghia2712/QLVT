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
    public partial class FrmPhieu : DevExpress.XtraEditors.XtraForm
    {
        public FrmPhieu()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FrmPhieu_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            DS.EnforceConstraints = false;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.DS.CTPN);
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.DS.CTPX);

            gcPN.Visible = gcPX.Visible = false;
            gcDDH.Visible = true;
            

            if (Program.mGroup == "CONGTY")
            {
                btnThemDDH.Enabled = btnThemPN.Enabled = btnThemPX.Enabled = btnCTPN.Enabled  = false;
            }
            else if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                panelCN.Enabled = false;
            }

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private void btnThemDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchGroupcontrol(gcDDH);
            Program.SubFormDDH = new SubFormDDH();
            Program.SubFormDDH.Show();
            Program.FrmChinh.Enabled = false;
        }

        private void btnDSDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchGroupcontrol(gcDDH);
            
        }

        private void btnDSPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchGroupcontrol(gcPN);
        }

        private void btnDSPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            switchGroupcontrol(gcPX);
        }

        private void btnThemPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchGroupcontrol(gcPN);
            if ( gvDH.SelectedRowsCount == 1)
            {
                if(phieuNhapBindingSource.Count > 0)
                {
                    MessageBox.Show("Đơn đặt hàng này đã có Phiếu Nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }    
                Program.SubFormPN = new SubFormPhieuNhap();
                Program.SubFormPN.Show();
                Program.FrmChinh.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chọn đơn đặt hàng muốn lập phiếu Nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (phieuNhapBindingSource.Count == 0)
            {
                MessageBox.Show("Đơn đặt hàng này chưa có phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cTDDHBindingSource.Count == cTPNBindingSource.Count)
            {
                MessageBox.Show("Đơn đặt hàng này đã lập đủ Chi Tiết Phiếu Nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.SubFormCTPN = new SubFormCTPN();
            Program.SubFormCTPN.Show();
            Program.FrmChinh.Enabled = false;
        }

        private void btnThemPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchGroupcontrol(gcPX);
            Program.SubFormPX = new SubFormPX();
            Program.SubFormPX.Show();
            Program.FrmChinh.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
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
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Fill(this.DS.DatHang);
                    this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                    this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTPNTableAdapter.Fill(this.DS.CTPN);
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
                    this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTPXTableAdapter.Fill(this.DS.CTPX);
                }
            }
        }

        public void reload()
        {
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            this.cTPNTableAdapter.Fill(this.DS.CTPN);
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            this.cTPXTableAdapter.Fill(this.DS.CTPX);
        }

        public void switchGroupcontrol(GroupControl gc)
        {
            gcDDH.Visible = gcPN.Visible = gcPX.Visible = false;
            gcDDH.Dock = gcPX.Dock = gcPN.Dock  = System.Windows.Forms.DockStyle.None;
            gc.Visible = true;
            gc.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        //Getter-Setter các DataSet và BindingSource

        public BindingSource getDatHangBDS()
        {
            return this.datHangBindingSource;
        }

        public BindingSource getCTDatHangBDS()
        {
            return this.cTDDHBindingSource;
        }

        public BindingSource getPhieuNhapBDS()
        {
            return this.phieuNhapBindingSource;
        }

        public BindingSource getCTPhieuNhapBDS()
        {
            return this.cTPNBindingSource;
        }

        public BindingSource getPhieuXuatBDS()
        {
            return this.phieuXuatBindingSource;
        }

        public BindingSource getCTPhieuXuatBDS()
        {
            return this.cTPXBindingSource;
        }

        public DS getDataSet()
        {
            return this.DS;
        }

        
    }
}