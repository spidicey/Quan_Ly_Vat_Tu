namespace QLVT
{
    partial class frmDangNhap
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
            this.pnlThongTinDangNhap = new System.Windows.Forms.Panel();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pnlThongTinDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThongTinDangNhap
            // 
            this.pnlThongTinDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThongTinDangNhap.Controls.Add(this.cmbChiNhanh);
            this.pnlThongTinDangNhap.Controls.Add(this.txtMatKhau);
            this.pnlThongTinDangNhap.Controls.Add(this.txtTaiKhoan);
            this.pnlThongTinDangNhap.Controls.Add(this.lblMatKhau);
            this.pnlThongTinDangNhap.Controls.Add(this.lblTaiKhoan);
            this.pnlThongTinDangNhap.Controls.Add(this.lblChiNhanh);
            this.pnlThongTinDangNhap.Location = new System.Drawing.Point(108, 38);
            this.pnlThongTinDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.pnlThongTinDangNhap.Name = "pnlThongTinDangNhap";
            this.pnlThongTinDangNhap.Size = new System.Drawing.Size(566, 216);
            this.pnlThongTinDangNhap.TabIndex = 0;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(186, 34);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(330, 29);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.TabStop = false;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(186, 152);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(330, 28);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(186, 93);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(330, 28);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoan_KeyPress);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(48, 149);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(117, 35);
            this.lblMatKhau.TabIndex = 0;
            this.lblMatKhau.Text = "Mật khẩu:";
            this.lblMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(48, 90);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(117, 35);
            this.lblTaiKhoan.TabIndex = 0;
            this.lblTaiKhoan.Text = "Tài khoản:";
            this.lblTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiNhanh.Location = new System.Drawing.Point(48, 31);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(117, 35);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Chi nhánh:";
            this.lblChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(438, 340);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 52);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.TabStop = false;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(194, 340);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(150, 52);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.TabStop = false;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 413);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.pnlThongTinDangNhap);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.pnlThongTinDangNhap.ResumeLayout(false);
            this.pnlThongTinDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.Button btnThoat;
        public System.Windows.Forms.ComboBox cmbChiNhanh;
        public System.Windows.Forms.TextBox txtMatKhau;
        public System.Windows.Forms.TextBox txtTaiKhoan;
        public System.Windows.Forms.Panel pnlThongTinDangNhap;
        public System.Windows.Forms.Button btnDangNhap;
    }
}