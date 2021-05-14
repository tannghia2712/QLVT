namespace QLVT
{
    partial class SubFormCTPN
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            this.DS = new QLVT.DS();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT.DSTableAdapters.CTDDHTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.cTPNTableAdapter = new QLVT.DSTableAdapters.CTPNTableAdapter();
            this.cTDDHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbCTDDH = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.spnDongia = new DevExpress.XtraEditors.SpinEdit();
            this.cTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spnSoluong = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaVT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPN = new DevExpress.XtraEditors.TextEdit();
            mAPNLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            this.gbCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnDongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(44, 47);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(67, 21);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "Mã PN:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(46, 92);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(67, 21);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "Mã VT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(29, 137);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(82, 21);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(38, 185);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(73, 21);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "CTDDH";
            this.cTDDHBindingSource.DataSource = this.DS;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // cTDDHGridControl
            // 
            this.cTDDHGridControl.DataSource = this.cTDDHBindingSource;
            this.cTDDHGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.cTDDHGridControl.Location = new System.Drawing.Point(374, 0);
            this.cTDDHGridControl.MainView = this.gvCTDDH;
            this.cTDDHGridControl.Name = "cTDDHGridControl";
            this.cTDDHGridControl.Size = new System.Drawing.Size(414, 311);
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
            this.gvCTDDH.GridControl = this.cTDDHGridControl;
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.OptionsBehavior.Editable = false;
            this.gvCTDDH.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvCTDDH.OptionsView.ShowGroupPanel = false;
            this.gvCTDDH.OptionsView.ShowIndicator = false;
            this.gvCTDDH.OptionsView.ShowViewCaption = true;
            this.gvCTDDH.ViewCaption = "Chi tiết đơn đặt hàng";
            this.gvCTDDH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCTDDH_RowClick);
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã số ĐĐH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 94;
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
            // gbCTDDH
            // 
            this.gbCTDDH.Controls.Add(this.btnOK);
            this.gbCTDDH.Controls.Add(dONGIALabel);
            this.gbCTDDH.Controls.Add(this.spnDongia);
            this.gbCTDDH.Controls.Add(sOLUONGLabel);
            this.gbCTDDH.Controls.Add(this.spnSoluong);
            this.gbCTDDH.Controls.Add(mAVTLabel);
            this.gbCTDDH.Controls.Add(this.txtMaVT);
            this.gbCTDDH.Controls.Add(mAPNLabel);
            this.gbCTDDH.Controls.Add(this.txtMaPN);
            this.gbCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTDDH.Location = new System.Drawing.Point(0, 0);
            this.gbCTDDH.Name = "gbCTDDH";
            this.gbCTDDH.Size = new System.Drawing.Size(374, 311);
            this.gbCTDDH.TabIndex = 2;
            this.gbCTDDH.TabStop = false;
            this.gbCTDDH.Text = "Thông tin";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(191, 239);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(136, 46);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // spnDongia
            // 
            this.spnDongia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "DONGIA", true));
            this.spnDongia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnDongia.Location = new System.Drawing.Point(117, 182);
            this.spnDongia.Name = "spnDongia";
            this.spnDongia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnDongia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnDongia.Size = new System.Drawing.Size(210, 26);
            this.spnDongia.TabIndex = 7;
            // 
            // cTPNBindingSource
            // 
            this.cTPNBindingSource.DataMember = "CTPN";
            this.cTPNBindingSource.DataSource = this.DS;
            // 
            // spnSoluong
            // 
            this.spnSoluong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "SOLUONG", true));
            this.spnSoluong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoluong.Location = new System.Drawing.Point(117, 134);
            this.spnSoluong.Name = "spnSoluong";
            this.spnSoluong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnSoluong.Size = new System.Drawing.Size(210, 26);
            this.spnSoluong.TabIndex = 5;
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "MAVT", true));
            this.txtMaVT.Location = new System.Drawing.Point(117, 89);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(210, 26);
            this.txtMaVT.TabIndex = 3;
            // 
            // txtMaPN
            // 
            this.txtMaPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "MAPN", true));
            this.txtMaPN.Location = new System.Drawing.Point(117, 44);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(210, 26);
            this.txtMaPN.TabIndex = 1;
            // 
            // SubFormCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 311);
            this.Controls.Add(this.gbCTDDH);
            this.Controls.Add(this.cTDDHGridControl);
            this.Name = "SubFormCTPN";
            this.Text = "Chi tiết phiếu nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormCTPN_FormClosing);
            this.Load += new System.EventHandler(this.SubFormCTPN_Load);
            this.Shown += new System.EventHandler(this.SubFormCTPN_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            this.gbCTDDH.ResumeLayout(false);
            this.gbCTDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnDongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl cTDDHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.GroupBox gbCTDDH;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource cTPNBindingSource;
        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraEditors.SpinEdit spnDongia;
        private DevExpress.XtraEditors.SpinEdit spnSoluong;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private DevExpress.XtraEditors.TextEdit txtMaPN;
    }
}