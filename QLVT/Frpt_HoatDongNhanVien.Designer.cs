namespace QLVT
{
    partial class Frpt_HoatDongNhanVien
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
            System.Windows.Forms.Label lblMANV;
            System.Windows.Forms.Label lblNgayBatDau;
            System.Windows.Forms.Label lblNgayKetThuc;
            this.pncChiNhanh = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.cmbHOTENNV = new System.Windows.Forms.ComboBox();
            this.bdsHOTENNV = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.HOTENNVTableAdapter = new QLVT.DSTableAdapters.HOTENNVTableAdapter();
            this.detNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.detNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            lblMANV = new System.Windows.Forms.Label();
            lblNgayBatDau = new System.Windows.Forms.Label();
            lblNgayKetThuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).BeginInit();
            this.pncChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMANV
            // 
            lblMANV.AutoSize = true;
            lblMANV.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMANV.Location = new System.Drawing.Point(43, 36);
            lblMANV.Name = "lblMANV";
            lblMANV.Size = new System.Drawing.Size(100, 21);
            lblMANV.TabIndex = 0;
            lblMANV.Text = "Nhân viên:";
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
            // pncChiNhanh
            // 
            this.pncChiNhanh.Controls.Add(this.cmbChiNhanh);
            this.pncChiNhanh.Controls.Add(this.lblChiNhanh);
            this.pncChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pncChiNhanh.Location = new System.Drawing.Point(0, 0);
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
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(92, 20);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Chi nhánh:";
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(462, 32);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.ReadOnly = true;
            this.txtMANV.Size = new System.Drawing.Size(132, 29);
            this.txtMANV.TabIndex = 0;
            this.txtMANV.TabStop = false;
            // 
            // cmbHOTENNV
            // 
            this.cmbHOTENNV.DataSource = this.bdsHOTENNV;
            this.cmbHOTENNV.DisplayMember = "HOTEN";
            this.cmbHOTENNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHOTENNV.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHOTENNV.FormattingEnabled = true;
            this.cmbHOTENNV.Location = new System.Drawing.Point(158, 32);
            this.cmbHOTENNV.Name = "cmbHOTENNV";
            this.cmbHOTENNV.Size = new System.Drawing.Size(254, 29);
            this.cmbHOTENNV.TabIndex = 1;
            this.cmbHOTENNV.ValueMember = "MANV";
            this.cmbHOTENNV.SelectedIndexChanged += new System.EventHandler(this.cmbHOTENNV_SelectedIndexChanged);
            // 
            // bdsHOTENNV
            // 
            this.bdsHOTENNV.DataMember = "HOTENNV";
            this.bdsHOTENNV.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOTENNVTableAdapter
            // 
            this.HOTENNVTableAdapter.ClearBeforeFill = true;
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
            // pncNhapLieu
            // 
            this.pncNhapLieu.Controls.Add(lblMANV);
            this.pncNhapLieu.Controls.Add(this.cmbHOTENNV);
            this.pncNhapLieu.Controls.Add(this.detNgayKetThuc);
            this.pncNhapLieu.Controls.Add(this.txtMANV);
            this.pncNhapLieu.Controls.Add(lblNgayKetThuc);
            this.pncNhapLieu.Controls.Add(lblNgayBatDau);
            this.pncNhapLieu.Controls.Add(this.detNgayBatDau);
            this.pncNhapLieu.Location = new System.Drawing.Point(32, 82);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(885, 165);
            this.pncNhapLieu.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(516, 285);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 52);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(219, 285);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(150, 52);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "PREVIEW";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Frpt_HoatDongNhanVien
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
            this.Name = "Frpt_HoatDongNhanVien";
            this.Text = "Quản lý nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frpt_TinhHinhHoatDongNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).EndInit();
            this.pncChiNhanh.ResumeLayout(false);
            this.pncChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pncChiNhanh;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.ComboBox cmbHOTENNV;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsHOTENNV;
        private DSTableAdapters.HOTENNVTableAdapter HOTENNVTableAdapter;
        private DevExpress.XtraEditors.DateEdit detNgayBatDau;
        private DevExpress.XtraEditors.DateEdit detNgayKetThuc;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPreview;
    }
}