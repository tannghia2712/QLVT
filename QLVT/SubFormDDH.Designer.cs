namespace QLVT
{
    partial class SubFormDDH
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mANVLabel;
            this.DS = new QLVT.DS();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.gbDDH = new System.Windows.Forms.GroupBox();
            this.btnTaoDDH = new System.Windows.Forms.Button();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spnMaNV = new DevExpress.XtraEditors.SpinEdit();
            this.txtMakho = new DevExpress.XtraEditors.TextEdit();
            this.txtNhaCC = new DevExpress.XtraEditors.TextEdit();
            this.dtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMasoDDH = new DevExpress.XtraEditors.TextEdit();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT.DSTableAdapters.CTDDHTableAdapter();
            this.cTDDHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.khoTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            this.gbDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasoDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            this.panelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(27, 39);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(107, 21);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã số ĐĐH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(477, 89);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(53, 21);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(59, 90);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(75, 21);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà CC:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(51, 141);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(83, 21);
            mAKHOLabel.TabIndex = 6;
            mAKHOLabel.Text = "Mã KHO:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(462, 38);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(68, 21);
            mANVLabel.TabIndex = 8;
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
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // gbDDH
            // 
            this.gbDDH.AutoSize = true;
            this.gbDDH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbDDH.Controls.Add(this.btnTaoDDH);
            this.gbDDH.Controls.Add(this.cmbKho);
            this.gbDDH.Controls.Add(mANVLabel);
            this.gbDDH.Controls.Add(this.spnMaNV);
            this.gbDDH.Controls.Add(mAKHOLabel);
            this.gbDDH.Controls.Add(this.txtMakho);
            this.gbDDH.Controls.Add(nhaCCLabel);
            this.gbDDH.Controls.Add(this.txtNhaCC);
            this.gbDDH.Controls.Add(nGAYLabel);
            this.gbDDH.Controls.Add(this.dtNgay);
            this.gbDDH.Controls.Add(masoDDHLabel);
            this.gbDDH.Controls.Add(this.txtMasoDDH);
            this.gbDDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDDH.Location = new System.Drawing.Point(0, 0);
            this.gbDDH.Name = "gbDDH";
            this.gbDDH.Size = new System.Drawing.Size(1128, 192);
            this.gbDDH.TabIndex = 0;
            this.gbDDH.TabStop = false;
            this.gbDDH.Text = "Thông tin đơn đặt hàng";
            // 
            // btnTaoDDH
            // 
            this.btnTaoDDH.Location = new System.Drawing.Point(940, 64);
            this.btnTaoDDH.Name = "btnTaoDDH";
            this.btnTaoDDH.Size = new System.Drawing.Size(156, 71);
            this.btnTaoDDH.TabIndex = 11;
            this.btnTaoDDH.Text = "Tạo ĐĐH";
            this.btnTaoDDH.UseVisualStyleBackColor = true;
            this.btnTaoDDH.Click += new System.EventHandler(this.btnTaoDDH_Click);
            // 
            // cmbKho
            // 
            this.cmbKho.DataSource = this.khoBindingSource;
            this.cmbKho.DisplayMember = "TENKHO";
            this.cmbKho.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(357, 138);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(459, 24);
            this.cmbKho.TabIndex = 10;
            this.cmbKho.ValueMember = "MAKHO";
            this.cmbKho.SelectedIndexChanged += new System.EventHandler(this.cmbKho_SelectedIndexChanged);
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.DS;
            // 
            // spnMaNV
            // 
            this.spnMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MANV", true));
            this.spnMaNV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnMaNV.Location = new System.Drawing.Point(574, 33);
            this.spnMaNV.Name = "spnMaNV";
            this.spnMaNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnMaNV.Size = new System.Drawing.Size(242, 26);
            this.spnMaNV.TabIndex = 9;
            // 
            // txtMakho
            // 
            this.txtMakho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MAKHO", true));
            this.txtMakho.Location = new System.Drawing.Point(140, 139);
            this.txtMakho.Name = "txtMakho";
            this.txtMakho.Size = new System.Drawing.Size(183, 26);
            this.txtMakho.TabIndex = 7;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "NhaCC", true));
            this.txtNhaCC.Location = new System.Drawing.Point(140, 87);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(242, 26);
            this.txtNhaCC.TabIndex = 5;
            // 
            // dtNgay
            // 
            this.dtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "NGAY", true));
            this.dtNgay.EditValue = null;
            this.dtNgay.Location = new System.Drawing.Point(574, 87);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgay.Size = new System.Drawing.Size(242, 26);
            this.dtNgay.TabIndex = 3;
            // 
            // txtMasoDDH
            // 
            this.txtMasoDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MasoDDH", true));
            this.txtMasoDDH.Location = new System.Drawing.Point(140, 37);
            this.txtMasoDDH.Name = "txtMasoDDH";
            this.txtMasoDDH.Properties.MaxLength = 8;
            this.txtMasoDDH.Size = new System.Drawing.Size(242, 26);
            this.txtMasoDDH.TabIndex = 1;
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "FK_CTDDH_DatHang";
            this.cTDDHBindingSource.DataSource = this.datHangBindingSource;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // cTDDHGridControl
            // 
            this.cTDDHGridControl.DataSource = this.cTDDHBindingSource;
            this.cTDDHGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cTDDHGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cTDDHGridControl.Location = new System.Drawing.Point(0, 192);
            this.cTDDHGridControl.MainView = this.gvCTDDH;
            this.cTDDHGridControl.Margin = new System.Windows.Forms.Padding(8);
            this.cTDDHGridControl.Name = "cTDDHGridControl";
            this.cTDDHGridControl.Size = new System.Drawing.Size(1128, 385);
            this.cTDDHGridControl.TabIndex = 1;
            this.cTDDHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDDH});
            // 
            // gvCTDDH
            // 
            this.gvCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTDDH.DetailHeight = 852;
            this.gvCTDDH.GridControl = this.cTDDHGridControl;
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.OptionsBehavior.Editable = false;
            this.gvCTDDH.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvCTDDH.OptionsView.ShowGroupPanel = false;
            this.gvCTDDH.OptionsView.ShowIndicator = false;
            this.gvCTDDH.OptionsView.ShowViewCaption = true;
            this.gvCTDDH.ViewCaption = "Chi tiết đơn đặt hàng";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã số đơn đặt hàng";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 61;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 227;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 61;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 227;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 61;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 227;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 61;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 227;
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.btnXoa);
            this.panelBtn.Controls.Add(this.btnOK);
            this.panelBtn.Controls.Add(this.btnThem);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtn.Location = new System.Drawing.Point(0, 577);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(1128, 82);
            this.panelBtn.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(224, 14);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 43);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(863, 14);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(203, 52);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(31, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(156, 43);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // SubFormDDH
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 659);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.cTDDHGridControl);
            this.Controls.Add(this.gbDDH);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubFormDDH";
            this.Text = "Đơn đặt hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormDDH_FormClosing);
            this.Load += new System.EventHandler(this.SubFormDDH_Load);
            this.Shown += new System.EventHandler(this.SubFormDDH_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            this.gbDDH.ResumeLayout(false);
            this.gbDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasoDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            this.panelBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbDDH;
        private DevExpress.XtraEditors.TextEdit txtMakho;
        private DevExpress.XtraEditors.TextEdit txtNhaCC;
        private DevExpress.XtraEditors.DateEdit dtNgay;
        private DevExpress.XtraEditors.TextEdit txtMasoDDH;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.ComboBox cmbKho;
        private DevExpress.XtraEditors.SpinEdit spnMaNV;
        private DevExpress.XtraGrid.GridControl cTDDHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.Button btnTaoDDH;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnThem;
    }
}