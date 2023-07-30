namespace QLVT
{
    partial class frmXoaTaiKhoan
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
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbTaiKhoan = new System.Windows.Forms.ComboBox();
            this.DS = new QLVT.DS();
            this.bdsAS = new System.Windows.Forms.BindingSource(this.components);
            this.ACCOUNT_STAFFTableAdapter = new QLVT.DSTableAdapters.ACCOUNT_STAFFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(53, 89);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(100, 21);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(390, 273);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 52);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(93, 273);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(150, 52);
            this.btnXoaTaiKhoan.TabIndex = 1;
            this.btnXoaTaiKhoan.Text = "XÓA";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.cmbTaiKhoan);
            this.panelControl1.Controls.Add(this.lblNhanVien);
            this.panelControl1.Location = new System.Drawing.Point(44, 33);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(545, 198);
            this.panelControl1.TabIndex = 0;
            // 
            // cmbTaiKhoan
            // 
            this.cmbTaiKhoan.DataSource = this.bdsAS;
            this.cmbTaiKhoan.DisplayMember = "HOTEN";
            this.cmbTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaiKhoan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTaiKhoan.FormattingEnabled = true;
            this.cmbTaiKhoan.Location = new System.Drawing.Point(207, 85);
            this.cmbTaiKhoan.Name = "cmbTaiKhoan";
            this.cmbTaiKhoan.Size = new System.Drawing.Size(285, 29);
            this.cmbTaiKhoan.TabIndex = 1;
            this.cmbTaiKhoan.ValueMember = "name";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsAS
            // 
            this.bdsAS.DataMember = "ACCOUNT_STAFF";
            this.bdsAS.DataSource = this.DS;
            // 
            // ACCOUNT_STAFFTableAdapter
            // 
            this.ACCOUNT_STAFFTableAdapter.ClearBeforeFill = true;
            // 
            // frmXoaTaiKhoan
            // 
            this.AcceptButton = this.btnXoaTaiKhoan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(632, 343);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaTaiKhoan);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXoaTaiKhoan";
            this.Text = "Xóa tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXoaTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbTaiKhoan;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsAS;
        private DSTableAdapters.ACCOUNT_STAFFTableAdapter ACCOUNT_STAFFTableAdapter;
    }
}