namespace QLVT
{
    partial class Frpt_TongHopNhapXuat
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
            System.Windows.Forms.Label lblNgayKetThuc;
            System.Windows.Forms.Label lblNgayBatDau;
            this.pncChiNhanh = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.detNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.detNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.btnPreview = new System.Windows.Forms.Button();
            lblNgayKetThuc = new System.Windows.Forms.Label();
            lblNgayBatDau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).BeginInit();
            this.pncChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNgayKetThuc
            // 
            lblNgayKetThuc.AutoSize = true;
            lblNgayKetThuc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNgayKetThuc.Location = new System.Drawing.Point(465, 71);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Size = new System.Drawing.Size(92, 21);
            lblNgayKetThuc.TabIndex = 4;
            lblNgayKetThuc.Text = "Đến ngày:";
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.AutoSize = true;
            lblNgayBatDau.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNgayBatDau.Location = new System.Drawing.Point(43, 71);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new System.Drawing.Size(83, 21);
            lblNgayBatDau.TabIndex = 5;
            lblNgayBatDau.Text = "Từ ngày:";
            // 
            // pncChiNhanh
            // 
            this.pncChiNhanh.Controls.Add(this.cmbChiNhanh);
            this.pncChiNhanh.Controls.Add(this.lblChiNhanh);
            this.pncChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pncChiNhanh.Location = new System.Drawing.Point(0, 0);
            this.pncChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.pncChiNhanh.Name = "pncChiNhanh";
            this.pncChiNhanh.Size = new System.Drawing.Size(1062, 56);
            this.pncChiNhanh.TabIndex = 0;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(131, 14);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(320, 28);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiNhanh.Location = new System.Drawing.Point(28, 18);
            this.lblChiNhanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(92, 20);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Chi nhánh:";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(516, 285);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 52);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pncNhapLieu
            // 
            this.pncNhapLieu.Controls.Add(this.detNgayKetThuc);
            this.pncNhapLieu.Controls.Add(lblNgayKetThuc);
            this.pncNhapLieu.Controls.Add(lblNgayBatDau);
            this.pncNhapLieu.Controls.Add(this.detNgayBatDau);
            this.pncNhapLieu.Location = new System.Drawing.Point(32, 82);
            this.pncNhapLieu.Margin = new System.Windows.Forms.Padding(4);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(885, 165);
            this.pncNhapLieu.TabIndex = 1;
            // 
            // detNgayKetThuc
            // 
            this.detNgayKetThuc.EditValue = null;
            this.detNgayKetThuc.Location = new System.Drawing.Point(584, 67);
            this.detNgayKetThuc.Name = "detNgayKetThuc";
            this.detNgayKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detNgayKetThuc.Properties.Appearance.Options.UseFont = true;
            this.detNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detNgayKetThuc.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.detNgayKetThuc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detNgayKetThuc.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.detNgayKetThuc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detNgayKetThuc.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.detNgayKetThuc.Size = new System.Drawing.Size(258, 28);
            this.detNgayKetThuc.TabIndex = 7;
            // 
            // detNgayBatDau
            // 
            this.detNgayBatDau.EditValue = null;
            this.detNgayBatDau.Location = new System.Drawing.Point(154, 67);
            this.detNgayBatDau.Name = "detNgayBatDau";
            this.detNgayBatDau.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detNgayBatDau.Properties.Appearance.Options.UseFont = true;
            this.detNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detNgayBatDau.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.detNgayBatDau.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detNgayBatDau.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.detNgayBatDau.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detNgayBatDau.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.detNgayBatDau.Size = new System.Drawing.Size(258, 28);
            this.detNgayBatDau.TabIndex = 6;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(219, 285);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(150, 52);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "PREVIEW";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Frpt_TongHopNhapXuat
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1062, 353);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.pncChiNhanh);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frpt_TongHopNhapXuat";
            this.Text = "Tổng hợp nhập xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frpt_TongHopNhapXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).EndInit();
            this.pncChiNhanh.ResumeLayout(false);
            this.pncChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayBatDau.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pncChiNhanh;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private System.Windows.Forms.Button btnPreview;
        private DevExpress.XtraEditors.DateEdit detNgayKetThuc;
        private DevExpress.XtraEditors.DateEdit detNgayBatDau;
    }
}