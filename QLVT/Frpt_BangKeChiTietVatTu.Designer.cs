namespace QLVT
{
    partial class Frpt_BangKeChiTietVatTu
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
            System.Windows.Forms.Label lblLoai;
            System.Windows.Forms.Label lblNgayKetThuc;
            System.Windows.Forms.Label lblNgayBatDau;
            this.btnThoat = new System.Windows.Forms.Button();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.detNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.detNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.btnPreview = new System.Windows.Forms.Button();
            lblLoai = new System.Windows.Forms.Label();
            lblNgayKetThuc = new System.Windows.Forms.Label();
            lblNgayBatDau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoai
            // 
            lblLoai.AutoSize = true;
            lblLoai.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLoai.Location = new System.Drawing.Point(43, 36);
            lblLoai.Name = "lblLoai";
            lblLoai.Size = new System.Drawing.Size(51, 21);
            lblLoai.TabIndex = 0;
            lblLoai.Text = "Loại:";
            // 
            // lblNgayKetThuc
            // 
            lblNgayKetThuc.AutoSize = true;
            lblNgayKetThuc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNgayKetThuc.Location = new System.Drawing.Point(465, 108);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Size = new System.Drawing.Size(92, 21);
            lblNgayKetThuc.TabIndex = 0;
            lblNgayKetThuc.Text = "Đến ngày:";
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.AutoSize = true;
            lblNgayBatDau.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNgayBatDau.Location = new System.Drawing.Point(43, 108);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new System.Drawing.Size(83, 21);
            lblNgayBatDau.TabIndex = 0;
            lblNgayBatDau.Text = "Từ ngày:";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(573, 245);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 52);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // pncNhapLieu
            // 
            this.pncNhapLieu.Controls.Add(lblLoai);
            this.pncNhapLieu.Controls.Add(this.cmbLoai);
            this.pncNhapLieu.Controls.Add(this.detNgayKetThuc);
            this.pncNhapLieu.Controls.Add(lblNgayKetThuc);
            this.pncNhapLieu.Controls.Add(lblNgayBatDau);
            this.pncNhapLieu.Controls.Add(this.detNgayBatDau);
            this.pncNhapLieu.Location = new System.Drawing.Point(89, 29);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(885, 165);
            this.pncNhapLieu.TabIndex = 4;
            // 
            // cmbLoai
            // 
            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "NHẬP",
            "XUẤT"});
            this.cmbLoai.Location = new System.Drawing.Point(158, 32);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(254, 29);
            this.cmbLoai.TabIndex = 1;
            // 
            // detNgayKetThuc
            // 
            this.detNgayKetThuc.EditValue = null;
            this.detNgayKetThuc.Location = new System.Drawing.Point(584, 104);
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
            this.detNgayKetThuc.TabIndex = 3;
            // 
            // detNgayBatDau
            // 
            this.detNgayBatDau.EditValue = null;
            this.detNgayBatDau.Location = new System.Drawing.Point(154, 104);
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
            this.detNgayBatDau.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(276, 245);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(150, 52);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "PREVIEW";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click_1);
            // 
            // Frpt_BangKeChiTietVatTu
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1062, 313);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.btnPreview);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frpt_BangKeChiTietVatTu";
            this.Text = "Quản lý vật tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frpt_BangKeChiTietVatTu_Load);
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
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private System.Windows.Forms.ComboBox cmbLoai;
        private DevExpress.XtraEditors.DateEdit detNgayKetThuc;
        private DevExpress.XtraEditors.DateEdit detNgayBatDau;
        private System.Windows.Forms.Button btnPreview;
    }
}