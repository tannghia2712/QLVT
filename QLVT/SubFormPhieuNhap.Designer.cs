namespace QLVT
{
    partial class SubFormPhieuNhap
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mANVLabel;
            this.DS = new QLVT.DS();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.cTPNTableAdapter = new QLVT.DSTableAdapters.CTPNTableAdapter();
            this.phieuNhapTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.gbPN = new System.Windows.Forms.GroupBox();
            this.spnMaNV = new DevExpress.XtraEditors.SpinEdit();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMakho = new DevExpress.XtraEditors.TextEdit();
            this.txtMasoDDH = new DevExpress.XtraEditors.TextEdit();
            this.dtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPN = new DevExpress.XtraEditors.TextEdit();
            this.btnTaoPN = new System.Windows.Forms.Button();
            this.cTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cTPNGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvCTPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            this.gbPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasoDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).BeginInit();
            this.panelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPN)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(51, 32);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(67, 21);
            mAPNLabel.TabIndex = 10;
            mAPNLabel.Text = "Mã PN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(65, 76);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(53, 21);
            nGAYLabel.TabIndex = 11;
            nGAYLabel.Text = "Ngày:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(356, 30);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(107, 21);
            masoDDHLabel.TabIndex = 12;
            masoDDHLabel.Text = "Mã số ĐĐH:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(747, 28);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(71, 21);
            mAKHOLabel.TabIndex = 13;
            mAKHOLabel.Text = "Mã kho:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(395, 76);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(68, 21);
            mANVLabel.TabIndex = 14;
            mANVLabel.Text = "Mã NV:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "DatHang";
            this.datHangBindingSource.DataSource = this.DS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // gbPN
            // 
            this.gbPN.Controls.Add(mANVLabel);
            this.gbPN.Controls.Add(this.spnMaNV);
            this.gbPN.Controls.Add(mAKHOLabel);
            this.gbPN.Controls.Add(this.txtMakho);
            this.gbPN.Controls.Add(masoDDHLabel);
            this.gbPN.Controls.Add(this.txtMasoDDH);
            this.gbPN.Controls.Add(nGAYLabel);
            this.gbPN.Controls.Add(this.dtNgay);
            this.gbPN.Controls.Add(mAPNLabel);
            this.gbPN.Controls.Add(this.txtMaPN);
            this.gbPN.Controls.Add(this.btnTaoPN);
            this.gbPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPN.Location = new System.Drawing.Point(0, 0);
            this.gbPN.Name = "gbPN";
            this.gbPN.Size = new System.Drawing.Size(1105, 126);
            this.gbPN.TabIndex = 2;
            this.gbPN.TabStop = false;
            this.gbPN.Text = "Thông tin phiếu nhập";
            // 
            // spnMaNV
            // 
            this.spnMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MANV", true));
            this.spnMaNV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnMaNV.Location = new System.Drawing.Point(469, 73);
            this.spnMaNV.Name = "spnMaNV";
            this.spnMaNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnMaNV.Size = new System.Drawing.Size(212, 26);
            this.spnMaNV.TabIndex = 15;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "FK_PhieuNhap_DatHang";
            this.phieuNhapBindingSource.DataSource = this.datHangBindingSource;
            // 
            // txtMakho
            // 
            this.txtMakho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MAKHO", true));
            this.txtMakho.Location = new System.Drawing.Point(824, 25);
            this.txtMakho.Name = "txtMakho";
            this.txtMakho.Size = new System.Drawing.Size(186, 26);
            this.txtMakho.TabIndex = 14;
            // 
            // txtMasoDDH
            // 
            this.txtMasoDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MasoDDH", true));
            this.txtMasoDDH.Location = new System.Drawing.Point(469, 29);
            this.txtMasoDDH.Name = "txtMasoDDH";
            this.txtMasoDDH.Size = new System.Drawing.Size(212, 26);
            this.txtMasoDDH.TabIndex = 13;
            // 
            // dtNgay
            // 
            this.dtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "NGAY", true));
            this.dtNgay.EditValue = null;
            this.dtNgay.Location = new System.Drawing.Point(124, 73);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgay.Size = new System.Drawing.Size(213, 26);
            this.dtNgay.TabIndex = 12;
            // 
            // txtMaPN
            // 
            this.txtMaPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MAPN", true));
            this.txtMaPN.Location = new System.Drawing.Point(124, 29);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(213, 26);
            this.txtMaPN.TabIndex = 11;
            // 
            // btnTaoPN
            // 
            this.btnTaoPN.Location = new System.Drawing.Point(802, 70);
            this.btnTaoPN.Name = "btnTaoPN";
            this.btnTaoPN.Size = new System.Drawing.Size(208, 32);
            this.btnTaoPN.TabIndex = 10;
            this.btnTaoPN.Text = "Tạo phiếu nhập";
            this.btnTaoPN.UseVisualStyleBackColor = true;
            this.btnTaoPN.Click += new System.EventHandler(this.btnTaoPN_Click);
            // 
            // cTPNBindingSource
            // 
            this.cTPNBindingSource.DataMember = "FK_CTPN_PhieuNhap";
            this.cTPNBindingSource.DataSource = this.phieuNhapBindingSource;
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.btnOK);
            this.panelBtn.Controls.Add(this.btnThem);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtn.Location = new System.Drawing.Point(0, 488);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(1105, 61);
            this.panelBtn.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(772, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(238, 46);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(49, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(157, 37);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cTPNGridControl
            // 
            this.cTPNGridControl.DataSource = this.cTPNBindingSource;
            this.cTPNGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTPNGridControl.Location = new System.Drawing.Point(0, 126);
            this.cTPNGridControl.MainView = this.gvCTPN;
            this.cTPNGridControl.Name = "cTPNGridControl";
            this.cTPNGridControl.Size = new System.Drawing.Size(1105, 362);
            this.cTPNGridControl.TabIndex = 3;
            this.cTPNGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPN});
            // 
            // gvCTPN
            // 
            this.gvCTPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTPN.GridControl = this.cTPNGridControl;
            this.gvCTPN.Name = "gvCTPN";
            this.gvCTPN.OptionsBehavior.Editable = false;
            this.gvCTPN.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvCTPN.OptionsView.ShowDetailButtons = false;
            this.gvCTPN.OptionsView.ShowGroupPanel = false;
            this.gvCTPN.OptionsView.ShowIndicator = false;
            this.gvCTPN.OptionsView.ShowViewCaption = true;
            this.gvCTPN.ViewCaption = "Chi tiết phiếu nhập";
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "Mã PN";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 25;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 94;
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
            // SubFormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 549);
            this.Controls.Add(this.cTPNGridControl);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.gbPN);
            this.Name = "SubFormPhieuNhap";
            this.Text = "SubFormPhieuNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormPhieuNhap_FormClosing);
            this.Load += new System.EventHandler(this.SubFormPhieuNhap_Load);
            this.Shown += new System.EventHandler(this.SubFormPhieuNhap_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            this.gbPN.ResumeLayout(false);
            this.gbPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasoDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).EndInit();
            this.panelBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTPNGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.GroupBox gbPN;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.Button btnTaoPN;
        private System.Windows.Forms.BindingSource cTPNBindingSource;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraGrid.GridControl cTPNGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraEditors.SpinEdit spnMaNV;
        private DevExpress.XtraEditors.TextEdit txtMakho;
        private DevExpress.XtraEditors.TextEdit txtMasoDDH;
        private DevExpress.XtraEditors.DateEdit dtNgay;
        private DevExpress.XtraEditors.TextEdit txtMaPN;
    }
}