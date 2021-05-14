namespace QLVT
{
    partial class SubFormCTPX
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            this.DS = new QLVT.DS();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvVT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbCTPX = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.spnDongia = new DevExpress.XtraEditors.SpinEdit();
            this.cTPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spnSoluong = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaVT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPX = new DevExpress.XtraEditors.TextEdit();
            this.cTPXTableAdapter = new QLVT.DSTableAdapters.CTPXTableAdapter();
            mAPXLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVT)).BeginInit();
            this.gbCTPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnDongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPX.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(47, 57);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(67, 21);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "Mã PX:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(49, 105);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(67, 21);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "Mã VT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(32, 155);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(82, 21);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(41, 202);
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
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.DS;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.DataSource = this.vattuBindingSource;
            this.vattuGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.vattuGridControl.Location = new System.Drawing.Point(389, 0);
            this.vattuGridControl.MainView = this.gvVT;
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(495, 324);
            this.vattuGridControl.TabIndex = 1;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVT});
            // 
            // gvVT
            // 
            this.gvVT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gvVT.GridControl = this.vattuGridControl;
            this.gvVT.Name = "gvVT";
            this.gvVT.OptionsBehavior.Editable = false;
            this.gvVT.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvVT.OptionsFind.AlwaysVisible = true;
            this.gvVT.OptionsView.ShowDetailButtons = false;
            this.gvVT.OptionsView.ShowGroupPanel = false;
            this.gvVT.OptionsView.ShowIndicator = false;
            this.gvVT.OptionsView.ShowViewCaption = true;
            this.gvVT.ViewCaption = "Danh sách vật tư";
            this.gvVT.Click += new System.EventHandler(this.gvVT_Click);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 94;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên VT";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 25;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 94;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 25;
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 94;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.MinWidth = 25;
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 94;
            // 
            // gbCTPX
            // 
            this.gbCTPX.Controls.Add(this.btnOK);
            this.gbCTPX.Controls.Add(dONGIALabel);
            this.gbCTPX.Controls.Add(this.spnDongia);
            this.gbCTPX.Controls.Add(sOLUONGLabel);
            this.gbCTPX.Controls.Add(this.spnSoluong);
            this.gbCTPX.Controls.Add(mAVTLabel);
            this.gbCTPX.Controls.Add(this.txtMaVT);
            this.gbCTPX.Controls.Add(mAPXLabel);
            this.gbCTPX.Controls.Add(this.txtMaPX);
            this.gbCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTPX.Location = new System.Drawing.Point(0, 0);
            this.gbCTPX.Name = "gbCTPX";
            this.gbCTPX.Size = new System.Drawing.Size(389, 324);
            this.gbCTPX.TabIndex = 2;
            this.gbCTPX.TabStop = false;
            this.gbCTPX.Text = "Thông tin";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(210, 260);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(131, 42);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // spnDongia
            // 
            this.spnDongia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPXBindingSource, "DONGIA", true));
            this.spnDongia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnDongia.Location = new System.Drawing.Point(120, 199);
            this.spnDongia.Name = "spnDongia";
            this.spnDongia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnDongia.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.spnDongia.Size = new System.Drawing.Size(221, 26);
            this.spnDongia.TabIndex = 7;
            // 
            // cTPXBindingSource
            // 
            this.cTPXBindingSource.DataMember = "CTPX";
            this.cTPXBindingSource.DataSource = this.DS;
            // 
            // spnSoluong
            // 
            this.spnSoluong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPXBindingSource, "SOLUONG", true));
            this.spnSoluong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoluong.Location = new System.Drawing.Point(120, 152);
            this.spnSoluong.Name = "spnSoluong";
            this.spnSoluong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnSoluong.Size = new System.Drawing.Size(221, 26);
            this.spnSoluong.TabIndex = 5;
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPXBindingSource, "MAVT", true));
            this.txtMaVT.Location = new System.Drawing.Point(120, 102);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(221, 26);
            this.txtMaVT.TabIndex = 3;
            // 
            // txtMaPX
            // 
            this.txtMaPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPXBindingSource, "MAPX", true));
            this.txtMaPX.Location = new System.Drawing.Point(120, 54);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(221, 26);
            this.txtMaPX.TabIndex = 1;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // SubFormCTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 324);
            this.Controls.Add(this.gbCTPX);
            this.Controls.Add(this.vattuGridControl);
            this.Name = "SubFormCTPX";
            this.Text = "Chi tiết phiếu xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormCTPX_FormClosing);
            this.Load += new System.EventHandler(this.SubFormCTPX_Load);
            this.Shown += new System.EventHandler(this.SubFormCTPX_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVT)).EndInit();
            this.gbCTPX.ResumeLayout(false);
            this.gbCTPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnDongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPX.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVT;
        private System.Windows.Forms.GroupBox gbCTPX;
        private System.Windows.Forms.BindingSource cTPXBindingSource;
        private DSTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraEditors.SpinEdit spnDongia;
        private DevExpress.XtraEditors.SpinEdit spnSoluong;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private DevExpress.XtraEditors.TextEdit txtMaPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
    }
}