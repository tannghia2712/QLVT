namespace QLVT
{
    partial class SubFormPX
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            this.gbPX = new System.Windows.Forms.GroupBox();
            this.btnTaoPX = new System.Windows.Forms.Button();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.txtMakho = new DevExpress.XtraEditors.TextEdit();
            this.phieuXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spnMANV = new DevExpress.XtraEditors.SpinEdit();
            this.txtHotenKH = new DevExpress.XtraEditors.TextEdit();
            this.dtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPX = new DevExpress.XtraEditors.TextEdit();
            this.phieuXuatTableAdapter = new QLVT.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.cTPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXTableAdapter = new QLVT.DSTableAdapters.CTPXTableAdapter();
            this.cTPXGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvCTPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.khoTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            this.gbPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).BeginInit();
            this.panelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(115, 40);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(67, 21);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "Mã PX:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(505, 82);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(53, 21);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(79, 84);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(95, 21);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "Họ tên KH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(500, 38);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(68, 21);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã NV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(99, 130);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(71, 21);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã kho:";
            // 
            // gbPX
            // 
            this.gbPX.Controls.Add(this.btnTaoPX);
            this.gbPX.Controls.Add(this.cmbKho);
            this.gbPX.Controls.Add(mAKHOLabel);
            this.gbPX.Controls.Add(this.txtMakho);
            this.gbPX.Controls.Add(mANVLabel);
            this.gbPX.Controls.Add(this.spnMANV);
            this.gbPX.Controls.Add(hOTENKHLabel);
            this.gbPX.Controls.Add(this.txtHotenKH);
            this.gbPX.Controls.Add(nGAYLabel);
            this.gbPX.Controls.Add(this.dtNgay);
            this.gbPX.Controls.Add(mAPXLabel);
            this.gbPX.Controls.Add(this.txtMaPX);
            this.gbPX.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPX.Location = new System.Drawing.Point(0, 0);
            this.gbPX.Name = "gbPX";
            this.gbPX.Size = new System.Drawing.Size(1065, 174);
            this.gbPX.TabIndex = 0;
            this.gbPX.TabStop = false;
            this.gbPX.Text = "Thông tin phiếu xuất";
            // 
            // btnTaoPX
            // 
            this.btnTaoPX.Location = new System.Drawing.Point(879, 59);
            this.btnTaoPX.Name = "btnTaoPX";
            this.btnTaoPX.Size = new System.Drawing.Size(135, 66);
            this.btnTaoPX.TabIndex = 11;
            this.btnTaoPX.Text = "Tạo phiếu xuất";
            this.btnTaoPX.UseVisualStyleBackColor = true;
            this.btnTaoPX.Click += new System.EventHandler(this.btnTaoPX_Click);
            // 
            // cmbKho
            // 
            this.cmbKho.DataSource = this.khoBindingSource;
            this.cmbKho.DisplayMember = "TENKHO";
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(391, 125);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(420, 28);
            this.cmbKho.TabIndex = 10;
            this.cmbKho.ValueMember = "MAKHO";
            this.cmbKho.SelectedIndexChanged += new System.EventHandler(this.cmbKho_SelectedIndexChanged);
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMakho
            // 
            this.txtMakho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuXuatBindingSource, "MAKHO", true));
            this.txtMakho.Location = new System.Drawing.Point(188, 127);
            this.txtMakho.Name = "txtMakho";
            this.txtMakho.Size = new System.Drawing.Size(179, 26);
            this.txtMakho.TabIndex = 9;
            // 
            // phieuXuatBindingSource
            // 
            this.phieuXuatBindingSource.DataMember = "PhieuXuat";
            this.phieuXuatBindingSource.DataSource = this.DS;
            // 
            // spnMANV
            // 
            this.spnMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuXuatBindingSource, "MANV", true));
            this.spnMANV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnMANV.Location = new System.Drawing.Point(574, 35);
            this.spnMANV.Name = "spnMANV";
            this.spnMANV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnMANV.Size = new System.Drawing.Size(237, 26);
            this.spnMANV.TabIndex = 7;
            // 
            // txtHotenKH
            // 
            this.txtHotenKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuXuatBindingSource, "HOTENKH", true));
            this.txtHotenKH.Location = new System.Drawing.Point(188, 81);
            this.txtHotenKH.Name = "txtHotenKH";
            this.txtHotenKH.Size = new System.Drawing.Size(253, 26);
            this.txtHotenKH.TabIndex = 5;
            // 
            // dtNgay
            // 
            this.dtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuXuatBindingSource, "NGAY", true));
            this.dtNgay.EditValue = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            this.dtNgay.Location = new System.Drawing.Point(574, 79);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgay.Size = new System.Drawing.Size(237, 26);
            this.dtNgay.TabIndex = 3;
            // 
            // txtMaPX
            // 
            this.txtMaPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuXuatBindingSource, "MAPX", true));
            this.txtMaPX.Location = new System.Drawing.Point(188, 37);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(253, 26);
            this.txtMaPX.TabIndex = 1;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPXBindingSource
            // 
            this.cTPXBindingSource.DataMember = "FK_CTPX_PX";
            this.cTPXBindingSource.DataSource = this.phieuXuatBindingSource;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // cTPXGridControl
            // 
            this.cTPXGridControl.DataSource = this.cTPXBindingSource;
            this.cTPXGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cTPXGridControl.Location = new System.Drawing.Point(0, 174);
            this.cTPXGridControl.MainView = this.gvCTPX;
            this.cTPXGridControl.Name = "cTPXGridControl";
            this.cTPXGridControl.Size = new System.Drawing.Size(1065, 386);
            this.cTPXGridControl.TabIndex = 1;
            this.cTPXGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPX});
            // 
            // gvCTPX
            // 
            this.gvCTPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTPX.GridControl = this.cTPXGridControl;
            this.gvCTPX.Name = "gvCTPX";
            this.gvCTPX.OptionsView.ShowGroupPanel = false;
            this.gvCTPX.OptionsView.ShowIndicator = false;
            this.gvCTPX.OptionsView.ShowViewCaption = true;
            this.gvCTPX.ViewCaption = "Chi tiết phiếu xuất";
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã PX";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.MinWidth = 25;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.btnOK);
            this.panelBtn.Controls.Add(this.btnXoa);
            this.panelBtn.Controls.Add(this.btnThem);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtn.Location = new System.Drawing.Point(0, 560);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(1065, 74);
            this.panelBtn.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(830, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(208, 56);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(227, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(156, 37);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(156, 37);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // SubFormPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 634);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.cTPXGridControl);
            this.Controls.Add(this.gbPX);
            this.Name = "SubFormPX";
            this.Text = "Phiếu xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormPX_FormClosing);
            this.Load += new System.EventHandler(this.SubFormPX_Load);
            this.Shown += new System.EventHandler(this.SubFormPX_Shown);
            this.gbPX.ResumeLayout(false);
            this.gbPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).EndInit();
            this.panelBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPX;
        private DS DS;
        private System.Windows.Forms.BindingSource phieuXuatBindingSource;
        private DSTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtMaPX;
        private DevExpress.XtraEditors.TextEdit txtMakho;
        private DevExpress.XtraEditors.SpinEdit spnMANV;
        private DevExpress.XtraEditors.TextEdit txtHotenKH;
        private DevExpress.XtraEditors.DateEdit dtNgay;
        private System.Windows.Forms.Button btnTaoPX;
        private System.Windows.Forms.ComboBox cmbKho;
        private System.Windows.Forms.BindingSource cTPXBindingSource;
        private DSTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private DevExpress.XtraGrid.GridControl cTPXGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
    }
}