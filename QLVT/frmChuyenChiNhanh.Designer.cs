namespace QLVT
{
    partial class frmChuyenChiNhanh
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
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.bdsOB = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.OTHER_BRANCHESTableAdapter = new QLVT.DSTableAdapters.OTHER_BRANCHESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiNhanh.Location = new System.Drawing.Point(119, 193);
            this.lblChiNhanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(138, 21);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Chi nhánh mới:";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DataSource = this.bdsOB;
            this.cmbChiNhanh.DisplayMember = "CHINHANH";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbChiNhanh.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(282, 189);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(250, 29);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.TabStop = false;
            this.cmbChiNhanh.ValueMember = "MACN";
            // 
            // bdsOB
            // 
            this.bdsOB.DataMember = "OTHER_BRANCHES";
            this.bdsOB.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(138, 293);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(155, 48);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(358, 293);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(155, 48);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(650, 60);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "CHUYỂN CHI NHÁNH";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(119, 124);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(100, 21);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(282, 120);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(250, 29);
            this.txtNhanVien.TabIndex = 0;
            this.txtNhanVien.TabStop = false;
            // 
            // OTHER_BRANCHESTableAdapter
            // 
            this.OTHER_BRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // frmChuyenChiNhanh
            // 
            this.AcceptButton = this.btnXacNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(650, 360);
            this.ControlBox = false;
            this.Controls.Add(this.txtNhanVien);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.lblChiNhanh);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChuyenChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển chi nhánh";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmChuyenChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.TextBox txtNhanVien;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsOB;
        private DSTableAdapters.OTHER_BRANCHESTableAdapter OTHER_BRANCHESTableAdapter;
    }
}