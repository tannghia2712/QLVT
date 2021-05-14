namespace QLVT
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnRP_DSNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnRP_DSVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnRP_BangKeCTNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnRP_DSDDHChuacoPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnRP_HDNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnRP_TongHopNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.QuanTri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.NhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dangxuat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup15 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.MdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnTaoTaiKhoan,
            this.btnDangXuat,
            this.btnNhanVien,
            this.btnVatTu,
            this.btnKho,
            this.barButtonItem4,
            this.btnDangNhap,
            this.btnPhieu,
            this.btnRP_DSNV,
            this.btnRP_DSVT,
            this.btnRP_BangKeCTNhapXuat,
            this.btnRP_DSDDHChuacoPN,
            this.btnRP_HDNV,
            this.btnRP_TongHopNhapXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(15, 19, 15, 19);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 2096;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.QuanTri,
            this.BaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(1263, 203);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Id = 2;
            this.btnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.Image")));
            this.btnTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.LargeImage")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 5;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.CloseSubMenuOnClickMode = DevExpress.Utils.DefaultBoolean.False;
            this.btnNhanVien.Id = 6;
            this.btnNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.Image")));
            this.btnNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.LargeImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnVatTu
            // 
            this.btnVatTu.Caption = "Vật tư";
            this.btnVatTu.Id = 7;
            this.btnVatTu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVatTu.ImageOptions.Image")));
            this.btnVatTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVatTu.ImageOptions.LargeImage")));
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVatTu_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 8;
            this.btnKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.Image")));
            this.btnKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.LargeImage")));
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "ĐĂNG NHẬP";
            this.btnDangNhap.Id = 10;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnPhieu
            // 
            this.btnPhieu.Caption = "Phiếu";
            this.btnPhieu.Id = 11;
            this.btnPhieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieu.ImageOptions.Image")));
            this.btnPhieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhieu.ImageOptions.LargeImage")));
            this.btnPhieu.Name = "btnPhieu";
            this.btnPhieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieu_ItemClick);
            // 
            // btnRP_DSNV
            // 
            this.btnRP_DSNV.Caption = "Danh sách nhân viên";
            this.btnRP_DSNV.Id = 12;
            this.btnRP_DSNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRP_DSNV.ImageOptions.Image")));
            this.btnRP_DSNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRP_DSNV.ImageOptions.LargeImage")));
            this.btnRP_DSNV.Name = "btnRP_DSNV";
            this.btnRP_DSNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRP_DSNV_ItemClick);
            // 
            // btnRP_DSVT
            // 
            this.btnRP_DSVT.Caption = "Danh sách vật tư";
            this.btnRP_DSVT.Id = 14;
            this.btnRP_DSVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRP_DSVT.ImageOptions.Image")));
            this.btnRP_DSVT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRP_DSVT.ImageOptions.LargeImage")));
            this.btnRP_DSVT.Name = "btnRP_DSVT";
            this.btnRP_DSVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRP_DSVT_ItemClick);
            // 
            // btnRP_BangKeCTNhapXuat
            // 
            this.btnRP_BangKeCTNhapXuat.Caption = "Bảng kê chi tiết Nhập - Xuất";
            this.btnRP_BangKeCTNhapXuat.Id = 15;
            this.btnRP_BangKeCTNhapXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRP_BangKeCTNhapXuat.ImageOptions.Image")));
            this.btnRP_BangKeCTNhapXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRP_BangKeCTNhapXuat.ImageOptions.LargeImage")));
            this.btnRP_BangKeCTNhapXuat.Name = "btnRP_BangKeCTNhapXuat";
            this.btnRP_BangKeCTNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRP_BangKeCTNhapXuat_ItemClick);
            // 
            // btnRP_DSDDHChuacoPN
            // 
            this.btnRP_DSDDHChuacoPN.Caption = "Danh sách đơn đặt hàng chưa có phiếu nhập";
            this.btnRP_DSDDHChuacoPN.Id = 16;
            this.btnRP_DSDDHChuacoPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRP_DSDDHChuacoPN.ImageOptions.Image")));
            this.btnRP_DSDDHChuacoPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRP_DSDDHChuacoPN.ImageOptions.LargeImage")));
            this.btnRP_DSDDHChuacoPN.Name = "btnRP_DSDDHChuacoPN";
            this.btnRP_DSDDHChuacoPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRP_DSDDHChuacoPN_ItemClick);
            // 
            // btnRP_HDNV
            // 
            this.btnRP_HDNV.Caption = "Báo cáo hoạt động nhân viên";
            this.btnRP_HDNV.Id = 17;
            this.btnRP_HDNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRP_HDNV.ImageOptions.Image")));
            this.btnRP_HDNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRP_HDNV.ImageOptions.LargeImage")));
            this.btnRP_HDNV.Name = "btnRP_HDNV";
            this.btnRP_HDNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRP_HDNV_ItemClick);
            // 
            // btnRP_TongHopNhapXuat
            // 
            this.btnRP_TongHopNhapXuat.Caption = "Tổng hợp nhập xuất";
            this.btnRP_TongHopNhapXuat.Id = 18;
            this.btnRP_TongHopNhapXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRP_TongHopNhapXuat.ImageOptions.Image")));
            this.btnRP_TongHopNhapXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRP_TongHopNhapXuat.ImageOptions.LargeImage")));
            this.btnRP_TongHopNhapXuat.Name = "btnRP_TongHopNhapXuat";
            this.btnRP_TongHopNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRP_TongHopNhapXuat_ItemClick);
            // 
            // QuanTri
            // 
            this.QuanTri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.NhanVien,
            this.ribbonPageGroup13,
            this.ribbonPageGroup11,
            this.ribbonPageGroup12,
            this.dangxuat,
            this.ribbonPageGroup10});
            this.QuanTri.Name = "QuanTri";
            this.QuanTri.Text = "QUẢN TRỊ";
            // 
            // NhanVien
            // 
            this.NhanVien.AllowTextClipping = false;
            this.NhanVien.ItemLinks.Add(this.btnNhanVien);
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Text = "                  ";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.AllowTextClipping = false;
            this.ribbonPageGroup13.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            this.ribbonPageGroup13.Text = "                  ";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.AllowTextClipping = false;
            this.ribbonPageGroup11.ItemLinks.Add(this.btnVatTu);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "                  ";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.AllowTextClipping = false;
            this.ribbonPageGroup12.ItemLinks.Add(this.btnPhieu);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.Text = "                   ";
            // 
            // dangxuat
            // 
            this.dangxuat.AllowTextClipping = false;
            this.dangxuat.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.dangxuat.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.dangxuat.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.Text = "                    ";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup10.AllowTextClipping = false;
            this.ribbonPageGroup10.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "             ";
            // 
            // BaoCao
            // 
            this.BaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup14,
            this.ribbonPageGroup15});
            this.BaoCao.Name = "BaoCao";
            this.BaoCao.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRP_DSNV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "                               ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRP_DSVT);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "                                ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btnRP_BangKeCTNhapXuat);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "                                 ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btnRP_DSDDHChuacoPN);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup14
            // 
            this.ribbonPageGroup14.AllowTextClipping = false;
            this.ribbonPageGroup14.ItemLinks.Add(this.btnRP_HDNV);
            this.ribbonPageGroup14.Name = "ribbonPageGroup14";
            this.ribbonPageGroup14.Text = "                                ";
            // 
            // ribbonPageGroup15
            // 
            this.ribbonPageGroup15.AllowTextClipping = false;
            this.ribbonPageGroup15.ItemLinks.Add(this.btnRP_TongHopNhapXuat);
            this.ribbonPageGroup15.Name = "ribbonPageGroup15";
            this.ribbonPageGroup15.Text = "                                 ";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // MdiManager
            // 
            this.MdiManager.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1263, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(52, 20);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(57, 20);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(55, 20);
            this.NHOM.Text = "NHOM";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.btnRP_DSNV);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "                         ";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.btnRP_DSNV);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "                         ";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.AllowTextClipping = false;
            this.ribbonPageGroup8.ItemLinks.Add(this.btnRP_DSNV);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "                         ";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.AllowTextClipping = false;
            this.ribbonPageGroup9.ItemLinks.Add(this.btnRP_DSNV);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "                         ";
            // 
            // FrmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.ShowIcon = false;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QLVT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage QuanTri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup NhanVien;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup dangxuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage BaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnVatTu;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MdiManager;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnPhieu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.BarButtonItem btnRP_DSNV;
        private DevExpress.XtraBars.BarButtonItem btnRP_DSVT;
        private DevExpress.XtraBars.BarButtonItem btnRP_BangKeCTNhapXuat;
        private DevExpress.XtraBars.BarButtonItem btnRP_DSDDHChuacoPN;
        private DevExpress.XtraBars.BarButtonItem btnRP_HDNV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnRP_TongHopNhapXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup15;
    }
}

