namespace QLVT.Report
{
    partial class FrmCTNhapXuat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNhap = new System.Windows.Forms.CheckBox();
            this.cbXuat = new System.Windows.Forms.CheckBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.deToDate = new DevExpress.XtraEditors.DateEdit();
            this.deFromDate = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ tháng/năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến tháng/năm:";
            // 
            // cbNhap
            // 
            this.cbNhap.AutoSize = true;
            this.cbNhap.Location = new System.Drawing.Point(161, 148);
            this.cbNhap.Name = "cbNhap";
            this.cbNhap.Size = new System.Drawing.Size(72, 25);
            this.cbNhap.TabIndex = 2;
            this.cbNhap.Text = "Nhập";
            this.cbNhap.UseVisualStyleBackColor = true;
            this.cbNhap.CheckedChanged += new System.EventHandler(this.cbNhap_CheckedChanged);
            // 
            // cbXuat
            // 
            this.cbXuat.AutoSize = true;
            this.cbXuat.Location = new System.Drawing.Point(289, 148);
            this.cbXuat.Name = "cbXuat";
            this.cbXuat.Size = new System.Drawing.Size(67, 25);
            this.cbXuat.TabIndex = 3;
            this.cbXuat.Text = "Xuất";
            this.cbXuat.UseVisualStyleBackColor = true;
            this.cbXuat.CheckedChanged += new System.EventHandler(this.cbXuat_CheckedChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(83, 187);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(133, 37);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(288, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 37);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // deToDate
            // 
            this.deToDate.EditValue = null;
            this.deToDate.Location = new System.Drawing.Point(160, 113);
            this.deToDate.Margin = new System.Windows.Forms.Padding(6);
            this.deToDate.Name = "deToDate";
            this.deToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deToDate.Size = new System.Drawing.Size(262, 26);
            this.deToDate.TabIndex = 9;
            // 
            // deFromDate
            // 
            this.deFromDate.EditValue = null;
            this.deFromDate.Location = new System.Drawing.Point(160, 75);
            this.deFromDate.Margin = new System.Windows.Forms.Padding(6);
            this.deFromDate.Name = "deFromDate";
            this.deFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFromDate.Size = new System.Drawing.Size(261, 26);
            this.deFromDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(57, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bảng kê Chi tiết Nhập - Xuất";
            // 
            // FrmCTNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 244);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deToDate);
            this.Controls.Add(this.deFromDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cbXuat);
            this.Controls.Add(this.cbNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCTNhapXuat";
            this.Text = "Bảng Kê Chi tiết Nhập - Xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCTNhapXuat_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbNhap;
        private System.Windows.Forms.CheckBox cbXuat;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnExit;
        private DevExpress.XtraEditors.DateEdit deFromDate;
        private DevExpress.XtraEditors.DateEdit deToDate;
        private System.Windows.Forms.Label label3;
    }
}