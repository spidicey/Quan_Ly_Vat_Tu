namespace QLVT
{
    partial class frmTaoTaiKhoan
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
            System.Windows.Forms.Label lblNhanVien;
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblMatKhauXacNhan = new System.Windows.Forms.Label();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtMatKhauXacNhan = new System.Windows.Forms.TextBox();
            this.rdbUser = new System.Windows.Forms.RadioButton();
            this.rdbChiNhanh = new System.Windows.Forms.RadioButton();
            this.rdbCongTy = new System.Windows.Forms.RadioButton();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.bdsNAS = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.NO_ACCOUNT_STAFFTableAdapter = new QLVT.DSTableAdapters.NO_ACCOUNT_STAFFTableAdapter();
            lblNhanVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNhanVien.Location = new System.Drawing.Point(28, 44);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new System.Drawing.Size(100, 21);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "Nhân viên:";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(28, 114);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(139, 21);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(28, 186);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(94, 21);
            this.lblMatKhau.TabIndex = 0;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblMatKhauXacNhan
            // 
            this.lblMatKhauXacNhan.AutoSize = true;
            this.lblMatKhauXacNhan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauXacNhan.Location = new System.Drawing.Point(28, 257);
            this.lblMatKhauXacNhan.Name = "lblMatKhauXacNhan";
            this.lblMatKhauXacNhan.Size = new System.Drawing.Size(172, 21);
            this.lblMatKhauXacNhan.TabIndex = 0;
            this.lblMatKhauXacNhan.Text = "Mật khẩu xác nhận:";
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaiTro.Location = new System.Drawing.Point(28, 329);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(70, 21);
            this.lblVaiTro.TabIndex = 0;
            this.lblVaiTro.Text = "Vai trò:";
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(168, 459);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(150, 52);
            this.btnTaoTaiKhoan.TabIndex = 4;
            this.btnTaoTaiKhoan.Text = "TẠO";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(465, 459);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 52);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(217, 110);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(330, 29);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_KeyPress);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(217, 182);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(330, 28);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // txtMatKhauXacNhan
            // 
            this.txtMatKhauXacNhan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauXacNhan.Location = new System.Drawing.Point(217, 253);
            this.txtMatKhauXacNhan.Name = "txtMatKhauXacNhan";
            this.txtMatKhauXacNhan.Size = new System.Drawing.Size(330, 28);
            this.txtMatKhauXacNhan.TabIndex = 3;
            this.txtMatKhauXacNhan.UseSystemPasswordChar = true;
            this.txtMatKhauXacNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauXacNhan_KeyPress);
            // 
            // rdbUser
            // 
            this.rdbUser.AutoSize = true;
            this.rdbUser.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUser.Location = new System.Drawing.Point(217, 327);
            this.rdbUser.Name = "rdbUser";
            this.rdbUser.Size = new System.Drawing.Size(64, 25);
            this.rdbUser.TabIndex = 0;
            this.rdbUser.Text = "User";
            this.rdbUser.UseVisualStyleBackColor = true;
            // 
            // rdbChiNhanh
            // 
            this.rdbChiNhanh.AutoSize = true;
            this.rdbChiNhanh.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChiNhanh.Location = new System.Drawing.Point(317, 327);
            this.rdbChiNhanh.Name = "rdbChiNhanh";
            this.rdbChiNhanh.Size = new System.Drawing.Size(109, 25);
            this.rdbChiNhanh.TabIndex = 0;
            this.rdbChiNhanh.Text = "Chi nhánh";
            this.rdbChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rdbCongTy
            // 
            this.rdbCongTy.AutoSize = true;
            this.rdbCongTy.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCongTy.Location = new System.Drawing.Point(459, 327);
            this.rdbCongTy.Name = "rdbCongTy";
            this.rdbCongTy.Size = new System.Drawing.Size(87, 25);
            this.rdbCongTy.TabIndex = 0;
            this.rdbCongTy.Text = "Công ty";
            this.rdbCongTy.UseVisualStyleBackColor = true;
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.DataSource = this.bdsNAS;
            this.cmbMaNV.DisplayMember = "HOTEN";
            this.cmbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaNV.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(217, 40);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(330, 29);
            this.cmbMaNV.TabIndex = 1;
            this.cmbMaNV.ValueMember = "MANV";
            // 
            // bdsNAS
            // 
            this.bdsNAS.DataMember = "NO_ACCOUNT_STAFF";
            this.bdsNAS.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pncNhapLieu
            // 
            this.pncNhapLieu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pncNhapLieu.Controls.Add(lblNhanVien);
            this.pncNhapLieu.Controls.Add(this.cmbMaNV);
            this.pncNhapLieu.Controls.Add(this.lblTenDangNhap);
            this.pncNhapLieu.Controls.Add(this.lblMatKhau);
            this.pncNhapLieu.Controls.Add(this.lblMatKhauXacNhan);
            this.pncNhapLieu.Controls.Add(this.lblVaiTro);
            this.pncNhapLieu.Controls.Add(this.rdbCongTy);
            this.pncNhapLieu.Controls.Add(this.txtTenDangNhap);
            this.pncNhapLieu.Controls.Add(this.rdbChiNhanh);
            this.pncNhapLieu.Controls.Add(this.txtMatKhau);
            this.pncNhapLieu.Controls.Add(this.rdbUser);
            this.pncNhapLieu.Controls.Add(this.txtMatKhauXacNhan);
            this.pncNhapLieu.Location = new System.Drawing.Point(104, 20);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(575, 392);
            this.pncNhapLieu.TabIndex = 6;
            // 
            // NO_ACCOUNT_STAFFTableAdapter
            // 
            this.NO_ACCOUNT_STAFFTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaoTaiKhoan
            // 
            this.AcceptButton = this.btnTaoTaiKhoan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(782, 523);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoTaiKhoan);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "Tạo tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmTaoTaiKhoan_Activated);
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsNAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblMatKhauXacNhan;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauXacNhan;
        private System.Windows.Forms.RadioButton rdbUser;
        private System.Windows.Forms.RadioButton rdbChiNhanh;
        private System.Windows.Forms.RadioButton rdbCongTy;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsNAS;
        private DSTableAdapters.NO_ACCOUNT_STAFFTableAdapter NO_ACCOUNT_STAFFTableAdapter;
    }
}